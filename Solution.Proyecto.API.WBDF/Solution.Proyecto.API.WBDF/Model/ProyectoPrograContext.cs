using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Solution.Proyecto.API.WBDF.Model
{
    public partial class ProyectoPrograContext : DbContext
    {
        public ProyectoPrograContext()
        {
        }

        public ProyectoPrograContext(DbContextOptions<ProyectoPrograContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Tienda> Tienda { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-7END51RG;Database=ProyectoProgra;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PK__Pedido__A9F619B75CC79097");

                entity.Property(e => e.IdPedido).HasColumnName("idPedido");

                entity.Property(e => e.Atendido).HasColumnName("atendido");

                entity.Property(e => e.CostoTotal).HasColumnType("money");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.IdTienda).HasColumnName("idTienda");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pedido__idProduc__4222D4EF");

                entity.HasOne(d => d.IdTiendaNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.IdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pedido__idTienda__412EB0B6");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pedido__idUsuari__4316F928");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK__Producto__07F4A1329EF6734A");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnName("comentario")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<Tienda>(entity =>
            {
                entity.HasKey(e => e.IdTienda)
                    .HasName("PK__tienda__CF09B22C8C8A7E82");

                entity.ToTable("tienda");

                entity.Property(e => e.IdTienda).HasColumnName("idTienda");

                entity.Property(e => e.DireccionTienda)
                    .IsRequired()
                    .HasColumnName("direccionTienda")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsuarioTiendaNavigation)
                    .WithMany(p => p.Tienda)
                    .HasForeignKey(d => d.UsuarioTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tienda__UsuarioT__3E52440B");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__645723A660567AEA");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasColumnName("apellido1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasColumnName("apellido2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnName("contrasena")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasColumnName("correo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoUsuario)
                    .IsRequired()
                    .HasColumnName("idTipoUsuario")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomUsuario)
                    .IsRequired()
                    .HasColumnName("nomUsuario")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono).HasColumnName("telefono");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
