using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TravelPlannerAPI.Services;
using TravelPlannerLogic;

namespace TravelPlannerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TravelPlanController : ControllerBase
    {
        private readonly IBusScheduleReader reader;
        private readonly IBusScheduleParser parser;

        public TravelPlanController(IBusScheduleReader reader, IBusScheduleParser parser)
        {
            this.reader = reader;
            this.parser = parser;
        }

        [HttpGet]
        public ActionResult<BusScheduleInfo> GetSchedule([FromQuery] string from, string to, string start)
        {
            var data = reader.ReadBusScheduleAsync();
            var routes = parser.ParseBusSchedule(data.Result);
            RouteFinder finder = new RouteFinder(routes);
            var routeInfo = finder.FindRoute(from, to, start);
            if (routeInfo == null) return NotFound();
            return Ok(routeInfo);
        }
    }
}
