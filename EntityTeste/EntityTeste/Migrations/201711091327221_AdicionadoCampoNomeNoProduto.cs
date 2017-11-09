namespace EntityTeste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadoCampoNomeNoProduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "Nome", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produto", "Nome");
        }
    }
}
