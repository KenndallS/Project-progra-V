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
    public class DireccionController : Controller
    {
        private readonly SolutionDBContext _context;

        public DireccionController(SolutionDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Direccion>>> GetDireccion()
        {
            return new Proyecto.BS.Direccion(_context).GetAll().ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<data.Direccion>> GetDireccion(int id)
        {
            var Direccion = new Proyecto.BS.Direccion(_context).GetOneById(id);

            if (Direccion == null)
            {
                return NotFound();
            }

            return Direccion;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDireccion(int id, data.Direccion Direccion)
        {
            if (id != Direccion.idDireccion)
            {
                return BadRequest();
            }

            try
            {
                new Proyecto.BS.Direccion(_context).Updated(Direccion);
            }
            catch (Exception)
            {
                if (!DireccionExists(id))
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
        public async Task<ActionResult<data.Direccion>> PostDireccion(data.Direccion Direccion)
        {
            new Proyecto.BS.Direccion(_context).Insert(Direccion);
            int _id = Direccion.idDireccion.Value;
            return Direccion;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Direccion>> DeleteDireccion(int id)
        {
            var Direccion = new Proyecto.BS.Direccion(_context).GetOneById(id);
            if (Direccion == null)
            {
                return NotFound();
            }

            new Proyecto.BS.Direccion(_context).Delete(Direccion);


            return Direccion;
        }

        private bool DireccionExists(int id)
        {
            return (new Proyecto.BS.Direccion(_context).GetOneById(id) != null);
        }
    }
}