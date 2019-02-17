using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBFirst.Models
{
    public partial class CursoNetCoreContext : DbContext
    {
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Enderecos> Enderecos { get; set; }
        public virtual DbSet<Estudantes> Estudantes { get; set; }
        public virtual DbSet<EstudantesCurso> EstudantesCurso { get; set; }
        public virtual DbSet<Turmas> Turmas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-88FEEMU\SQLEXPRESS; Initial Catalog=CursoNetCore; Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>(entity =>
            {
                entity.Property(e => e.Nome).HasMaxLength(100);
            });

            modelBuilder.Entity<Enderecos>(entity =>
            {
                entity.HasIndex(e => e.EstudanteId)
                    .IsUnique();

                entity.HasOne(d => d.Estudante)
                    .WithOne(p => p.Enderecos)
                    .HasForeignKey<Enderecos>(d => d.EstudanteId);
            });

            modelBuilder.Entity<Estudantes>(entity =>
            {
                entity.HasIndex(e => e.TurmaId);

                entity.Property(e => e.CategoriaPagamento).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idade).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TurmaId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Turma)
                    .WithMany(p => p.Estudantes)
                    .HasForeignKey(d => d.TurmaId);
            });

            modelBuilder.Entity<EstudantesCurso>(entity =>
            {
                entity.HasKey(e => new { e.CursoId, e.EstudanteId });

                entity.HasIndex(e => e.EstudanteId);

                entity.HasOne(d => d.Curso)
                    .WithMany(p => p.EstudantesCurso)
                    .HasForeignKey(d => d.CursoId);

                entity.HasOne(d => d.Estudante)
                    .WithMany(p => p.EstudantesCurso)
                    .HasForeignKey(d => d.EstudanteId);
            });
        }
    }
}
