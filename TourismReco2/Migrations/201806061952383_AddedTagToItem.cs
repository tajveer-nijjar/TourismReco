namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTagToItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Tag", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Tag");
        }
    }
}
