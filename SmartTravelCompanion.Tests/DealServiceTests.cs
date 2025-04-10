using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartTravelCompanion.Models;
using SmartTravelCompanion.Services;

namespace SmartTravelCompanion.Tests
{
    [TestClass]
    public class DealServiceTests
    {
        [TestMethod]
        public void ScanDeals_AddsNewDeals()
        {
            var service = new DealService();
            service.ScanDeals();

            using (var context = new TravelDbContext())
            {
                Assert.IsTrue(context.Deals.Any(d => d.Destination == "Hà Nội"));
            }
        }
    }
}
