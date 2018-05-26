using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourismReco2.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public List<Clan> Clans { get; set; }
        public List<SubClan> SubClans { get; set; }
        public List<Item> Items { get; set; }
        
    }
}