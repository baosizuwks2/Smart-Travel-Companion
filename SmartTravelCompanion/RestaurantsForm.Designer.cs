namespace SmartTravelCompanion
{
    partial class RestaurantsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewRestaurants = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRequestSuggestion = new System.Windows.Forms.Button();
            this.btnSaveRestaurant = new System.Windows.Forms.Button();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CuisineType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceRange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLocation);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 63);
            this.panel1.TabIndex = 0;
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(22, 20);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(115, 28);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(143, 15);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(630, 33);
            this.txtLocation.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewRestaurants);
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 342);
            this.panel2.TabIndex = 1;
            // 
            // listViewRestaurants
            // 
            this.listViewRestaurants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.Description,
            this.CuisineType,
            this.Location,
            this.PriceRange});
            this.listViewRestaurants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRestaurants.FullRowSelect = true;
            this.listViewRestaurants.GridLines = true;
            this.listViewRestaurants.HideSelection = false;
            this.listViewRestaurants.Location = new System.Drawing.Point(0, 0);
            this.listViewRestaurants.Name = "listViewRestaurants";
            this.listViewRestaurants.Size = new System.Drawing.Size(1002, 342);
            this.listViewRestaurants.TabIndex = 0;
            this.listViewRestaurants.UseCompatibleStateImageBehavior = false;
            this.listViewRestaurants.View = System.Windows.Forms.View.Details;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveRestaurant);
            this.panel3.Controls.Add(this.btnRequestSuggestion);
            this.panel3.Location = new System.Drawing.Point(0, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 92);
            this.panel3.TabIndex = 2;
            // 
            // btnRequestSuggestion
            // 
            this.btnRequestSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestSuggestion.Location = new System.Drawing.Point(87, 9);
            this.btnRequestSuggestion.Name = "btnRequestSuggestion";
            this.btnRequestSuggestion.Size = new System.Drawing.Size(319, 76);
            this.btnRequestSuggestion.TabIndex = 1;
            this.btnRequestSuggestion.Text = "Request New Suggestions";
            this.btnRequestSuggestion.UseVisualStyleBackColor = true;
            this.btnRequestSuggestion.Click += new System.EventHandler(this.btnRequestSuggestion_Click);
            // 
            // btnSaveRestaurant
            // 
            this.btnSaveRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRestaurant.Location = new System.Drawing.Point(594, 9);
            this.btnSaveRestaurant.Name = "btnSaveRestaurant";
            this.btnSaveRestaurant.Size = new System.Drawing.Size(319, 76);
            this.btnSaveRestaurant.TabIndex = 1;
            this.btnSaveRestaurant.Text = "Save Selected";
            this.btnSaveRestaurant.UseVisualStyleBackColor = true;
            this.btnSaveRestaurant.Click += new System.EventHandler(this.btnSaveRestaurant_Click);
            // 
            // colName
            // 
            this.colName.Text = "Restaurant";
            this.colName.Width = 170;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 220;
            // 
            // CuisineType
            // 
            this.CuisineType.Text = "Cuisine Type";
            this.CuisineType.Width = 120;
            // 
            // Location
            // 
            this.Location.Text = "Location";
            this.Location.Width = 120;
            // 
            // PriceRange
            // 
            this.PriceRange.Text = "Price Range";
            this.PriceRange.Width = 120;
            // 
            // RestaurantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 498);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RestaurantsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Culinary Recommendations";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listViewRestaurants;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRequestSuggestion;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader CuisineType;
        private System.Windows.Forms.ColumnHeader Location;
        private System.Windows.Forms.ColumnHeader PriceRange;
        private System.Windows.Forms.Button btnSaveRestaurant;
    }
}