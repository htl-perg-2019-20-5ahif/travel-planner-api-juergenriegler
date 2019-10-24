using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TravelPlannerAPI.Services
{
    public class BusScheduleWebReader : IBusScheduleReader
    {
        private readonly IHttpClientFactory factory;
        private readonly IConfiguration config;

        public BusScheduleWebReader(IHttpClientFactory factory, IConfiguration config)
        {
            this.factory = factory;
            this.config = config;
        }

        public async Task<string> ReadBusScheduleAsync()
        {
            var client = factory.CreateClient();
            var response = await client.GetAsync(config["busScheduleJsonHttpUrl"]);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
