namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedSubClanPriorityRegistration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SubClanPriorityRegistrations", "PriorityLevel", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SubClanPriorityRegistrations", "PriorityLevel");
        }
    }
}
