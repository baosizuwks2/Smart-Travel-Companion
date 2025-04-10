using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTravelCompanion.Models
{
    public class UserPreference
    {
        [Key]
        public int UserId { get; set; }
        public decimal MaxPrice { get; set; }
        public string Destinations { get; set; } // Lưu danh sách điểm đến dưới dạng chuỗi, ví dụ: "Hà Nội, Đà Nẵng"
        public bool NotificationEnabled { get; set; }
        public string PreferredActivities { get; set; }
    }
}
