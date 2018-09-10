namespace WCFResourceHumanServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeNullableTerminationDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblEmployees", "Emp_TerminationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblEmployees", "Emp_TerminationDate", c => c.DateTime(nullable: false));
        }
    }
}
