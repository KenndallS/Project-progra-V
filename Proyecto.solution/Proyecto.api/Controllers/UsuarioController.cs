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
    public class UsuarioController : Controller
    {
        private readonly SolutionDBContext _context;

        public UsuarioController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Usuario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Usuario>>> GetUsuario()
        {
            return new Proyecto.BS.Usuario(_context).GetAll().ToList();
        }

        // GET: api/Usuario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data.Usuario>> GetUsuario(int id)
        {
            var Usuario = new Proyecto.BS.Usuario(_context).GetOneById(id);

            if (Usuario == null)
            {
                return NotFound();
            }

            return Usuario;
            //return null;
        }

        // PUT: api/Usuario/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, data.Usuario Usuario)
        {
            if (id != Usuario.idUsuario)
            {
                return BadRequest();
            }

            try
            {
                new Proyecto.BS.Usuario(_context).Updated(Usuario);
            }
            catch (Exception)
            {
                if (!UsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
            //return null;
        }

        // POST: api/Usuario
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<data.Usuario>> PostUsuario(data.Usuario Usuario)
        {
            new Proyecto.BS.Usuario(_context).Insert(Usuario);
            int _id = Usuario.idUsuario.Value;
            return Usuario;
        }

        // DELETE: api/Usuario/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Usuario>> DeleteUsuario(int id)
        {
            var Usuario = new Proyecto.BS.Usuario(_context).GetOneById(id);
            if (Usuario == null)
            {
                return NotFound();
            }

            new Proyecto.BS.Usuario(_context).Delete(Usuario);


            return Usuario;
            //return null;
        }

        private bool UsuarioExists(int id)
        {
            return (new Proyecto.BS.Usuario(_context).GetOneById(id) != null);
        }
    }


}