using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartTravelCompanion.Services;

namespace SmartTravelCompanion
{
    public partial class SuggestionsForm : Form
    {
        private readonly DestinationService _destinationService;
        private int _userId = 1; // Giả định UserId = 1, thay bằng logic đăng nhập sau
        public SuggestionsForm()
        {
            InitializeComponent();
            _destinationService = new DestinationService();
        }

        private void btnRequestSuggestions_Click(object sender, EventArgs e)
        {
            listViewSuggestions.Items.Clear();
            var suggestions = _destinationService.SuggestDestinations(_userId);

            if (suggestions.Count == 0)
            {
                MessageBox.Show("No suitable suggestions available.");
                return;
            }

            foreach (var dest in suggestions)
            {
                var item = new ListViewItem(new[] { dest.Name, dest.Description, dest.UniqueReason, dest.SafetyTips });
                item.Tag = dest.Id; // Lưu Id để dùng khi lưu
                listViewSuggestions.Items.Add(item);
            }
        }

        private void btnSaveDestination_Click(object sender, EventArgs e)
        {
            if (listViewSuggestions.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a destination to save.");
                return;
            }

            int destinationId = (int)listViewSuggestions.SelectedItems[0].Tag;
            _destinationService.SaveDestination(_userId, destinationId);
            MessageBox.Show("Destination saved successfully!");
        }
    }
}
