namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedItem : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "ItemType", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "ItemType", c => c.Int(nullable: false));
        }
    }
}
