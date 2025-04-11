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
        public void SaveRestaurant(int userId, int restaurantId)
        {
            try
            {
                if (!_context.SavedRestaurants.Any(sr => sr.UserId == userId && sr.RestaurantId == restaurantId))
                {
                    var restaurantExists = _context.Restaurants.Any(r => r.Id == restaurantId);
                    if (!restaurantExists)
                    {
                        throw new ArgumentException($"Restaurant with ID {restaurantId} does not exist.");
                    }

                    _context.SavedRestaurants.Add(new SavedRestaurant
                    {
                        UserId = userId,
                        RestaurantId = restaurantId
                    });
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to save restaurant: " + ex.Message, ex);
            }
        }
    }
}
