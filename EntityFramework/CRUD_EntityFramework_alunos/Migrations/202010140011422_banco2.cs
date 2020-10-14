namespace CRUD_EntityFramework_alunos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.salaaulas", "professor", c => c.String());
            AlterColumn("dbo.salaaulas", "sala", c => c.String());
            AlterColumn("dbo.salaaulas", "curso", c => c.String());
            AlterColumn("dbo.salaaulas", "data", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.salaaulas", "data", c => c.Int(nullable: false));
            AlterColumn("dbo.salaaulas", "curso", c => c.Int(nullable: false));
            AlterColumn("dbo.salaaulas", "sala", c => c.Int(nullable: false));
            AlterColumn("dbo.salaaulas", "professor", c => c.Int(nullable: false));
        }
    }
}
