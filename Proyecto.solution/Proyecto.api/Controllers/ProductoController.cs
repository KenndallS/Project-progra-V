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

        // GET: api/Usuario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Producto>>> GetProducto()
        {
            return new Proyecto.BS.Producto(_context).GetAll().ToList();
        }

        // GET: api/Usuario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data.Producto>> GetProducto(int id)
        {
            var Producto = new Proyecto.BS.Producto(_context).GetOneById(id);

            if (Producto == null)
            {
                return NotFound();
            }

            return Producto;
            //return null;
        }

        // PUT: api/Usuario/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
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
            //return null;
        }

        // POST: api/Usuario
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<data.Producto>> PostProducto(data.Producto Producto)
        {
            new Proyecto.BS.Producto(_context).Insert(Producto);
            int _id = Producto.idProducto.Value;
            return Producto;
        }

        // DELETE: api/Usuario/5
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
            //return null;
        }

        private bool ProductoExists(int id)
        {
            return (new Proyecto.BS.Producto(_context).GetOneById(id) != null);
        }
    }
}