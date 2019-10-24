using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TravelPlannerAPI.Services
{
    public class BusScheduleInfo 
    {
        [JsonPropertyName("depart")]
        public string Depart { get; set; }

        [JsonPropertyName("departureTime")]
        public string DepartureTime { get; set; }

        [JsonPropertyName("arrive")]
        public string Arrive { get; set; }

        [JsonPropertyName("arrivalTime")]
        public string ArrivalTime { get; set; }
    }

    public class ToLinz
    {
        public string Leave { get; set; }
        public string Arrive { get; set; }
    }

    public class FromLinz
    {
        public string Leave { get; set; }
        public string Arrive { get; set; }
    }

    public class  BusRoutes
    {
        public string City { get; set; }
        public List<ToLinz> ToLinz { get; set; }
        public List<FromLinz> FromLinz { get; set; }
    }
}
