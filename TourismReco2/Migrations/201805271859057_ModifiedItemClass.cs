namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedItemClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "SubClan_SubClanId", "dbo.SubClans");
            DropIndex("dbo.Items", new[] { "SubClan_SubClanId" });
            RenameColumn(table: "dbo.Items", name: "SubClan_SubClanId", newName: "SubClanId");
            AlterColumn("dbo.Items", "SubClanId", c => c.Int(nullable: false));
            CreateIndex("dbo.Items", "SubClanId");
            AddForeignKey("dbo.Items", "SubClanId", "dbo.SubClans", "SubClanId", cascadeDelete: true);
            DropColumn("dbo.Items", "SubClassId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "SubClassId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Items", "SubClanId", "dbo.SubClans");
            DropIndex("dbo.Items", new[] { "SubClanId" });
            AlterColumn("dbo.Items", "SubClanId", c => c.Int());
            RenameColumn(table: "dbo.Items", name: "SubClanId", newName: "SubClan_SubClanId");
            CreateIndex("dbo.Items", "SubClan_SubClanId");
            AddForeignKey("dbo.Items", "SubClan_SubClanId", "dbo.SubClans", "SubClanId");
        }
    }
}
