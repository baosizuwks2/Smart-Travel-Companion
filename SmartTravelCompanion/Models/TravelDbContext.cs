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
        public TravelDbContext() : base("name=TravelDbConnection")
        {
        }

        public DbSet<Deal> Deals { get; set; }
        public DbSet<UserPreference> UserPreferences { get; set; }
    }
}
