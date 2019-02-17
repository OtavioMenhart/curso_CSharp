using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicoWebApiPaginacao.Models
{
    public class AulaContext : DbContext
    {
        public AulaContext() : base("DevMediaLocal")
        {
            //Database.Log = d => System.Diagnostics.Debug.WriteLine(d);
        }

        public DbSet<Curso> Cursos { get; set; }
    }
}