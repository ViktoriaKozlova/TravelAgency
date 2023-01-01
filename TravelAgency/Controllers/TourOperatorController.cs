using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using TravelAgency.Models;

namespace TravelAgency.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TourOperatorController : ControllerBase
    {
        private readonly ILogger<TourOperatorController> _logger;
        TravelAgencyContext db = new TravelAgencyContext();
        public TourOperatorController(ILogger<TourOperatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTourOperator")]

        public IEnumerable<TourOperator> Get()
        {

            var user = db.TourOperators.ToList();
            return (IEnumerable<TourOperator>)user;
            ;
        }

        [HttpPost]
        public void Post([FromBody] TourOperator r)
        {
            db.TourOperators.AddRange(r);
            db.SaveChanges();

        }
        [HttpPut]
        public async Task<ActionResult<TourOperator>> Put(TourOperator i)
        {
            if (i == null)
            {
                return BadRequest();
            }
            if (!db.TourOperators.Any(x => x.IdTourOperator == i.IdTourOperator))
            {
                return NotFound();
            }

            db.Update(i);
            await db.SaveChangesAsync();
            return Ok(i);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TourOperator>> Delete(int id)
        {
            TourOperator TourOperators = db.TourOperators.FirstOrDefault(x => x.IdTourOperator == id);
            if (TourOperators == null)
            {
                return NotFound();
            }
            db.TourOperators.Remove(TourOperators);
            await db.SaveChangesAsync();
            return Ok(TourOperators);
        }
    }
}

