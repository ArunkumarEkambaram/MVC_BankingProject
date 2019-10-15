namespace MVC_BankingProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetDefaultToCountry : DbMigration
    {
        public override void Up()
        {
            Sql("Alter table Addresses add constraint df_Addresses_Country Default 'India' for Country");
        }
        
        public override void Down()
        {
        }
    }
}
