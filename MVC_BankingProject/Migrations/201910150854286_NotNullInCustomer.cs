namespace MVC_BankingProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotNullInCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "AddressLine1", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Addresses", "AddressLine2", c => c.String(maxLength: 100));
            AlterColumn("dbo.Addresses", "DoorNo", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Addresses", "FlatNo", c => c.String(maxLength: 50));
            AlterColumn("dbo.Addresses", "StreetName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Addresses", "BlockName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Customers", "MobileNumber", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Customers", "EmailId", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "EmailId", c => c.String());
            AlterColumn("dbo.Customers", "MobileNumber", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            AlterColumn("dbo.Addresses", "BlockName", c => c.String());
            AlterColumn("dbo.Addresses", "StreetName", c => c.String());
            AlterColumn("dbo.Addresses", "FlatNo", c => c.String());
            AlterColumn("dbo.Addresses", "DoorNo", c => c.String());
            AlterColumn("dbo.Addresses", "AddressLine2", c => c.String());
            AlterColumn("dbo.Addresses", "AddressLine1", c => c.String());
        }
    }
}
