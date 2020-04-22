using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proyecto.DAL.EF;
using data = Proyecto.DO.Objects;

namespace Proyecto.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AspNetUsersController : Controller
    {
        private readonly SolutionDBContext _context;

        public AspNetUsersController(SolutionDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.AspNetUsers>>> GetAspNetUsers()
        {
            return new Proyecto.BS.AspNetUsers(_context).GetAll().ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<data.AspNetUsers>> GetAspNetUsers(string id)
        {
            var AspNetUsers = new Proyecto.BS.AspNetUsers(_context).GetOneById(Int32.Parse(id));

            if (AspNetUsers == null)
            {
                return NotFound();
            }

            return AspNetUsers;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAspNetUsers(string id, data.AspNetUsers AspNetUsers)
        {
            if (id != AspNetUsers.Id)
            {
                return BadRequest();
            }

            try
            {
                new Proyecto.BS.AspNetUsers(_context).Updated(AspNetUsers);
            }
            catch (Exception)
            {
                if (!AspNetUsersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<data.AspNetUsers>> PostAspNetUsers(data.AspNetUsers AspNetUsers)
        {
            new Proyecto.BS.AspNetUsers(_context).Insert(AspNetUsers);
            string _id = AspNetUsers.Id;
            return AspNetUsers;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<data.AspNetUsers>> DeleteAspNetUsers(string id)
        {
            var AspNetUsers = new Proyecto.BS.AspNetUsers(_context).GetOneById(Int32.Parse(id));
            if (AspNetUsers == null)
            {
                return NotFound();
            }

            new Proyecto.BS.AspNetUsers(_context).Delete(AspNetUsers);


            return AspNetUsers;
        }

        private bool AspNetUsersExists(string id)
        {
            return (new Proyecto.BS.AspNetUsers(_context).GetOneById(Int32.Parse(id)) != null);
        }
    }
}