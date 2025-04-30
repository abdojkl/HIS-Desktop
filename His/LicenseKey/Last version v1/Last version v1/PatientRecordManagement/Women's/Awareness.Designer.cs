namespace PatientRecordManagement.Dialogs
{
    partial class Awareness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Awareness));
            this.AppBarAW = new Bunifu.Utils.BunifuAppBar();
            this.buttonAW2 = new System.Windows.Forms.Button();
            this.buttonAW1 = new System.Windows.Forms.Button();
            this.labelAW2 = new System.Windows.Forms.Label();
            this.bunifuDatePickerAW1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.labelAW1 = new System.Windows.Forms.Label();
            this.bunifuDropdownAW1 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.SuspendLayout();
            // 
            // AppBarAW
            // 
            this.AppBarAW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.AppBarAW.ControlBoxColor = System.Drawing.Color.WhiteSmoke;
            this.AppBarAW.ControlBoxColorActive = System.Drawing.Color.White;
            this.AppBarAW.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppBarAW.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.AppBarAW.ForeColor = System.Drawing.Color.White;
            this.AppBarAW.Icon = ((System.Drawing.Image)(resources.GetObject("AppBarAW.Icon")));
            this.AppBarAW.Location = new System.Drawing.Point(0, 0);
            this.AppBarAW.Name = "AppBarAW";
            this.AppBarAW.Size = new System.Drawing.Size(601, 42);
            this.AppBarAW.TabIndex = 12;
            this.AppBarAW.Title = "Awarness";
            this.AppBarAW.TitleMargin = new System.Windows.Forms.Padding(47, 12, 0, 0);
            // 
            // buttonAW2
            // 
            this.buttonAW2.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.buttonAW2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAW2.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAW2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.buttonAW2.FlatAppearance.BorderSize = 2;
            this.buttonAW2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAW2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAW2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.buttonAW2.Location = new System.Drawing.Point(394, 168);
            this.buttonAW2.Name = "buttonAW2";
            this.buttonAW2.Size = new System.Drawing.Size(78, 40);
            this.buttonAW2.TabIndex = 211;
            this.buttonAW2.Text = "إلغاء";
            this.buttonAW2.UseVisualStyleBackColor = false;
            // 
            // buttonAW1
            // 
            this.buttonAW1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAW1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.buttonAW1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.buttonAW1.FlatAppearance.BorderSize = 2;
            this.buttonAW1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAW1.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAW1.ForeColor = System.Drawing.Color.White;
            this.buttonAW1.Location = new System.Drawing.Point(487, 168);
            this.buttonAW1.Name = "buttonAW1";
            this.buttonAW1.Size = new System.Drawing.Size(77, 40);
            this.buttonAW1.TabIndex = 210;
            this.buttonAW1.Text = "حفظ";
            this.buttonAW1.UseVisualStyleBackColor = false;
            // 
            // labelAW2
            // 
            this.labelAW2.AutoSize = true;
            this.labelAW2.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAW2.Location = new System.Drawing.Point(500, 120);
            this.labelAW2.Name = "labelAW2";
            this.labelAW2.Size = new System.Drawing.Size(69, 23);
            this.labelAW2.TabIndex = 209;
            this.labelAW2.Text = "تاريخ الزيارة";
            // 
            // bunifuDatePickerAW1
            // 
            this.bunifuDatePickerAW1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatePickerAW1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDatePickerAW1.BorderRadius = 1;
            this.bunifuDatePickerAW1.Color = System.Drawing.Color.Silver;
            this.bunifuDatePickerAW1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePickerAW1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePickerAW1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePickerAW1.DisplayWeekNumbers = false;
            this.bunifuDatePickerAW1.DPHeight = 0;
            this.bunifuDatePickerAW1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePickerAW1.FillDatePicker = false;
            this.bunifuDatePickerAW1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuDatePickerAW1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePickerAW1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePickerAW1.Icon")));
            this.bunifuDatePickerAW1.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePickerAW1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePickerAW1.LeftTextMargin = 5;
            this.bunifuDatePickerAW1.Location = new System.Drawing.Point(67, 120);
            this.bunifuDatePickerAW1.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePickerAW1.Name = "bunifuDatePickerAW1";
            this.bunifuDatePickerAW1.Size = new System.Drawing.Size(382, 32);
            this.bunifuDatePickerAW1.TabIndex = 208;
            // 
            // labelAW1
            // 
            this.labelAW1.AutoSize = true;
            this.labelAW1.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAW1.Location = new System.Drawing.Point(496, 64);
            this.labelAW1.Name = "labelAW1";
            this.labelAW1.Size = new System.Drawing.Size(73, 23);
            this.labelAW1.TabIndex = 207;
            this.labelAW1.Text = "نوع التدريب";
            // 
            // bunifuDropdownAW1
            // 
            this.bunifuDropdownAW1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownAW1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuDropdownAW1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDropdownAW1.BorderRadius = 1;
            this.bunifuDropdownAW1.Color = System.Drawing.Color.Silver;
            this.bunifuDropdownAW1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdownAW1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdownAW1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuDropdownAW1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdownAW1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bunifuDropdownAW1.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdownAW1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdownAW1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.bunifuDropdownAW1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdownAW1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdownAW1.FillDropDown = true;
            this.bunifuDropdownAW1.FillIndicator = false;
            this.bunifuDropdownAW1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdownAW1.Font = new System.Drawing.Font("JF Flat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdownAW1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdownAW1.FormattingEnabled = true;
            this.bunifuDropdownAW1.Icon = null;
            this.bunifuDropdownAW1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdownAW1.IndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdownAW1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdownAW1.IndicatorThickness = 2;
            this.bunifuDropdownAW1.IsDropdownOpened = false;
            this.bunifuDropdownAW1.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdownAW1.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdownAW1.ItemForeColor = System.Drawing.Color.Black;
            this.bunifuDropdownAW1.ItemHeight = 26;
            this.bunifuDropdownAW1.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.bunifuDropdownAW1.ItemHighLightForeColor = System.Drawing.Color.White;
            this.bunifuDropdownAW1.Items.AddRange(new object[] {
            "توعية صحة إنجابية",
            "توعية صحة عامة",
            "توعية صحة رضيع وطفل",
            "توعية تغذية",
            "توعية نظافة"});
            this.bunifuDropdownAW1.ItemTopMargin = 3;
            this.bunifuDropdownAW1.Location = new System.Drawing.Point(67, 62);
            this.bunifuDropdownAW1.Name = "bunifuDropdownAW1";
            this.bunifuDropdownAW1.Size = new System.Drawing.Size(382, 32);
            this.bunifuDropdownAW1.TabIndex = 206;
            this.bunifuDropdownAW1.Text = null;
            this.bunifuDropdownAW1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdownAW1.TextLeftMargin = 5;
            // 
            // Awareness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 242);
            this.Controls.Add(this.buttonAW2);
            this.Controls.Add(this.buttonAW1);
            this.Controls.Add(this.labelAW2);
            this.Controls.Add(this.bunifuDatePickerAW1);
            this.Controls.Add(this.labelAW1);
            this.Controls.Add(this.bunifuDropdownAW1);
            this.Controls.Add(this.AppBarAW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Awareness";
            this.Text = "Awareness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Utils.BunifuAppBar AppBarAW;
        public System.Windows.Forms.Button buttonAW2;
        public System.Windows.Forms.Button buttonAW1;
        private System.Windows.Forms.Label labelAW2;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePickerAW1;
        private System.Windows.Forms.Label labelAW1;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdownAW1;
    }
}