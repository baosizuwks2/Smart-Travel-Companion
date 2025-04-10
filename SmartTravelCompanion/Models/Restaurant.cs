using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTravelCompanion.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CuisineType { get; set; } // Ví dụ: vegetarian, spicy, local
        public string Location { get; set; }
        public string PriceRange { get; set; } // Ví dụ: "100k-200k VND"
    }
}
