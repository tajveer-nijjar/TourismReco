namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedSubClanPriorityRegistration2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SubClanPriorityRegistrations", "PriorityLevel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SubClanPriorityRegistrations", "PriorityLevel", c => c.Int(nullable: false));
        }
    }
}
