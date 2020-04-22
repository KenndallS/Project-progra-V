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
    public class OrdenController : Controller
    {
        private readonly SolutionDBContext _context;

        public OrdenController(SolutionDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Orden>>> GetOrden()
        {
            return new Proyecto.BS.Orden(_context).GetAll().ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<data.Orden>> GetOrden(int id)
        {
            var Orden = new Proyecto.BS.Orden(_context).GetOneById(id);

            if (Orden == null)
            {
                return NotFound();
            }

            return Orden;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrden(int id, data.Orden Orden)
        {
            if (id != Orden.idOrden)
            {
                return BadRequest();
            }

            try
            {
                new Proyecto.BS.Orden(_context).Updated(Orden);
            }
            catch (Exception)
            {
                if (!OrdenExists(id))
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
        public async Task<ActionResult<data.Orden>> PostOrden(data.Orden Orden)
        {
            new Proyecto.BS.Orden(_context).Insert(Orden);
            int _id = Orden.idOrden.Value;
            return Orden;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Orden>> DeleteOrden(int id)
        {
            var Orden = new Proyecto.BS.Orden(_context).GetOneById(id);
            if (Orden == null)
            {
                return NotFound();
            }

            new Proyecto.BS.Orden(_context).Delete(Orden);


            return Orden;
        }

        private bool OrdenExists(int id)
        {
            return (new Proyecto.BS.Orden(_context).GetOneById(id) != null);
        }
    }
}