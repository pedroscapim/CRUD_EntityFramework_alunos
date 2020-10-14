namespace CRUD_EntityFramework_alunos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.salaaulas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        professor = c.Int(nullable: false),
                        sala = c.Int(nullable: false),
                        curso = c.Int(nullable: false),
                        data = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.salaaulas");
        }
    }
}
