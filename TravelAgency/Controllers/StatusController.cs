using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using TravelAgency.Models;

namespace TravelAgency.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusController : ControllerBase
    {
            private readonly ILogger<StatusController> _logger;
            TravelAgencyContext db = new TravelAgencyContext();
            public StatusController(ILogger<StatusController> logger)
            {
                _logger = logger;
            }

            [HttpGet(Name = "GetStatus")]

            public IEnumerable<Status> Get()
            {

                var user = db.Statuses.ToList();
                return (IEnumerable<Status>)user;
                ;
            }

            //[HttpPost]
            //public void Post([FromBody] Status r)
            //{
            //    db.Statuses.AddRange(r);
            //    db.SaveChanges();

            //}
            //[HttpPut]
            //public async Task<ActionResult<Status>> Put(Status i)
            //{
            //    if (i == null)
            //    {
            //        return BadRequest();
            //    }
            //    if (!db.Statuses.Any(x => x.IdStatus == i.IdStatus))
            //    {
            //        return NotFound();
            //    }

            //    db.Update(i);
            //    await db.SaveChangesAsync();
            //    return Ok(i);
            //}

            //[HttpDelete("{id}")]
            //public async Task<ActionResult<Status>> Delete(int id)
            //{
            //    Status status = db.Statuses.FirstOrDefault(x => x.IdStatus == id);
            //    if (status == null)
            //    {
            //        return NotFound();
            //    }
            //    db.Statuses.Remove(status);
            //    await db.SaveChangesAsync();
            //    return Ok(status);
            //}
        }
    }

