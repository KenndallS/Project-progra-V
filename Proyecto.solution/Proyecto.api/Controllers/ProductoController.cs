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
    public class ProductoController : Controller
    {
        private readonly SolutionDBContext _context;

        public ProductoController(SolutionDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Producto>>> GetProducto()
        {
            return new Proyecto.BS.Producto(_context).GetAll().ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<data.Producto>> GetProducto(int id)
        {
            var Producto = new Proyecto.BS.Producto(_context).GetOneById(id);

            if (Producto == null)
            {
                return NotFound();
            }

            return Producto;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducto(int id, data.Producto Producto)
        {
            if (id != Producto.idProducto)
            {
                return BadRequest();
            }

            try
            {
                new Proyecto.BS.Producto(_context).Updated(Producto);
            }
            catch (Exception)
            {
                if (!ProductoExists(id))
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
        public async Task<ActionResult<data.Producto>> PostProducto(data.Producto Producto)
        {
            new Proyecto.BS.Producto(_context).Insert(Producto);
            int _id = Producto.idProducto.Value;
            return Producto;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Producto>> DeleteProducto(int id)
        {
            var Producto = new Proyecto.BS.Producto(_context).GetOneById(id);
            if (Producto == null)
            {
                return NotFound();
            }

            new Proyecto.BS.Producto(_context).Delete(Producto);


            return Producto;
        }

        private bool ProductoExists(int id)
        {
            return (new Proyecto.BS.Producto(_context).GetOneById(id) != null);
        }
    }
}