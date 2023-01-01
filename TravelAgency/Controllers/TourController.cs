using Microsoft.AspNetCore.Mvc;

using TravelAgency.Models;

namespace TravelAgency.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TourController: ControllerBase
    {
        private readonly ILogger<TourController> _logger;
        TravelAgencyContext db = new TravelAgencyContext();
        public TourController(ILogger<TourController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "GetTour")]

        public IEnumerable<Tour> Get()
        {

            var user = db.Tours.ToList();
            return (IEnumerable<Tour>)user;
            ;
        }

        [HttpPost]
        public void Post([FromBody] Tour r)
        {
            db.Tours.AddRange(r);
            db.SaveChanges();

        }
        [HttpPut]
        public async Task<ActionResult<Tour>> Put(Tour i)
        {
            if (i == null)
            {
                return BadRequest();
            }
            if (!db.Tours.Any(x => x.IdTour == i.IdTour))
            {
                return NotFound();
            }

            db.Update(i);
            await db.SaveChangesAsync();
            return Ok(i);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tour>> Delete(int id)
        {
            Tour Tours = db.Tours.FirstOrDefault(x => x.IdTour == id);
            if (Tours == null)
            {
                return NotFound();
            }
            db.Tours.Remove(Tours);
            await db.SaveChangesAsync();
            return Ok(Tours);
        }



    }
}
