using System;
using System.Collections.Generic;
using System.Text;
using TravelPlannerLogic;

namespace TravelPlannerAPI.Services
{
    public interface IBusScheduleParser
    {
        // List<Route> ParseBusSchedule(string data);
        Route[] ParseBusSchedule(string data);
    }
}
