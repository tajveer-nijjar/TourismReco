namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateItemsAgain : DbMigration
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

            
            
            
            
            
            
            


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
    "('E Hayes and Sons - The Worlds Fastest Indian', " +
    "'168 Dee Street, Invercargill, New Zealand', " +
    "4.5, 10)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Croydon Aviation Heritage Centre', " +
                "'1558 Waimea Highway, Mandeville 9776, New Zealand', " +
                "5, 10)");


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Bluff Maritime Museum', " +
                "'241 Foreshore Rd, Bluff, Bluff 9814, New Zealand', " +
                "4.5, 11)");


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Village & Bays Tours - Stewart Island Experience', " +
                "'Oban Visitor Centre | Elgin Terrace, Stewart Island 9846, New Zealand', " +
                "4.5, 12)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Takitimu Tiki Tours Te Anau', " +
                "'26 Mokonui Street, Te Anau, Fiordland National Park 9600', " +
                "5, 12)");

            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Queens Park', " +
                "'Queens Drive, Invercargill, New Zealand', " +
                "4.5, 14)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Punanga Manu o Te Anau', " +
                "'Lakefront Drive, Te Anau, Fiordland National Park 9640, New Zealand', " +
                "4, 14)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Turnbull Thompson Park', " +
                "'Lindisfarne Street, Invercargill, New Zealand', " +
                "4, 14)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Otakaro Park', " +
                "'Queens Drive, Invercargill, New Zealand', " +
                "4, 14)");


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Splash Palace', " +
                "'56 Elles Rd, Georgetown, Invercargill 9812', " +
                "4.4, 15)");




            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Sandfly Café', " +
                "'9 The Lane, Te Anau, Fiordland National Park 9600, New Zealand', " +
                "4.5, 19)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Niagara Falls Café', " +
                "'256 Niagara Waikawa Road, Niagara 9884, New Zealand', " +
                "4.5, 19)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('The Grille', " +
                "'491 Tay Street, Invercargill 9810, New Zealand', " +
                "4.5, 19)");



            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('KaiKart Takeaways', " +
                "'Ayr Street beside the Rakiura Museum, Stewart Island 9846, New Zealand', " +
                "4.5, 18)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Church Hill Restaurant', " +
                "'36 Kamahi Rd, Stewart Island 9846, New Zealand', " +
                "4.5, 18)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('South Sea Hotel dining room and pub', " +
                "'The Waterfront, Stewart Island, New Zealand', " +
                "4, 18)");


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Ristorante Pizzeria Paradiso Da Toni', " +
                "'1 Milford Crescent, Te Anau, Fiordland National Park 9600, New Zealand', " +
                "4, 20)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('La Toscana', " +
                "'108 Milford Rd, Te Anau, Fiordland National Park 9681, New Zealand', " +
                "4, 20)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Lighthouse Pizza', " +
                "'10 Main Road, Oban, Stewart Island 9846, New Zealand', " +
                "4.5, 20)");




            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Ming Garden Chinese Restaurant', " +
                "'Loop Rd, Te Anau, Fiordland National Park 9681, New Zealand', " +
                "3.5, 21)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Te Anau Dairy', " +
                "'76 Town Centr, Te Anau, Fiordland National Park, New Zealand', " +
                "4, 21)");


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Radhas Indian Restaurant & Takeaway', " +
                "'118 Town Centre | 118 Town Centre, Te Anau, Fiordland National Park 9600', " +
                "4.5, 17)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Pinch of Spice', " +
                "'29 Esk Street, Invercargill 9810, New Zealand', " +
                "5, 17)");
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Bombay Palace Invercargill', " +
                "'68 Forth Street, Invercargill 9810, New Zealand', " +
                "4.5, 17)");


            //            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
            //                "('', " +
            //                "'', " +
            //                ", 18)");

        }

        public override void Down()
        {
        }
    }
}
