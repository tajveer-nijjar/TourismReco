namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clans",
                c => new
                    {
                        ClanId = c.Int(nullable: false, identity: true),
                        ClanName = c.String(),
                        ClanPreference = c.Single(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ClanId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.SubClans",
                c => new
                    {
                        SubClanId = c.Int(nullable: false, identity: true),
                        SubClanName = c.String(),
                        SubClanPriority = c.Int(nullable: false),
                        ClanId = c.Int(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SubClanId)
                .ForeignKey("dbo.Clans", t => t.ClanId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ClanId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        ItemType = c.Int(nullable: false),
                        ItemAddress = c.String(),
                        ItemDescription = c.String(),
                        ItemRating = c.Single(nullable: false),
                        Location_Longitude = c.Single(nullable: false),
                        Location_Latitude = c.Single(nullable: false),
                        SubClassId = c.Int(nullable: false),
                        SubClan_SubClanId = c.Int(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.SubClans", t => t.SubClan_SubClanId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.SubClan_SubClanId)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubClans", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Items", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Clans", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.SubClans", "ClanId", "dbo.Clans");
            DropForeignKey("dbo.Items", "SubClan_SubClanId", "dbo.SubClans");
            DropIndex("dbo.Items", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Items", new[] { "SubClan_SubClanId" });
            DropIndex("dbo.SubClans", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.SubClans", new[] { "ClanId" });
            DropIndex("dbo.Clans", new[] { "ApplicationUser_Id" });
            DropTable("dbo.Items");
            DropTable("dbo.SubClans");
            DropTable("dbo.Clans");
        }
    }
}
