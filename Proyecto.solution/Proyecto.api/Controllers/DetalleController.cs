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
    public class DetalleController : Controller
    {
        private readonly SolutionDBContext _context;

        public DetalleController(SolutionDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Detalle>>> GetDetalle()
        {
            return new Proyecto.BS.Detalle(_context).GetAll().ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<data.Detalle>> GetDetalle(int id)
        {
            var Detalle = new Proyecto.BS.Detalle(_context).GetOneById(id);

            if (Detalle == null)
            {
                return NotFound();
            }

            return Detalle;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalle(int id, data.Detalle Detalle)
        {
            if (id != Detalle.idDetalle)
            {
                return BadRequest();
            }

            try
            {
                new Proyecto.BS.Detalle(_context).Updated(Detalle);
            }
            catch (Exception)
            {
                if (!DetalleExists(id))
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
        public async Task<ActionResult<data.Detalle>> PostDetalle(data.Detalle Detalle)
        {
            new Proyecto.BS.Detalle(_context).Insert(Detalle);
            int _id = Detalle.idDetalle.Value;
            return Detalle;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Detalle>> DeleteDetalle(int id)
        {
            var Detalle = new Proyecto.BS.Detalle(_context).GetOneById(id);
            if (Detalle == null)
            {
                return NotFound();
            }

            new Proyecto.BS.Detalle(_context).Delete(Detalle);


            return Detalle;
        }

        private bool DetalleExists(int id)
        {
            return (new Proyecto.BS.Detalle(_context).GetOneById(id) != null);
        }
    }
}