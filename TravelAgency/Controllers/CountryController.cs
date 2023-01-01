using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using TravelAgency.Models;

namespace TravelAgency.Controllers
    {

        [ApiController]
        [Route("[controller]")]
        public class CountryController : ControllerBase
        {
            private readonly ILogger<CountryController> _logger;
            TravelAgencyContext db = new TravelAgencyContext();
            public CountryController(ILogger<CountryController> logger)
            {
                _logger = logger;
            }

            [HttpGet(Name = "GetCountry")]

            public IEnumerable<Country> Get()
            {

                var user = db.Countries.ToList();
                return (IEnumerable<Country>)user;
                ;
            }

            [HttpPost]
            public void Post([FromBody] Country r)
            {
                db.Countries.AddRange(r);
                db.SaveChanges();

            }
            [HttpPut]
            public async Task<ActionResult<Location>> Put(Country i)
            {
                if (i == null)
                {
                    return BadRequest();
                }
                if (!db.Countries.Any(x => x.IdCountry == i.IdCountry))
                {
                    return NotFound();
                }

                db.Update(i);
                await db.SaveChangesAsync();
                return Ok(i);
            }

            [HttpDelete("{id}")]
            public async Task<ActionResult<Country>> Delete(int id)
            {
            Country Countrys = db.Countries.FirstOrDefault(x => x.IdCountry == id);
                if (Countrys == null)
                {
                    return NotFound();
                }
                db.Countries.Remove(Countrys);
                await db.SaveChangesAsync();
                return Ok(Countrys);
            }
        }
    }

