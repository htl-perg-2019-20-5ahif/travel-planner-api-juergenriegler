using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TravelPlannerLogic
{
    public class RouteFinder
    {
        private readonly IEnumerable<Route> routes;

        public RouteFinder(IEnumerable<Route> routes)
        {
            this.routes = routes;
        }

        public RouteInfo FindRoute(string from, string to, string start)
        {
            var routeInfo = new RouteInfo { Depart = from, Arrive = to };

            if (from.ToUpper().Equals("LINZ"))
            {
                var time = GetTimesFromLinz(to, start);
                if (time == null) return null;
                routeInfo.DepartureTime = time.Leave;
                routeInfo.ArrivalTime = time.Arrive;
                return routeInfo;
            }

            if (to.ToUpper().Equals("LINZ"))
            {
                var time = GetTimesToLinz(from, start);
                if (time == null) return null;
                routeInfo.DepartureTime = time.Leave;
                routeInfo.ArrivalTime = time.Arrive;
                return routeInfo;
            }


            var timeToLinz = GetTimesToLinz(from, start);
            if (timeToLinz == null) return null;
            var timeFromLinz = GetTimesFromLinz(to, timeToLinz.Arrive);
            if (timeFromLinz == null) return null;
            routeInfo.DepartureTime = timeToLinz.Leave;
            routeInfo.ArrivalTime = timeFromLinz.Arrive;
            return routeInfo;
        }

        
        private Times GetTimesToLinz (string from, string start) =>
            routes
                .Where(r => r.City.ToUpper().Equals(from.ToUpper()))
                .First().ToLinz
                .Where(tl =>
                   int.Parse(tl.Leave.Replace(":", string.Empty))
                   >= int.Parse(start.Replace(":", string.Empty))
                )
                .FirstOrDefault();

        private Times GetTimesFromLinz (string to, string start) =>
            routes
                .Where(r => r.City.ToUpper().Equals(to.ToUpper()))
                .First().FromLinz
                .Where(fl =>
                   int.Parse(fl.Leave.Replace(":", string.Empty))
                   >= int.Parse(start.Replace(":", string.Empty))
                )
                .FirstOrDefault();
    }
}
