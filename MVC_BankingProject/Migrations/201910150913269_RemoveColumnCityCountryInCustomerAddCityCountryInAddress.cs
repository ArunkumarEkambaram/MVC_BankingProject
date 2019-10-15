namespace MVC_BankingProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveColumnCityCountryInCustomerAddCityCountryInAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "City", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Addresses", "Country", c => c.String(maxLength: 100));
            DropColumn("dbo.Customers", "City");
            DropColumn("dbo.Customers", "Country");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Country", c => c.String());
            AddColumn("dbo.Customers", "City", c => c.String());
            DropColumn("dbo.Addresses", "Country");
            DropColumn("dbo.Addresses", "City");
        }
    }
}
