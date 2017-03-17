using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;

namespace Backend.Controllers
{
    [Produces("application/json")]
    [Route("api/Airports")]
    public class AirportsController : Controller
    {
        private readonly IAirportRepository _airportRepository;

        public AirportsController(IAirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }

        // GET: api/Airports
        [HttpGet]
        [Route("api/Airports")]
        public IEnumerable<Airport> GetAirports()
        {
            return _airportRepository.GetAirports();
        }

        // GET: api/Airports/5
        [HttpGet("{id}", Name = "GetAirport")]
        public IActionResult GetById( int id)
        {
            var item = _airportRepository.FindAirport(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        // PUT: api/Airports/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Airport item)
        {
            if (item == null || item.ID != id)
            {
                return BadRequest();
            }
            var airport = _airportRepository.FindAirport(id);
            if (airport == null)
            {
                return NotFound();
            }
            airport.Name = item.Name;
            airport.Country = item.Country;
            airport.ThreeLetterCode = item.ThreeLetterCode;

            _airportRepository.UpdateAirport(airport);
            return new NoContentResult();
        }

        // POST: api/Airports
        [HttpPost]
        public IActionResult Create([FromBody] Airport item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            _airportRepository.AddAirport(item);
            return CreatedAtRoute("GetAirport", new {id = item.ID}, item);
        }

        // DELETE: api/Airports/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var airport = _airportRepository.FindAirport(id);
            if (airport == null)
            {
                return NotFound();
            }
            _airportRepository.RemoveAirport(id);
            return new NoContentResult();
        }
    }
}