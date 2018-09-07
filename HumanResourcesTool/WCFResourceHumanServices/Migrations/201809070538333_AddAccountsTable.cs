namespace WCFResourceHumanServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAccountsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAccounts",
                c => new
                    {
                        Acc_Id = c.Int(nullable: false, identity: true),
                        Acc_Nick = c.String(nullable: false, maxLength: 100),
                        Acc_Pass = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Acc_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblAccounts");
        }
    }
}
