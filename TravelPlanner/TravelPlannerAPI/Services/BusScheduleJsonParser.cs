using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TravelPlannerLogic;

namespace TravelPlannerAPI.Services
{
    public class BusScheduleJsonParser : IBusScheduleParser
    {
        public Route[] ParseBusSchedule(string data)
        {
            return JsonSerializer.Deserialize<Route[]>(data);
        }
    }
}
