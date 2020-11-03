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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thongTinTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thongTinCaNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.menuStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudFoodCount)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thongTinTaiKhoanToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(897, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.Enabled = false;
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.adminToolStripMenuItem.Text = "Admin";
			this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
			// 
			// thongTinTaiKhoanToolStripMenuItem
			// 
			this.thongTinTaiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinCaNhanToolStripMenuItem,
            this.dangXuatToolStripMenuItem});
			this.thongTinTaiKhoanToolStripMenuItem.Name = "thongTinTaiKhoanToolStripMenuItem";
			this.thongTinTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
			this.thongTinTaiKhoanToolStripMenuItem.Text = "Infomation";
			// 
			// thongTinCaNhanToolStripMenuItem
			// 
			this.thongTinCaNhanToolStripMenuItem.Name = "thongTinCaNhanToolStripMenuItem";
			this.thongTinCaNhanToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.thongTinCaNhanToolStripMenuItem.Text = "Account";
			this.thongTinCaNhanToolStripMenuItem.Click += new System.EventHandler(this.thongTinCaNhanToolStripMenuItem_Click);
			// 
			// dangXuatToolStripMenuItem
			// 
			this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
			this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.dangXuatToolStripMenuItem.Text = "Log out";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lvBill);
			this.panel2.Location = new System.Drawing.Point(570, 88);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(315, 313);
			this.panel2.TabIndex = 2;
			// 
			// lvBill
			// 
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
			this.lvBill.Size = new System.Drawing.Size(315, 313);
			this.lvBill.TabIndex = 0;
			this.lvBill.UseCompatibleStateImageBehavior = false;
			this.lvBill.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Count";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Price";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "TotalPrice";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.txbCalc);
			this.panel3.Controls.Add(this.nudDiscount);
			this.panel3.Controls.Add(this.cbSwitchTable);
			this.panel3.Controls.Add(this.btnCheckout);
			this.panel3.Controls.Add(this.btnDiscount);
			this.panel3.Controls.Add(this.btnSwitch);
			this.panel3.Location = new System.Drawing.Point(570, 407);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(315, 55);
			this.panel3.TabIndex = 3;
			// 
			// txbCalc
			// 
			this.txbCalc.Enabled = false;
			this.txbCalc.Location = new System.Drawing.Point(197, 30);
			this.txbCalc.Name = "txbCalc";
			this.txbCalc.Size = new System.Drawing.Size(115, 20);
			this.txbCalc.TabIndex = 10;
			this.txbCalc.Text = "0";
			this.txbCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nudDiscount
			// 
			this.nudDiscount.Location = new System.Drawing.Point(101, 31);
			this.nudDiscount.Name = "nudDiscount";
			this.nudDiscount.Size = new System.Drawing.Size(90, 20);
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
			this.btnCheckout.Location = new System.Drawing.Point(197, 3);
			this.btnCheckout.Name = "btnCheckout";
			this.btnCheckout.Size = new System.Drawing.Size(115, 23);
			this.btnCheckout.TabIndex = 6;
			this.btnCheckout.Text = "Check out";
			this.btnCheckout.UseVisualStyleBackColor = true;
			this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
			// 
			// btnDiscount
			// 
			this.btnDiscount.Location = new System.Drawing.Point(100, 3);
			this.btnDiscount.Name = "btnDiscount";
			this.btnDiscount.Size = new System.Drawing.Size(91, 23);
			this.btnDiscount.TabIndex = 5;
			this.btnDiscount.Text = "Discount";
			this.btnDiscount.UseVisualStyleBackColor = true;
			// 
			// btnSwitch
			// 
			this.btnSwitch.Location = new System.Drawing.Point(3, 3);
			this.btnSwitch.Name = "btnSwitch";
			this.btnSwitch.Size = new System.Drawing.Size(91, 23);
			this.btnSwitch.TabIndex = 4;
			this.btnSwitch.Text = "Switch table";
			this.btnSwitch.UseVisualStyleBackColor = true;
			this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.nudFoodCount);
			this.panel4.Controls.Add(this.btnAdd);
			this.panel4.Controls.Add(this.cbFood);
			this.panel4.Controls.Add(this.cbCategory);
			this.panel4.Location = new System.Drawing.Point(570, 27);
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
			this.nudFoodCount.Size = new System.Drawing.Size(66, 20);
			this.nudFoodCount.TabIndex = 3;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(246, 3);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(66, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
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
			this.pnlTable.Location = new System.Drawing.Point(12, 30);
			this.pnlTable.Name = "pnlTable";
			this.pnlTable.Size = new System.Drawing.Size(552, 432);
			this.pnlTable.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 474);
			this.Controls.Add(this.pnlTable);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quan Ly Quan Cafe";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudFoodCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		public System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thongTinTaiKhoanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thongTinCaNhanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
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
	}
}