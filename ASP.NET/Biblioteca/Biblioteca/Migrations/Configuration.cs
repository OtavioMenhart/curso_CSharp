namespace Biblioteca.Migrations
{
    using Biblioteca.DataContext;
    using Biblioteca.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Biblioteca.DataContext.BibliotecaDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BibliotecaDB context)
        {
            context.Categorias.AddOrUpdate(c => c.Nome, 
                new Categoria {Nome = "Ficção" },
                new Categoria { Nome = "Outros"});
            context.Autores.AddOrUpdate(l => l.Nome,
                new Autor {Nome = "J.K. Rowling" },
                new Autor { Nome = "Autor Inicial"});

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
