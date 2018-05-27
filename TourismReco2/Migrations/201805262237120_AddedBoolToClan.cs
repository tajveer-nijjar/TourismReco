namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBoolToClan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clans", "IsSelected", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clans", "IsSelected");
        }
    }
}
