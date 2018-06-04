using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourismReco2.Models
{
    public class UserClanRegisteration
    {
        public int Id { get; set; }
        
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        
        public int ClanId { get; set; }
        public Clan Clan { get; set; }
        
        public double? ClanPreference { get; set; }

        public int DateTimeDayOfTheYear { get; set; }
    }
}