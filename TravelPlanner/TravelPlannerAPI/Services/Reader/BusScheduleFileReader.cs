using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelPlannerAPI.Services
{
    public class BusScheduleFileReader : IBusScheduleReader
    {
        private readonly IConfiguration config;

        public BusScheduleFileReader(IConfiguration config)
        {
            this.config = config;
        }


        public async Task<string> ReadBusScheduleAsync() => 
            await System.IO.File.ReadAllTextAsync(config["busScheduleJsonFile"]);
    }
}
