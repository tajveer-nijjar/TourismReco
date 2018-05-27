namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoreSubClans : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Art Galleries', 3)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Speciality museums', 3)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('History Museums', 3)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Military', 3)");

            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Bus tours', 4)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Museums', 4)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Parks and playgrounds', 4)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Swimming pools', 4)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Gardens and parks', 4)");

            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Indian food', 5)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Seafood', 5)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Cafe', 5)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Pizza', 5)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Chinese', 5)");

            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Memorials', 6)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Historical trails', 6)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Historic churches', 6)");

            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Fine dine food', 7)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Food', 7)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Spas and wellness', 7)");

            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Bars and clubs', 8)");

            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Bodies of water', 8)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Nature and wildlife areas', 8)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Caves', 8)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Islands', 8)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Waterfalls', 8)");

        }

        public override void Down()
        {
        }
    }
}
