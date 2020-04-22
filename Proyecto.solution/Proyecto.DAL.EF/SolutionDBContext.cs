using Microsoft.EntityFrameworkCore;
using Proyecto.DO.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.DAL.EF
{
    public class SolutionDBContext : DbContext
    {
        public SolutionDBContext(DbContextOptions<SolutionDBContext> options) : base(options)
        {

        }
        public DbSet<AspNetUsers> AspNetUsers { get; set; }
        public DbSet<Carrito> Carrito { get; set; }
        public DbSet<Detalle> Detalle { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<MetodoPago> MetodoPago { get; set; }
        public DbSet<Orden> Orden { get; set; }
        public DbSet<Producto> Producto { get; set; }

    }
}
