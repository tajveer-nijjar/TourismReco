namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedSubClanClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SubClans", "SubClanPriority", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SubClans", "SubClanPriority", c => c.Int(nullable: false));
        }
    }
}
