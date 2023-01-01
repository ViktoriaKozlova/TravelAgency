using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using TravelAgency.Models;

namespace TravelAgency.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ILogger<LocationController> _logger;
        TravelAgencyContext db = new TravelAgencyContext();
        public LocationController(ILogger<LocationController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetLocation")]

        public IEnumerable<Location> Get()
        {

            var user = db.Locations.ToList();
            return (IEnumerable<Location>)user;
            ;
        }

        [HttpPost]
        public void Post([FromBody] Location r)
        {
            db.Locations.AddRange(r);
            db.SaveChanges();

        }
        [HttpPut]
        public async Task<ActionResult<Location>> Put(Location i)
        {
            if (i == null)
            {
                return BadRequest();
            }
            if (!db.Locations.Any(x => x.IdLocation == i.IdLocation))
            {
                return NotFound();
            }

            db.Update(i);
            await db.SaveChangesAsync();
            return Ok(i);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Location>> Delete(int id)
        {
            Location Locations = db.Locations.FirstOrDefault(x => x.IdLocation == id);
            if (Locations == null)
            {
                return NotFound();
            }
            db.Locations.Remove(Locations);
            await db.SaveChangesAsync();
            return Ok(Locations);
        }
    }
}

