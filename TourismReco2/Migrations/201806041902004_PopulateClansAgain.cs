namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateClansAgain : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Clans (ClanName) VALUES ('Adventure and outdoor Travelers')");
            Sql("INSERT INTO Clans (ClanName) VALUES ('Art and design lovers')");
            Sql("INSERT INTO Clans (ClanName) VALUES ('Family travelers')");
            Sql("INSERT INTO Clans (ClanName) VALUES ('Foodies')");
            Sql("INSERT INTO Clans (ClanName) VALUES ('History buffs')");
            Sql("INSERT INTO Clans (ClanName) VALUES ('Luxury travelers')");
            Sql("INSERT INTO Clans (ClanName) VALUES ('Nightlife lovers')");
            Sql("INSERT INTO Clans (ClanName) VALUES ('Nature lovers')");

        }

        public override void Down()
        {
        }
    }
}
