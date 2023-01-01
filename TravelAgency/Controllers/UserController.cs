using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Text;
using System.Xml.Linq;
using TravelAgency.Models;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace TravelAgency.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        TravelAgencyContext db = new TravelAgencyContext();
        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUser")]

        public IEnumerable<User> Get()
        {

            var user = db.Users.ToList();
            return (IEnumerable<User>)user;
            
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await db.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPost]
        public void Post([FromBody] User r)
        {
            db.Users.AddRange(r);
            db.SaveChanges();

        }
        [HttpPut]
        public async Task<ActionResult<User>> Put(User i)
        {
            if (i == null)
            {
                return BadRequest();
            }
            if (!db.Users.Any(x => x.IdUser == i.IdUser))
            {
                return NotFound();
            }

            db.Update(i);
            await db.SaveChangesAsync();
            return Ok(i);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> Delete(int id)
        {
            User Users = db.Users.FirstOrDefault(x => x.IdUser == id);
            if (Users == null)
            {
                return NotFound();
            }
            db.Users.Remove(Users);
            await db.SaveChangesAsync();
            return Ok(Users);
        }
    }
}

