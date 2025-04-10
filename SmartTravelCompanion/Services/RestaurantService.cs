using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTravelCompanion.Models;

namespace SmartTravelCompanion.Services
{
    public class RestaurantService
    {
        private readonly TravelDbContext _context;
        public RestaurantService()
        {
            _context = new TravelDbContext();
        }
        public List<Restaurant> SuggestRestaurants(int userId, string location)
        {
            var user = _context.UserPreferences.FirstOrDefault(u => u.UserId == userId);
            var dietaryPrefs = user?.DietaryPreferences?.Split(',').Select(p => p.Trim()).ToList() ?? new List<string>();

            var suggestions = _context.Restaurants
                .Where(r => r.Location == location && (dietaryPrefs.Count == 0 || dietaryPrefs.Contains(r.CuisineType)))
                .Take(3)
                .ToList();
            return suggestions.Any() ? suggestions : new List<Restaurant>();
        }
    }
}
