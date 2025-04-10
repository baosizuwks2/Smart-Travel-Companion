using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTravelCompanion.Models
{
    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UniqueReason { get; set; }
        public string SafetyTips { get; set; }
        public string ActivityType { get; set; }
    }
}
