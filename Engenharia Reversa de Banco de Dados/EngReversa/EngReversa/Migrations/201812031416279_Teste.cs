namespace EngReversa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teste : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_CLIENTE", "TB_CLIENTE_PONTO_REFERENCIA", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_CLIENTE", "TB_CLIENTE_PONTO_REFERENCIA");
        }
    }
}
