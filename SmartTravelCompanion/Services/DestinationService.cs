using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTravelCompanion.Models;

namespace SmartTravelCompanion.Services
{
    public class DestinationService
    {
        private readonly TravelDbContext _context;

        public DestinationService()
        {
            _context = new TravelDbContext();
        }

        public List<Destination> SuggestDestinations(int userId)
        {
            var user = _context.UserPreferences.FirstOrDefault(u => u.UserId == userId);
            var activities = user?.PreferredActivities?.Split(',').Select(a => a.Trim()).ToList() ?? new List<string>();

            var suggestions = _context.Destinations
                .Where(d => activities.Count == 0 || activities.Contains(d.ActivityType))
                .Take(3)
                .ToList();

            return suggestions.Any() ? suggestions : new List<Destination>();
        }
    }
}
