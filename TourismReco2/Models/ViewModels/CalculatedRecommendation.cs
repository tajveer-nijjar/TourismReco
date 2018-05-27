using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourismReco2.Models.ViewModels
{
    public class CalculatedRecommendation
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int SubClandId { get; set; }
        
        
        public double CalcultedWeight { get; set; }

        public bool? ChosenByUser { get; set; }
        
    }
}