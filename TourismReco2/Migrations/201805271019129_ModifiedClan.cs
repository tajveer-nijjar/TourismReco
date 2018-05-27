namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedClan : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Clans", name: "ApplicationUser_Id", newName: "UserId");
            RenameIndex(table: "dbo.Clans", name: "IX_ApplicationUser_Id", newName: "IX_UserId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Clans", name: "IX_UserId", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.Clans", name: "UserId", newName: "ApplicationUser_Id");
        }
    }
}
