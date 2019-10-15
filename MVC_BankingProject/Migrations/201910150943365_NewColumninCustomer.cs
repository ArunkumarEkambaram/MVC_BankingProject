namespace MVC_BankingProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColumninCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerId", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "AccountNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "AccountNumber");
            DropColumn("dbo.Customers", "CustomerId");
        }
    }
}
