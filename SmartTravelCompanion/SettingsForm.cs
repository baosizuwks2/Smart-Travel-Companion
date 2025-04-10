using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartTravelCompanion.Models;
using SmartTravelCompanion.Services;

namespace SmartTravelCompanion
{
    public partial class SettingsForm : Form
    {
        private readonly TravelDbContext _context;
        public SettingsForm()
        {
            InitializeComponent();
            _context = new TravelDbContext();
            LoadPreferences();
        }

        private void LoadPreferences()
        {
            var pref = _context.UserPreferences.FirstOrDefault(u => u.UserId == 1); // Giả định UserId = 1
            if (pref != null)
            {
                chkNotificationEnabled.Checked = pref.NotificationEnabled;
                txtMaxPrice.Text = pref.MaxPrice.ToString();
                txtDestinations.Text = pref.Destinations;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var pref = _context.UserPreferences.FirstOrDefault(u => u.UserId == 1) ?? new UserPreference { UserId = 1 };
            pref.NotificationEnabled = chkNotificationEnabled.Checked;
            pref.MaxPrice = decimal.TryParse(txtMaxPrice.Text, out decimal maxPrice) ? maxPrice : 0;
            pref.Destinations = txtDestinations.Text;

            if (pref.UserId == 0) _context.UserPreferences.Add(pref);
            _context.SaveChanges();
            MessageBox.Show("Settings saved!");
        }
        private readonly DealService _dealService = new DealService();

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer { Interval = 300000 }; // 5 phút
            timer.Tick += (s, ev) => { _dealService.ScanDeals(); _dealService.CheckAndNotify(); };
            timer.Start();
        }
    }
}
