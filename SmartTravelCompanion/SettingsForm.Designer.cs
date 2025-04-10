namespace SmartTravelCompanion
{
    partial class SettingsForm
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
            this.chkNotificationEnabled = new System.Windows.Forms.CheckBox();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.txtDestinations = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbDiemden = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lbDiemden);
            this.panel1.Controls.Add(this.lbGia);
            this.panel1.Controls.Add(this.txtDestinations);
            this.panel1.Controls.Add(this.txtMaxPrice);
            this.panel1.Controls.Add(this.chkNotificationEnabled);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 450);
            this.panel1.TabIndex = 0;
            // 
            // chkNotificationEnabled
            // 
            this.chkNotificationEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotificationEnabled.Location = new System.Drawing.Point(196, 95);
            this.chkNotificationEnabled.Name = "chkNotificationEnabled";
            this.chkNotificationEnabled.Size = new System.Drawing.Size(606, 105);
            this.chkNotificationEnabled.TabIndex = 0;
            this.chkNotificationEnabled.Text = "Bật thông báo";
            this.chkNotificationEnabled.UseVisualStyleBackColor = true;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxPrice.Location = new System.Drawing.Point(196, 206);
            this.txtMaxPrice.Multiline = true;
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(606, 40);
            this.txtMaxPrice.TabIndex = 1;
            // 
            // txtDestinations
            // 
            this.txtDestinations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinations.Location = new System.Drawing.Point(196, 293);
            this.txtDestinations.Multiline = true;
            this.txtDestinations.Name = "txtDestinations";
            this.txtDestinations.Size = new System.Drawing.Size(606, 40);
            this.txtDestinations.TabIndex = 2;
            // 
            // lbGia
            // 
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(100, 219);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(89, 27);
            this.lbGia.TabIndex = 2;
            this.lbGia.Text = "Giá cả:";
            // 
            // lbDiemden
            // 
            this.lbDiemden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemden.Location = new System.Drawing.Point(13, 307);
            this.lbDiemden.Name = "lbDiemden";
            this.lbDiemden.Size = new System.Drawing.Size(176, 26);
            this.lbDiemden.TabIndex = 2;
            this.lbDiemden.Text = "Chốn dừng chân:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(396, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 80);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification settings form";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDestinations;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.CheckBox chkNotificationEnabled;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbDiemden;
        private System.Windows.Forms.Label lbGia;
    }
}

