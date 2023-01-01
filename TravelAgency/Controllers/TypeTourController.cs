using Microsoft.AspNetCore.Mvc;

using TravelAgency.Models;

namespace TravelAgency.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TypeTourController : ControllerBase
    {
        private readonly ILogger<TypeTourController> _logger;
        TravelAgencyContext db = new TravelAgencyContext();
        public TypeTourController(ILogger<TypeTourController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "GetTypeTour")]

        public IEnumerable<TypeTour> Get()
        {

            var user = db.TypeTours.ToList();
            return (IEnumerable<TypeTour>)user;
            ;
        }

        //[HttpPost]
        //public void Post([FromBody] TypeTour r)
        //{
        //    db.TypeTours.AddRange(r);
        //    db.SaveChanges();

        //}
        //[HttpPut]
        //public async Task<ActionResult<Tour>> Put(TypeTour i)
        //{
        //    if (i == null)
        //    {
        //        return BadRequest();
        //    }
        //    if (!db.TypeTours.Any(x => x.IdTepyTour == i.IdTepyTour))
        //    {
        //        return NotFound();
        //    }

        //    db.Update(i);
        //    await db.SaveChangesAsync();
        //    return Ok(i);
        //}
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<TypeTour>> Delete(int id)
        //{
        //    TypeTour typeTour = db.TypeTours.FirstOrDefault(x => x.IdTepyTour == id);
        //    if (typeTour == null)
        //    {
        //        return NotFound();
        //    }
        //    db.TypeTours.Remove(typeTour);
        //    await db.SaveChangesAsync();
        //    return Ok(typeTour);
        //}



    }
}
