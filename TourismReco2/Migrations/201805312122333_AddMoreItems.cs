namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreItems : DbMigration
    {
        public override void Up()
        {
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
