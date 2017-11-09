namespace EntityTeste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 60),
                        CategoriaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categoria", t => t.CategoriaId)
                .Index(t => t.CategoriaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produto", "CategoriaId", "dbo.Categoria");
            DropIndex("dbo.Produto", new[] { "CategoriaId" });
            DropTable("dbo.Produto");
            DropTable("dbo.Categoria");
        }
    }
}
