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
    public class CarritoController : Controller
    {
        private readonly SolutionDBContext _context;

        public CarritoController(SolutionDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Carrito>>> GetCarrito()
        {
            return new Proyecto.BS.Carrito(_context).GetAll().ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<data.Carrito>> GetCarrito(int id)
        {
            var Carrito = new Proyecto.BS.Carrito(_context).GetOneById(id);

            if (Carrito == null)
            {
                return NotFound();
            }

            return Carrito;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarrito(int id, data.Carrito Carrito)
        {
            if (id != Carrito.idCarrito)
            {
                return BadRequest();
            }

            try
            {
                new Proyecto.BS.Carrito(_context).Updated(Carrito);
            }
            catch (Exception)
            {
                if (!CarritoExists(id))
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
        public async Task<ActionResult<data.Carrito>> PostOrden(data.Carrito Carrito)
        {
            new Proyecto.BS.Carrito(_context).Insert(Carrito);
            int _id = Carrito.idCarrito.Value;
            return Carrito;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Carrito>> DeleteCarrito(int id)
        {
            var Carrito = new Proyecto.BS.Carrito(_context).GetOneById(id);
            if (Carrito == null)
            {
                return NotFound();
            }

            new Proyecto.BS.Carrito(_context).Delete(Carrito);


            return Carrito;
        }

        private bool CarritoExists(int id)
        {
            return (new Proyecto.BS.Carrito(_context).GetOneById(id) != null);
        }
    }
}