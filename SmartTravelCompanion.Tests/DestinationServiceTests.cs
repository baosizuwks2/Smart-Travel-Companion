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
    public class DestinationServiceTests
    {
        [TestMethod]
        public void SuggestDestinations_ReturnsSuggestions()
        {
            // Arrange
            var service = new DestinationService();
            using (var context = new TravelDbContext())
            {
                context.Destinations.Add(new Destination
                {
                    Name = "Test Destination",
                    Description = "Test Desc",
                    UniqueReason = "Test Reason",
                    SafetyTips = "Test Tips",
                    ActivityType = "trekking"
                });
                context.SaveChanges();
            }
            // Act
            var suggestions = service.SuggestDestinations(1); // UserId không có sở thích cụ thể
            // Assert
            Assert.IsTrue(suggestions.Any(), "Should return at least one suggestion.");
        }
    }
}
