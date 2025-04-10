using SmartTravelCompanion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace SmartTravelCompanion.Services
{
    public class DealService
    {
        private readonly TravelDbContext _context;
        private readonly HttpClient _httpClient;

        public DealService()
        {
            _context = new TravelDbContext();
            _httpClient = new HttpClient();
        }

        public void ScanDeals()
        {
            // Mock API call (sẽ thay bằng Skyscanner/Hostelworld API sau)
            var mockDeals = new List<Deal>
            {
                new Deal { Destination = "Hà Nội", Price = 1500000, TimeAvailable = DateTime.Now.AddHours(24), Link = "http://mocklink.com", Source = "MockAPI" },
                new Deal { Destination = "Đà Nẵng", Price = 3000000, TimeAvailable = DateTime.Now.AddHours(48), Link = "http://mocklink2.com", Source = "MockAPI" }
            };

            foreach (var deal in mockDeals)
            {
                if (!_context.Deals.Any(d => d.Destination == deal.Destination && d.Price == deal.Price))
                {
                    _context.Deals.Add(deal);
                }
            }
            _context.SaveChanges();
        }
        public void CheckAndNotify()
        {
            var preferences = _context.UserPreferences.Where(u => u.NotificationEnabled).ToList();
            var deals = _context.Deals.Where(d => d.TimeAvailable > DateTime.Now).ToList();

            foreach (var pref in preferences)
            {
                var destinations = pref.Destinations.Split(',').Select(d => d.Trim()).ToList();
                var matchingDeals = deals.Where(d => destinations.Contains(d.Destination) && d.Price <= pref.MaxPrice).ToList();

                foreach (var deal in matchingDeals)
                {
                    string message = $"New Deal: {deal.Destination} - {deal.Price} VND - Available until {deal.TimeAvailable} - {deal.Link}";
                    MessageBox.Show(message, "Deal Alert"); // Thay bằng email nếu cần
                }
            }
        }
    }
}
