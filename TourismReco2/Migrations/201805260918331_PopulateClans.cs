namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateClans : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Clans (ClanName) VALUES ('Adventure and outdoor Travelers')");
        }

        public override void Down()
        {
        }
    }
}
