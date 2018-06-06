namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSomeMoreItems : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Burt Munro Statue', " +
                "'Gala Street, Invercargill 9840, New Zealand', " +
                "4.5, 22)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('St Pauls Presbyterian Church', " +
                "'178 Dee Street, Invercargill 9810, New Zealand', " +
                "4.5, 24)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Rakiura Track', " +
                "'Lee Bay Road, Rakiura National Park, Stewart Island, New Zealand', " +
                "4.5, 23)");


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Elegance at 148 on Elles', " +
                "'148 Elles Road, Invercargill 9812, New Zealand', " +
                "5, 25)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Redcliff Restaurant & Bar', " +
                "'12 Mokonui Street, Te Anau, Fiordland National Park 9600, New Zealand', " +
                "4.5, 25)");

            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Fiordland Massage Clinic', " +
                "'64 Lakefront Dr, Te Anau 9600', " +
                "4, 2)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Te Anau Hot Tubs and Sauna', " +
                "'Te Anau, Fiordland National Park, New Zealand', " +
                "4, 27)");




//            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
//                "('', " +
//                "'', " +
//                "4.5, 25)");


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Te Anau Glowworm Caves', " +
                "'Lakefront Drive, Te Anau, Fiordland National Park, New Zealand', " +
                "4.5, 30)");

            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Lake Manowai', " +
                "'Lake Manowai Road | near Clifden, Tuatapere, New Zealand', " +
                "4, 31)");

            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Colac Bay', " +
                "'Colac Foreshore Road, 9881, New Zealand', " +
                "4.5, 32)");


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Te Anau Glowworm Caves', " +
                "'Lakefront Drive, Te Anau, Fiordland National Park, New Zealand', " +
                "4.5, 30)");

        }

        public override void Down()
        {
        }
    }
}
