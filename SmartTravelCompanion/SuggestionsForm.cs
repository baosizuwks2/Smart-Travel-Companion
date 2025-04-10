using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTravelCompanion
{
    public partial class SuggestionsForm : Form
    {
        public SuggestionsForm()
        {
            InitializeComponent();
        }

        private void btnRequestSuggestions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Requesting new suggestions...");
        }

        private void btnSaveDestination_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saving selected destination...");
        }
    }
}
