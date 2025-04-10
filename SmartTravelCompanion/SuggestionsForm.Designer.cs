namespace SmartTravelCompanion
{
    partial class SuggestionsForm
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
            this.listViewSuggestions = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSafety = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRequestSuggestions = new System.Windows.Forms.Button();
            this.btnSaveDestination = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSuggestions
            // 
            this.listViewSuggestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDesc,
            this.colReason,
            this.colSafety});
            this.listViewSuggestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSuggestions.FullRowSelect = true;
            this.listViewSuggestions.GridLines = true;
            this.listViewSuggestions.HideSelection = false;
            this.listViewSuggestions.Location = new System.Drawing.Point(-1, 0);
            this.listViewSuggestions.Name = "listViewSuggestions";
            this.listViewSuggestions.Size = new System.Drawing.Size(969, 364);
            this.listViewSuggestions.TabIndex = 0;
            this.listViewSuggestions.UseCompatibleStateImageBehavior = false;
            this.listViewSuggestions.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewSuggestions);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 364);
            this.panel1.TabIndex = 1;
            // 
            // colName
            // 
            this.colName.Text = "Destination";
            this.colName.Width = 120;
            // 
            // colDesc
            // 
            this.colDesc.Text = "Description";
            this.colDesc.Width = 220;
            // 
            // colReason
            // 
            this.colReason.Text = "Why Unique";
            this.colReason.Width = 170;
            // 
            // colSafety
            // 
            this.colSafety.Text = "Safety Tips";
            this.colSafety.Width = 220;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaveDestination);
            this.panel2.Controls.Add(this.btnRequestSuggestions);
            this.panel2.Location = new System.Drawing.Point(1, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 82);
            this.panel2.TabIndex = 2;
            // 
            // btnRequestSuggestions
            // 
            this.btnRequestSuggestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestSuggestions.Location = new System.Drawing.Point(44, 3);
            this.btnRequestSuggestions.Name = "btnRequestSuggestions";
            this.btnRequestSuggestions.Size = new System.Drawing.Size(319, 76);
            this.btnRequestSuggestions.TabIndex = 0;
            this.btnRequestSuggestions.Text = "Request New Suggestions";
            this.btnRequestSuggestions.UseVisualStyleBackColor = true;
            this.btnRequestSuggestions.Click += new System.EventHandler(this.btnRequestSuggestions_Click);
            // 
            // btnSaveDestination
            // 
            this.btnSaveDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDestination.Location = new System.Drawing.Point(614, 3);
            this.btnSaveDestination.Name = "btnSaveDestination";
            this.btnSaveDestination.Size = new System.Drawing.Size(319, 76);
            this.btnSaveDestination.TabIndex = 0;
            this.btnSaveDestination.Text = "Save Selected";
            this.btnSaveDestination.UseVisualStyleBackColor = true;
            this.btnSaveDestination.Click += new System.EventHandler(this.btnSaveDestination_Click);
            // 
            // SuggestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 444);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SuggestionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuggestionsForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSuggestions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colDesc;
        private System.Windows.Forms.ColumnHeader colReason;
        private System.Windows.Forms.ColumnHeader colSafety;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveDestination;
        private System.Windows.Forms.Button btnRequestSuggestions;
    }
}