namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulatedItemsAgain : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Faith in Fiordland', '85 Lakefront Drive, Te Anau, Fiordland National Park 9600, New Zealand', 5, 2)");


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Cruise Milford', " +
                "'Milford Sound 9679, New Zealand', " +
                "5, 2)");


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
    "('Fiordland Jet', " +
    "'84 Lakefront Drive, Te Anau, Fiordland National Park 9600, New Zealand', " +
    "5, 2)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Fiordland Outdoors Co', " +
                "'cnr Oraka St and Milford Highway, Te Anau, Fiordland National Park 9600, New Zealand', " +
                "5, 2)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Rakiura Charters & Water Taxi', " +
                "'10 Main Rd. | Halfmoon Bay, Stewart Island 9846, New Zealand', " +
                "5, 2)");


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Doubtful Sound', " +
                "'Te Anau, Fiordland National Park, New Zealand', " +
                "5, 3)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Hump Ridge Track', " +
                "'31 Orawia Road, Tuatapere 9620, New Zealand', " +
                "4.5, 3)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Milford Sound', " +
                "'Te Anau, Fiordland National Park 9679, New Zealand', " +
                "4.5, 3)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Lake Te Anau', " +
                "'Te Anau, Fiordland National Park, New Zealand', " +
                "4.5, 3)");


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Hollyford Track', " +
                "'Te Anau-Milford Hwy, Fiordland National Park, New Zealand', " +
                "5, 4)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Routeburn Track', " +
                "'Routeburn Road, Fiordland National Park, Te Anau', " +
                "5, 4)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Milford Track', " +
                "'Glade Wharf | Fiordland National Park, Fiordland National Park', " +
                "5, 4)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Kepler Track', " +
                "'Golf Course Road | Eastern Fiordland, Te Anau, Fiordland National Park', " +
                "5, 4)");

            //            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
            //                "('Rosco's Milford Kayaks', " +
            //                "'Deep water basin, Milford Sound 9679, New Zealand', " +
            //                "5, 5)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Real Journeys', " +
                "'Waiau St | Real Journeys Visitor Centre, Pearl Harbour, Manapouri 9643, New Zealand', " +
                "4.5, 5)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Go Orange Kayaks', " +
                "'Sandy Brown Road, Te Anau, Fiordland National Park 9600, New Zealand', " +
                "4.5, 5)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Doubtful Sound Kayak', " +
                "'77 Manapouri | Te Anau Highway, Manapouri 9600, New Zealand', " +
                "4.5, 5)");


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Oreti Beach', " +
                "'563 Dunns Road, Invercargill 9879, New Zealand', " +
                "4.5, 6)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Gemstone Beach', " +
                "'Tuatapere-Orepuki Hwy, Orepuki, New Zealand', " +
                "4, 6)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Howells Point Reserve', " +
                "'Rocks Highway | Off Taramea Bay Road, Riverton 9822, New Zealand', " +
                "4.5, 6)");



            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Shark Dive New Zealand', " +
                "'Bluff 9814, New Zealand', " +
                "5, 7)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Shark Experience', " +
                "'64 Gore Street, Bluff 9841, New Zealand', " +
                "4.5, 7)");


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Anderson Park Art Gallery', " +
                "'91 McIvor Road, Invercargill 9876, New Zealand', " +
                "4, 8)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('City Gallery', " +
                "'28 Don Street, Invercargill 9810, New Zealand', " +
                "5, 8)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Otautau Gallery', " +
                "'10 Main Street, Otautau 9610, New Zealand', " +
                "5, 8)");



            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Bill Richardson Transport World', " +
                "'491 Tay St | Hawthorndale, Invercargill 9810', " +
                "5, 9)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Classic Motorcycle Mecca', " +
                "'25 Tay Street, Invercargill 9810, New Zealand', " +
                "5, 9)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Southern Discoveries - Milford Discovery Centre and Underwater Observatory', " +
                "'Milford Wharf | Harrison Cove, Milford Sound', " +
                "4.5, 9)");

        }

        public override void Down()
        {
        }
    }
}
