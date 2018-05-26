namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedClan_SubClan_Item_UserProfile : DbMigration
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
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.ClanId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.SubClans",
                c => new
                    {
                        SubClanId = c.Int(nullable: false, identity: true),
                        SubClanName = c.String(),
                        SubClanPriority = c.Int(nullable: false),
                        ClanId = c.Int(nullable: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.SubClanId)
                .ForeignKey("dbo.Clans", t => t.ClanId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.ClanId)
                .Index(t => t.User_UserId);
            
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
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.SubClans", t => t.SubClan_SubClanId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.SubClan_SubClanId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubClans", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Items", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Clans", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.SubClans", "ClanId", "dbo.Clans");
            DropForeignKey("dbo.Items", "SubClan_SubClanId", "dbo.SubClans");
            DropIndex("dbo.Items", new[] { "User_UserId" });
            DropIndex("dbo.Items", new[] { "SubClan_SubClanId" });
            DropIndex("dbo.SubClans", new[] { "User_UserId" });
            DropIndex("dbo.SubClans", new[] { "ClanId" });
            DropIndex("dbo.Clans", new[] { "User_UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Items");
            DropTable("dbo.SubClans");
            DropTable("dbo.Clans");
        }
    }
}
