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
    public class MetodoPagoController : Controller
    {
        private readonly SolutionDBContext _context;

        public MetodoPagoController(SolutionDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.MetodoPago>>> GetMetodoPago()
        {
            return new Proyecto.BS.MetodoPago(_context).GetAll().ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<data.MetodoPago>> GetMetodoPago(int id)
        {
            var MetodoPago = new Proyecto.BS.MetodoPago(_context).GetOneById(id);

            if (MetodoPago == null)
            {
                return NotFound();
            }

            return MetodoPago;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMetodoPago(int id, data.MetodoPago MetodoPago)
        {
            if (id != MetodoPago.idMetodoPago)
            {
                return BadRequest();
            }

            try
            {
                new Proyecto.BS.MetodoPago(_context).Updated(MetodoPago);
            }
            catch (Exception)
            {
                if (!MetodoPagoExists(id))
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
        public async Task<ActionResult<data.MetodoPago>> PostMetodoPago(data.MetodoPago MetodoPago)
        {
            new Proyecto.BS.MetodoPago(_context).Insert(MetodoPago);
            int _id = MetodoPago.idMetodoPago.Value;
            return MetodoPago;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<data.MetodoPago>> DeleteMetodoPago(int id)
        {
            var MetodoPago = new Proyecto.BS.MetodoPago(_context).GetOneById(id);
            if (MetodoPago == null)
            {
                return NotFound();
            }

            new Proyecto.BS.MetodoPago(_context).Delete(MetodoPago);


            return MetodoPago;
        }

        private bool MetodoPagoExists(int id)
        {
            return (new Proyecto.BS.MetodoPago(_context).GetOneById(id) != null);
        }
    }
}