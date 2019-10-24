using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPlannerLogic
{
    public class RouteInfo
    {
        public string Depart { get; set; }
        public string DepartureTime { get; set; }
        public string Arrive { get; set; }
        public string ArrivalTime { get; set; }

        public RouteInfo(string depart, string departureTime, string arrive, string arrivalTime)
        {
            Depart = depart;
            DepartureTime = departureTime;
            Arrive = arrive;
            ArrivalTime = arrivalTime;
        }

        public RouteInfo()
        {

        }
    }
}
