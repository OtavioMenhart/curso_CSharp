using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIIntroducao.Models
{
    /*PARA GERAR AS TABELAS DE USUÁRIOS E PERMISSÕES (COMO EM IDENTITY) FOI NECESSÁRIO ADICIONAR UMA MIGRAÇÃO COM O DB CONTEXT ASSIM:
     ApplicationDbContext : IdentityDbContext<ApplicationUser>
     
      AO DAR UM UPDATE DATABASE DÁ ERRO, ENTÃO VOLTA PARA : DBCONTEXT*/
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
