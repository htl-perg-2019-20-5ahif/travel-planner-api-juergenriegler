using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelPlannerAPI.Services
{
    public interface IBusScheduleReader
    {
        Task<string> ReadBusScheduleAsync ();
    }
}
