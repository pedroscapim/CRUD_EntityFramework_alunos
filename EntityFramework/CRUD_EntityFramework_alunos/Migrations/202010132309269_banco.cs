namespace CRUD_EntityFramework_alunos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Agenda", "cep", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Agenda", "cep");
        }
    }
}
