namespace EngReversa.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BD_OS_SERVICOContext : DbContext
    {
        public BD_OS_SERVICOContext()
            : base("name=BD_OS_SERVICOContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<TB_CLIENTE> TB_CLIENTE { get; set; }
        public virtual DbSet<TB_OS> TB_OS { get; set; }
        public virtual DbSet<TB_SERVICO> TB_SERVICO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.TB_CLIENTE_NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.TB_CLIENTE_ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.TB_CLIENTE_PONTO_REFERENCIA)
                .IsUnicode(false);            

            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.TB_CLIENTE_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.TB_CLIENTE_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.TB_CLIENTE_RG)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.TB_CLIENTE_BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.TB_CLIENTE_CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.TB_CLIENTE_TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.TB_CLIENTE_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .HasMany(e => e.TB_OS)
                .WithRequired(e => e.TB_CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_OS>()
                .Property(e => e.TB_OS_DESCRICAO_PROBLEMA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OS>()
                .Property(e => e.TB_OS_STATUS_OS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OS>()
                .Property(e => e.TB_OS_PARECER_TECNICO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SERVICO>()
                .Property(e => e.TB_SERVICO_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SERVICO>()
                .Property(e => e.TB_SERVICO_PECRO)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TB_SERVICO>()
                .HasMany(e => e.TB_OS)
                .WithRequired(e => e.TB_SERVICO)
                .WillCascadeOnDelete(false);
        }
    }
}
