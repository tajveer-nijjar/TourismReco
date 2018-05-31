using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using TourismReco2.Models.ViewModels;

namespace TourismReco2.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Clan> Clans { get; set; }
        public DbSet<SubClan> SubClans { get; set; }
        public DbSet<UserClanRegisteration> UserClanRegisterations { get; set; }
        public DbSet<SubClanPriorityRegistration> SubClanPriorityRegistrations { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<CalculatedRecommendation> CalculatedRecommendations { get; set; }
        public DbSet<SelectedRecommendation> SelectedRecommendations { get; set; }
        

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

}