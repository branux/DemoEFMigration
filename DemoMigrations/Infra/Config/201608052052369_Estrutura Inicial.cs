namespace DemoMigrations.Infra.Config
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EstruturaInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cliente", "Nascimento", c => c.DateTime());
            AddColumn("dbo.Cliente", "EmpresaId", c => c.Int());
            CreateIndex("dbo.Cliente", "EmpresaId");
            AddForeignKey("dbo.Cliente", "EmpresaId", "dbo.Empresa", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "EmpresaId", "dbo.Empresa");
            DropIndex("dbo.Cliente", new[] { "EmpresaId" });
            DropColumn("dbo.Cliente", "EmpresaId");
            DropColumn("dbo.Cliente", "Nascimento");
            DropTable("dbo.Empresa");
        }
    }
}
