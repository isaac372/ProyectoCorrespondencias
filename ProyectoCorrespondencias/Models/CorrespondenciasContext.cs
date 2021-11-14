using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProyectoCorrespondencias.Models
{
    public partial class CorrespondenciasContext : DbContext
    {
        public CorrespondenciasContext()
        {
        }

        public CorrespondenciasContext(DbContextOptions<CorrespondenciasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Destinatario> Destinatarios { get; set; }
        public virtual DbSet<Plantilla> Plantillas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\;Database=Correspondencias;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Destinatario>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.IdPlantilla).HasColumnName("idPlantilla");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdPlantillaNavigation)
                    .WithMany(p => p.Destinatarios)
                    .HasForeignKey(d => d.IdPlantilla)
                    .HasConstraintName("FK_Destinatarios_Plantilla");
            });

            modelBuilder.Entity<Plantilla>(entity =>
            {
                entity.ToTable("Plantilla");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contacto)
                    .IsUnicode(false)
                    .HasColumnName("contacto");

                entity.Property(e => e.Contribucion)
                    .IsUnicode(false)
                    .HasColumnName("contribucion");

                entity.Property(e => e.Descripcion)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
