using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Data;

namespace Backend.Models
{
    public class AirportRepository : IAirportRepository
    {
        private readonly Phase4Context _context;

        public AirportRepository(Phase4Context context)
        {
            _context = context;

        }

        public IEnumerable<Airport> GetAirports()
        {
            return _context.Airports.ToList();
        }

        public void AddAirport(Airport item)
        {
            _context.Airports.Add(item);
            _context.SaveChanges();
        }

        public Airport FindAirport(int id)
        {
            return _context.Airports.FirstOrDefault(s => s.ID == id);
        }

        public void RemoveAirport(int id)
        {
            var entity= _context.Airports.First(s => s.ID == id);
            _context.Airports.Remove(entity);
            _context.SaveChanges();
        }

        public void UpdateAirport(Airport item)
        {
            _context.Airports.Update(item);
            _context.SaveChanges();
        }
    }
}
