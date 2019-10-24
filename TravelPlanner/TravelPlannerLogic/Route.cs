using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPlannerLogic
{
    public class Route
    {
        public string City { get; set; }
        public Times[] ToLinz { get; set; }
        public Times[] FromLinz { get; set; }

        public Route(string city, Times[] toLinz, Times[] fromLinz)
        {
            City = city;
            ToLinz = toLinz;
            FromLinz = fromLinz;
        }
        public Route()
        {

        }
    }
}
