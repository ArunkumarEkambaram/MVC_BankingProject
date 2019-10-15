namespace MVC_BankingProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class RenameColumnHouseNoToDoorNo : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Addresses", "DoorNo", c => c.String());
            //DropColumn("dbo.Addresses", "HouseNo");

            RenameColumn("dbo.Addresses", "HouseNo", "DoorNo");
        }

        public override void Down()
        {
            //AddColumn("dbo.Addresses", "HouseNo", c => c.String());
            //DropColumn("dbo.Addresses", "DoorNo");
            RenameColumn("dbo.Addresses", "DoorNo", "HouseNo");
        }
    }
}
