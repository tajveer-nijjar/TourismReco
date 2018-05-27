using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourismReco2.Models
{
    public class SubClanPriorityRegistration
    {
        public int Id { get; set; }

        public int SubClanId { get; set; }
        public SubClan SubClan { get; set; }
        
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public double? PriorityLevel { get; set; }
    }
}