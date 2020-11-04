namespace QuanLyQuanCafe
{
	partial class MainForm
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.lvBill = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel3 = new System.Windows.Forms.Panel();
			this.txbCalc = new System.Windows.Forms.TextBox();
			this.nudDiscount = new System.Windows.Forms.NumericUpDown();
			this.cbSwitchTable = new System.Windows.Forms.ComboBox();
			this.btnCheckout = new System.Windows.Forms.Button();
			this.btnDiscount = new System.Windows.Forms.Button();
			this.btnSwitch = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nudFoodCount = new System.Windows.Forms.NumericUpDown();
			this.btnAdd = new System.Windows.Forms.Button();
			this.cbFood = new System.Windows.Forms.ComboBox();
			this.cbCategory = new System.Windows.Forms.ComboBox();
			this.pnlTable = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.btnMin = new System.Windows.Forms.Button();
			this.btnMax = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pnlInfo = new System.Windows.Forms.Panel();
			this.lbAccount = new System.Windows.Forms.Label();
			this.lbLogout = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudFoodCount)).BeginInit();
			this.pnlTitle.SuspendLayout();
			this.pnlInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lvBill);
			this.panel2.Location = new System.Drawing.Point(570, 120);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(315, 310);
			this.panel2.TabIndex = 2;
			// 
			// lvBill
			// 
			this.lvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvBill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvBill.GridLines = true;
			this.lvBill.HideSelection = false;
			this.lvBill.Location = new System.Drawing.Point(0, 0);
			this.lvBill.Name = "lvBill";
			this.lvBill.Size = new System.Drawing.Size(315, 310);
			this.lvBill.TabIndex = 0;
			this.lvBill.UseCompatibleStateImageBehavior = false;
			this.lvBill.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 85;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Count";
			this.columnHeader2.Width = 58;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Price";
			this.columnHeader3.Width = 68;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "TotalPrice";
			this.columnHeader4.Width = 99;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.txbCalc);
			this.panel3.Controls.Add(this.nudDiscount);
			this.panel3.Controls.Add(this.cbSwitchTable);
			this.panel3.Controls.Add(this.btnCheckout);
			this.panel3.Controls.Add(this.btnDiscount);
			this.panel3.Controls.Add(this.btnSwitch);
			this.panel3.Location = new System.Drawing.Point(570, 436);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(315, 55);
			this.panel3.TabIndex = 3;
			// 
			// txbCalc
			// 
			this.txbCalc.Enabled = false;
			this.txbCalc.Location = new System.Drawing.Point(197, 30);
			this.txbCalc.Name = "txbCalc";
			this.txbCalc.Size = new System.Drawing.Size(115, 22);
			this.txbCalc.TabIndex = 10;
			this.txbCalc.Text = "0";
			this.txbCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nudDiscount
			// 
			this.nudDiscount.Location = new System.Drawing.Point(101, 31);
			this.nudDiscount.Name = "nudDiscount";
			this.nudDiscount.Size = new System.Drawing.Size(90, 22);
			this.nudDiscount.TabIndex = 8;
			this.nudDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cbSwitchTable
			// 
			this.cbSwitchTable.FormattingEnabled = true;
			this.cbSwitchTable.Location = new System.Drawing.Point(4, 31);
			this.cbSwitchTable.Name = "cbSwitchTable";
			this.cbSwitchTable.Size = new System.Drawing.Size(90, 21);
			this.cbSwitchTable.TabIndex = 7;
			// 
			// btnCheckout
			// 
			this.btnCheckout.BackColor = System.Drawing.Color.MediumBlue;
			this.btnCheckout.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
			this.btnCheckout.FlatAppearance.BorderSize = 0;
			this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCheckout.ForeColor = System.Drawing.Color.White;
			this.btnCheckout.Location = new System.Drawing.Point(197, 3);
			this.btnCheckout.Name = "btnCheckout";
			this.btnCheckout.Size = new System.Drawing.Size(115, 23);
			this.btnCheckout.TabIndex = 6;
			this.btnCheckout.Text = "Check out";
			this.btnCheckout.UseVisualStyleBackColor = false;
			this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
			// 
			// btnDiscount
			// 
			this.btnDiscount.BackColor = System.Drawing.Color.MediumBlue;
			this.btnDiscount.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
			this.btnDiscount.FlatAppearance.BorderSize = 0;
			this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDiscount.ForeColor = System.Drawing.Color.White;
			this.btnDiscount.Location = new System.Drawing.Point(100, 3);
			this.btnDiscount.Name = "btnDiscount";
			this.btnDiscount.Size = new System.Drawing.Size(91, 23);
			this.btnDiscount.TabIndex = 5;
			this.btnDiscount.Text = "Discount";
			this.btnDiscount.UseVisualStyleBackColor = false;
			// 
			// btnSwitch
			// 
			this.btnSwitch.BackColor = System.Drawing.Color.MediumBlue;
			this.btnSwitch.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
			this.btnSwitch.FlatAppearance.BorderSize = 0;
			this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSwitch.ForeColor = System.Drawing.Color.White;
			this.btnSwitch.Location = new System.Drawing.Point(3, 3);
			this.btnSwitch.Name = "btnSwitch";
			this.btnSwitch.Size = new System.Drawing.Size(91, 23);
			this.btnSwitch.TabIndex = 4;
			this.btnSwitch.Text = "Switch table";
			this.btnSwitch.UseVisualStyleBackColor = false;
			this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.nudFoodCount);
			this.panel4.Controls.Add(this.btnAdd);
			this.panel4.Controls.Add(this.cbFood);
			this.panel4.Controls.Add(this.cbCategory);
			this.panel4.Location = new System.Drawing.Point(570, 61);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(315, 55);
			this.panel4.TabIndex = 4;
			// 
			// nudFoodCount
			// 
			this.nudFoodCount.Location = new System.Drawing.Point(246, 30);
			this.nudFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nudFoodCount.Name = "nudFoodCount";
			this.nudFoodCount.Size = new System.Drawing.Size(66, 22);
			this.nudFoodCount.TabIndex = 3;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.MediumBlue;
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(246, 3);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(66, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// cbFood
			// 
			this.cbFood.FormattingEnabled = true;
			this.cbFood.Location = new System.Drawing.Point(3, 30);
			this.cbFood.Name = "cbFood";
			this.cbFood.Size = new System.Drawing.Size(237, 21);
			this.cbFood.TabIndex = 1;
			// 
			// cbCategory
			// 
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.Location = new System.Drawing.Point(3, 3);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(237, 21);
			this.cbCategory.TabIndex = 0;
			this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
			// 
			// pnlTable
			// 
			this.pnlTable.Location = new System.Drawing.Point(12, 61);
			this.pnlTable.Name = "pnlTable";
			this.pnlTable.Size = new System.Drawing.Size(552, 427);
			this.pnlTable.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGray;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.ForeColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(897, 1);
			this.panel1.TabIndex = 7;
			// 
			// pnlTitle
			// 
			this.pnlTitle.Controls.Add(this.btnMin);
			this.pnlTitle.Controls.Add(this.btnMax);
			this.pnlTitle.Controls.Add(this.btnClose);
			this.pnlTitle.Controls.Add(this.label3);
			this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(897, 25);
			this.pnlTitle.TabIndex = 6;
			this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
			// 
			// btnMin
			// 
			this.btnMin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnMin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnMin.FlatAppearance.BorderSize = 0;
			this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMin.Location = new System.Drawing.Point(780, 0);
			this.btnMin.Name = "btnMin";
			this.btnMin.Size = new System.Drawing.Size(39, 25);
			this.btnMin.TabIndex = 3;
			this.btnMin.UseVisualStyleBackColor = false;
			this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
			// 
			// btnMax
			// 
			this.btnMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnMax.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnMax.FlatAppearance.BorderSize = 0;
			this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMax.Location = new System.Drawing.Point(819, 0);
			this.btnMax.Name = "btnMax";
			this.btnMax.Size = new System.Drawing.Size(39, 25);
			this.btnMax.TabIndex = 2;
			this.btnMax.UseVisualStyleBackColor = false;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Location = new System.Drawing.Point(858, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(39, 25);
			this.btnClose.TabIndex = 1;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "MAIN FORM";
			// 
			// btnAdmin
			// 
			this.btnAdmin.BackColor = System.Drawing.Color.MediumBlue;
			this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
			this.btnAdmin.FlatAppearance.BorderSize = 0;
			this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdmin.ForeColor = System.Drawing.Color.White;
			this.btnAdmin.Location = new System.Drawing.Point(12, 32);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(83, 23);
			this.btnAdmin.TabIndex = 8;
			this.btnAdmin.Text = "Admin";
			this.btnAdmin.UseVisualStyleBackColor = false;
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.MediumBlue;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(101, 32);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(83, 23);
			this.button2.TabIndex = 9;
			this.button2.Text = "Infomation";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pnlInfo
			// 
			this.pnlInfo.Controls.Add(this.lbLogout);
			this.pnlInfo.Controls.Add(this.lbAccount);
			this.pnlInfo.Location = new System.Drawing.Point(101, 58);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(119, 58);
			this.pnlInfo.TabIndex = 10;
			// 
			// lbAccount
			// 
			this.lbAccount.AutoSize = true;
			this.lbAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAccount.Location = new System.Drawing.Point(3, 6);
			this.lbAccount.Name = "lbAccount";
			this.lbAccount.Size = new System.Drawing.Size(54, 17);
			this.lbAccount.TabIndex = 0;
			this.lbAccount.Text = "Account";
			this.lbAccount.Click += new System.EventHandler(this.lbAccount_Click);
			// 
			// lbLogout
			// 
			this.lbLogout.AutoSize = true;
			this.lbLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLogout.Location = new System.Drawing.Point(3, 33);
			this.lbLogout.Name = "lbLogout";
			this.lbLogout.Size = new System.Drawing.Size(53, 17);
			this.lbLogout.TabIndex = 1;
			this.lbLogout.Text = "Log out";
			this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(897, 501);
			this.Controls.Add(this.pnlInfo);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnAdmin);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlTitle);
			this.Controls.Add(this.pnlTable);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quan Ly Quan Cafe";
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudFoodCount)).EndInit();
			this.pnlTitle.ResumeLayout(false);
			this.pnlTitle.PerformLayout();
			this.pnlInfo.ResumeLayout(false);
			this.pnlInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView lvBill;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.NumericUpDown nudDiscount;
		private System.Windows.Forms.ComboBox cbSwitchTable;
		private System.Windows.Forms.Button btnCheckout;
		private System.Windows.Forms.Button btnDiscount;
		private System.Windows.Forms.Button btnSwitch;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.NumericUpDown nudFoodCount;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cbFood;
		private System.Windows.Forms.ComboBox cbCategory;
		private System.Windows.Forms.FlowLayoutPanel pnlTable;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.TextBox txbCalc;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Button btnMin;
		private System.Windows.Forms.Button btnMax;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.Button btnAdmin;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel pnlInfo;
		private System.Windows.Forms.Label lbLogout;
		private System.Windows.Forms.Label lbAccount;
	}
}