namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSubClanPriorityRegistration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubClanPriorityRegistrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubClanId = c.Int(nullable: false),
                        UserId = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.SubClans", t => t.SubClanId, cascadeDelete: true)
                .Index(t => t.SubClanId)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubClanPriorityRegistrations", "SubClanId", "dbo.SubClans");
            DropForeignKey("dbo.SubClanPriorityRegistrations", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.SubClanPriorityRegistrations", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.SubClanPriorityRegistrations", new[] { "SubClanId" });
            DropTable("dbo.SubClanPriorityRegistrations");
        }
    }
}
