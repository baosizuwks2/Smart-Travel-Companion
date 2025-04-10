using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTravelCompanion.Models
{
    public class Deal
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
        public DateTime TimeAvailable { get; set; }
        public string Link { get; set; }
        public string Source { get; set; }
    }
}
