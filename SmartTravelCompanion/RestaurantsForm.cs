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
    public partial class RestaurantsForm : Form
    {
        private readonly RestaurantService _restaurantService;
        private int _userId = 1; // Giả định UserId = 1, thay bằng logic đăng nhập sau
        public RestaurantsForm()
        {
            InitializeComponent();
            _restaurantService = new RestaurantService();
            txtLocation.Text = "Hà Nội"; // Giá trị mặc định để test
        }

        private void btnRequestSuggestion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter a location.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listViewRestaurants.Items.Clear();
            try
            {
                var suggestions = _restaurantService.SuggestRestaurants(_userId, txtLocation.Text);
                if (suggestions.Count == 0)
                {
                    MessageBox.Show($"No suitable restaurants found for {txtLocation.Text}.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var restaurant in suggestions)
                {
                    var item = new ListViewItem(new[]
                    {
                        restaurant.Name,
                        restaurant.Description,
                        restaurant.CuisineType,
                        restaurant.Location,
                        restaurant.PriceRange
                    });
                    item.Tag = restaurant.Id; // Lưu Id để dùng khi lưu
                    listViewRestaurants.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching suggestions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveRestaurant_Click(object sender, EventArgs e)
        {
            if (listViewRestaurants.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a restaurant to save.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int restaurantId = (int)listViewRestaurants.SelectedItems[0].Tag;
                _restaurantService.SaveRestaurant(_userId, restaurantId);
                MessageBox.Show("Restaurant saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving restaurant: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

