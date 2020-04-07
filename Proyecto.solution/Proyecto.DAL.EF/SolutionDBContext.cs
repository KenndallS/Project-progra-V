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

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
