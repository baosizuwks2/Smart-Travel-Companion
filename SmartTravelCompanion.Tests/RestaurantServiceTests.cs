using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartTravelCompanion.Models;
using SmartTravelCompanion.Services;

namespace SmartTravelCompanion.Tests
{
    [TestClass]
    public class RestaurantServiceTests
    {
        private TravelDbContext _context;

        [TestInitialize]
        public void Setup()
        {
            _context = new TravelDbContext();
            // Thêm dữ liệu mẫu để test
            _context.Restaurants.Add(new Restaurant
            {
                Name = "Test Restaurant",
                Description = "Test Desc",
                CuisineType = "vegetarian",
                Location = "Hà Nội",
                PriceRange = "100k-200k"
            });
            _context.SaveChanges();
        }

        [TestMethod]
        public void SuggestRestaurants_ReturnsMatchingSuggestions()
        {
            // Arrange
            var service = new RestaurantService();
            int userId = 1; // Giả định không có sở thích cụ thể

            // Act
            var suggestions = service.SuggestRestaurants(userId, "Hà Nội");

            // Assert
            Assert.IsTrue(suggestions.Any(), "Should return at least one suggestion.");
            Assert.IsTrue(suggestions.All(r => r.Location == "Hà Nội"), "All suggestions should match the location.");
        }

        [TestCleanup]
        public void Cleanup()
        {
            _context.Restaurants.RemoveRange(_context.Restaurants);
            _context.SaveChanges();
            _context.Dispose();
        }
    }
}
