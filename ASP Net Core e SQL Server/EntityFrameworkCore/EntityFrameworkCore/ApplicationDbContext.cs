using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkCore
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstudanteCurso>().HasKey(x => new { x.CursoId, x.EstudanteId });
            modelBuilder.Entity<EstudanteCurso>().HasQueryFilter(x => x.Ativo == true);
            modelBuilder.Entity<Estudante>().HasOne(x => x.EstudanteDetalhe).WithOne(x => x.Estudante).HasForeignKey<EstudanteDetalhe>(x => x.Id);
            modelBuilder.Entity<EstudanteDetalhe>().ToTable("Estudantes");



        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-88FEEMU\SQLEXPRESS; Initial Catalog=CursoNetCore; Integrated Security=True")
                //opcional - serve para mostrar logs da conexão no console
                //precisa ter insatalado a biblioteca Microsoft.Extensions.Logging.Console
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(new LoggerFactory()
                .AddConsole((category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name));
        }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries().Where(e => e.State == EntityState.Deleted && e.Metadata.GetProperties().Any(x => x.Name == "EstaExcluido")))
            {
                item.State = EntityState.Unchanged;
                item.CurrentValues["EstaExcluido"] = true;
            }
            return base.SaveChanges();
        }

        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<EstudanteCurso> EstudantesCurso { get; set; }
        public DbSet<Curso> Curso { get; set; }
    }
}
