namespace WCFResourceHumanServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKtoCitiesForEmployees : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.tblEmployees", "Cit_CityId");
            AddForeignKey("dbo.tblEmployees", "Cit_CityId", "dbo.tblCities", "Cit_CityId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblEmployees", "Cit_CityId", "dbo.tblCities");
            DropIndex("dbo.tblEmployees", new[] { "Cit_CityId" });
        }
    }
}
