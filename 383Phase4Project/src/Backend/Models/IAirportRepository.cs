using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public interface IAirportRepository
    {
        void AddAirport(Airport item);
        IEnumerable<Airport> GetAirports();
        Airport FindAirport(int id);
        void RemoveAirport(int id);
        void UpdateAirport(Airport item);
    }
}
