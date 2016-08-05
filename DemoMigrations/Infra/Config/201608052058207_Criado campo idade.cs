namespace DemoMigrations.Infra.Config
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criadocampoidade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empresa", "Idade", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empresa", "Idade");
        }
    }
}
