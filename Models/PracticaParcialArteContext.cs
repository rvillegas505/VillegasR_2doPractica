using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace VillegasR_2doPractica.Models
{
    public partial class PracticaParcialArteContext : DbContext
    {
        public PracticaParcialArteContext()
        {
        }

        public PracticaParcialArteContext(DbContextOptions<PracticaParcialArteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ObraDeArte> ObraDeArtes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-UGUAUNU\\SQLEXPRESS;Database=PracticaParcialArte;user=sa;password=abcd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ObraDeArte>(entity =>
            {
                entity.ToTable("ObraDeArte");

                entity.Property(e => e.Nombre).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
