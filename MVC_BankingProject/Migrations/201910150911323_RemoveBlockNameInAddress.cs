namespace MVC_BankingProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveBlockNameInAddress : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Addresses", "BlockName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "BlockName", c => c.String(maxLength: 100));
        }
    }
}
