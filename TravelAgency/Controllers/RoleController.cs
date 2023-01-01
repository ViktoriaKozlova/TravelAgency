
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Text;
using System.Xml.Linq;
using TravelAgency.Models;
using System.Data;

namespace TravelAgency.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly ILogger<RoleController> _logger;
        TravelAgencyContext db = new TravelAgencyContext();
        public RoleController(ILogger<RoleController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRole")]

        public IEnumerable<Role> Get()
        {

            var Roles = db.Roles.ToList();
            return (IEnumerable<Role>)Roles;

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Role>> GetUser(int id)
        {
            var role = await db.Roles.FindAsync(id);

            if (role == null)
            {
                return NotFound();
            }

            return role;
        }

        [HttpPost]
        public void Post([FromBody] Role r)
        {
            db.Roles.AddRange(r);
            db.SaveChanges();

        }
        [HttpPut]
        public async Task<ActionResult<Role>> Put(Role i)
        {
            if (i == null)
            {
                return BadRequest();
            }
            if (!db.Roles.Any(x => x.IdRole == i.IdRole))
            {
                return NotFound();
            }

            db.Update(i);
            await db.SaveChangesAsync();
            return Ok(i);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Role>> Delete(int id)
        {
            Role Roles = db.Roles.FirstOrDefault(x => x.IdRole == id);
            if (Roles == null)
            {
                return NotFound();
            }
            db.Roles.Remove(Roles);
            await db.SaveChangesAsync();
            return Ok(Roles);
        }
    }
}

