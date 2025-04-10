using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTravelCompanion.Models
{
    public class TravelDbContext : DbContext
    {
        public TravelDbContext() : base("name=TravelDbConnection") { }

        public DbSet<Deal> Deals { get; set; }
        public DbSet<UserPreference> UserPreferences { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<SavedDestination> SavedDestinations { get; set; }
    }

    public class SavedDestination
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DestinationId { get; set; }
    }
}
