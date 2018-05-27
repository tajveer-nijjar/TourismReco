namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSubClans : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Boat tours', 2)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Nature and wildlife tourstours', 2)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Hiking', 2)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Kayaking', 2)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Beaches', 2)");
            Sql("INSERT INTO SubClans (SubClanName, ClanId) VALUES ('Scuba and snorkling', 2)");

        }

        public override void Down()
        {
        }
    }
}
