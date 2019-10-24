using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPlannerLogic
{
    public class Times
    {
        public string Leave { get; set; }
        public string Arrive { get; set; }

        public Times(string leave, string arrive)
        {
            Leave = leave;
            Arrive = arrive;
        }
        public Times()
        {

        }
    }
}
