namespace MVC_BankingProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateColumnInCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "DeactivatedDate", c => c.DateTime());
            AddColumn("dbo.Customers", "Status", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Status");
            DropColumn("dbo.Customers", "DeactivatedDate");
            DropColumn("dbo.Customers", "CreatedDate");
        }
    }
}
