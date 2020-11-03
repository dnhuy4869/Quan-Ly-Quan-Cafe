namespace QuanLyQuanCafe
{
	partial class AdminForm
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
			this.tcBill = new System.Windows.Forms.TabControl();
			this.tpDoanhThu = new System.Windows.Forms.TabPage();
			this.btnViewBill = new System.Windows.Forms.Button();
			this.dtpkToDay = new System.Windows.Forms.DateTimePicker();
			this.dtpkFormDate = new System.Windows.Forms.DateTimePicker();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtgvBill = new System.Windows.Forms.DataGridView();
			this.tpFood = new System.Windows.Forms.TabPage();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.txbGia = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txbDanhMuc = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txbTenMon = new System.Windows.Forms.TextBox();
			this.txbID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txbName = new System.Windows.Forms.TextBox();
			this.btnSearchFood = new System.Windows.Forms.Button();
			this.btnView = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dtgvFood = new System.Windows.Forms.DataGridView();
			this.tpCategory = new System.Windows.Forms.TabPage();
			this.tpTable = new System.Windows.Forms.TabPage();
			this.tpAccount = new System.Windows.Forms.TabPage();
			this.tcBill.SuspendLayout();
			this.tpDoanhThu.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
			this.tpFood.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
			this.SuspendLayout();
			// 
			// tcBill
			// 
			this.tcBill.Controls.Add(this.tpDoanhThu);
			this.tcBill.Controls.Add(this.tpFood);
			this.tcBill.Controls.Add(this.tpCategory);
			this.tcBill.Controls.Add(this.tpTable);
			this.tcBill.Controls.Add(this.tpAccount);
			this.tcBill.Location = new System.Drawing.Point(12, 12);
			this.tcBill.Name = "tcBill";
			this.tcBill.SelectedIndex = 0;
			this.tcBill.Size = new System.Drawing.Size(723, 390);
			this.tcBill.TabIndex = 0;
			// 
			// tpDoanhThu
			// 
			this.tpDoanhThu.Controls.Add(this.btnViewBill);
			this.tpDoanhThu.Controls.Add(this.dtpkToDay);
			this.tpDoanhThu.Controls.Add(this.dtpkFormDate);
			this.tpDoanhThu.Controls.Add(this.panel1);
			this.tpDoanhThu.Location = new System.Drawing.Point(4, 22);
			this.tpDoanhThu.Name = "tpDoanhThu";
			this.tpDoanhThu.Padding = new System.Windows.Forms.Padding(3);
			this.tpDoanhThu.Size = new System.Drawing.Size(715, 364);
			this.tpDoanhThu.TabIndex = 0;
			this.tpDoanhThu.Text = "Revenue";
			this.tpDoanhThu.UseVisualStyleBackColor = true;
			// 
			// btnViewBill
			// 
			this.btnViewBill.Location = new System.Drawing.Point(452, 3);
			this.btnViewBill.Name = "btnViewBill";
			this.btnViewBill.Size = new System.Drawing.Size(75, 23);
			this.btnViewBill.TabIndex = 3;
			this.btnViewBill.Text = "Inventory";
			this.btnViewBill.UseVisualStyleBackColor = true;
			this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
			// 
			// dtpkToDay
			// 
			this.dtpkToDay.Location = new System.Drawing.Point(229, 3);
			this.dtpkToDay.Name = "dtpkToDay";
			this.dtpkToDay.Size = new System.Drawing.Size(200, 20);
			this.dtpkToDay.TabIndex = 2;
			// 
			// dtpkFormDate
			// 
			this.dtpkFormDate.Location = new System.Drawing.Point(6, 3);
			this.dtpkFormDate.Name = "dtpkFormDate";
			this.dtpkFormDate.Size = new System.Drawing.Size(200, 20);
			this.dtpkFormDate.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dtgvBill);
			this.panel1.Location = new System.Drawing.Point(6, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(703, 326);
			this.panel1.TabIndex = 0;
			// 
			// dtgvBill
			// 
			this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgvBill.Location = new System.Drawing.Point(0, 0);
			this.dtgvBill.Name = "dtgvBill";
			this.dtgvBill.Size = new System.Drawing.Size(703, 326);
			this.dtgvBill.TabIndex = 0;
			// 
			// tpFood
			// 
			this.tpFood.Controls.Add(this.panel3);
			this.tpFood.Controls.Add(this.txbName);
			this.tpFood.Controls.Add(this.btnSearchFood);
			this.tpFood.Controls.Add(this.btnView);
			this.tpFood.Controls.Add(this.btnEdit);
			this.tpFood.Controls.Add(this.btnDelete);
			this.tpFood.Controls.Add(this.btnAdd);
			this.tpFood.Controls.Add(this.panel2);
			this.tpFood.Location = new System.Drawing.Point(4, 22);
			this.tpFood.Name = "tpFood";
			this.tpFood.Padding = new System.Windows.Forms.Padding(3);
			this.tpFood.Size = new System.Drawing.Size(715, 364);
			this.tpFood.TabIndex = 1;
			this.tpFood.Text = "Food";
			this.tpFood.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.txbGia);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.txbDanhMuc);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.txbTenMon);
			this.panel3.Controls.Add(this.txbID);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(425, 46);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(284, 312);
			this.panel3.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Price";
			// 
			// txbGia
			// 
			this.txbGia.Location = new System.Drawing.Point(101, 183);
			this.txbGia.Name = "txbGia";
			this.txbGia.Size = new System.Drawing.Size(171, 20);
			this.txbGia.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Category";
			// 
			// txbDanhMuc
			// 
			this.txbDanhMuc.Location = new System.Drawing.Point(101, 122);
			this.txbDanhMuc.Name = "txbDanhMuc";
			this.txbDanhMuc.Size = new System.Drawing.Size(171, 20);
			this.txbDanhMuc.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Name";
			// 
			// txbTenMon
			// 
			this.txbTenMon.Location = new System.Drawing.Point(101, 65);
			this.txbTenMon.Name = "txbTenMon";
			this.txbTenMon.Size = new System.Drawing.Size(171, 20);
			this.txbTenMon.TabIndex = 2;
			// 
			// txbID
			// 
			this.txbID.Location = new System.Drawing.Point(45, 12);
			this.txbID.Name = "txbID";
			this.txbID.Size = new System.Drawing.Size(227, 20);
			this.txbID.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// txbName
			// 
			this.txbName.Location = new System.Drawing.Point(425, 19);
			this.txbName.Name = "txbName";
			this.txbName.Size = new System.Drawing.Size(203, 20);
			this.txbName.TabIndex = 9;
			// 
			// btnSearchFood
			// 
			this.btnSearchFood.Location = new System.Drawing.Point(634, 17);
			this.btnSearchFood.Name = "btnSearchFood";
			this.btnSearchFood.Size = new System.Drawing.Size(75, 23);
			this.btnSearchFood.TabIndex = 8;
			this.btnSearchFood.Text = "Search";
			this.btnSearchFood.UseVisualStyleBackColor = true;
			// 
			// btnView
			// 
			this.btnView.Location = new System.Drawing.Point(249, 17);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(75, 23);
			this.btnView.TabIndex = 7;
			this.btnView.Text = "View";
			this.btnView.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(168, 17);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(87, 17);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(6, 17);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dtgvFood);
			this.panel2.Location = new System.Drawing.Point(6, 46);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(412, 312);
			this.panel2.TabIndex = 0;
			// 
			// dtgvFood
			// 
			this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvFood.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgvFood.Location = new System.Drawing.Point(0, 0);
			this.dtgvFood.Name = "dtgvFood";
			this.dtgvFood.Size = new System.Drawing.Size(412, 312);
			this.dtgvFood.TabIndex = 0;
			// 
			// tpCategory
			// 
			this.tpCategory.Location = new System.Drawing.Point(4, 22);
			this.tpCategory.Name = "tpCategory";
			this.tpCategory.Padding = new System.Windows.Forms.Padding(3);
			this.tpCategory.Size = new System.Drawing.Size(715, 364);
			this.tpCategory.TabIndex = 2;
			this.tpCategory.Text = "Category";
			this.tpCategory.UseVisualStyleBackColor = true;
			// 
			// tpTable
			// 
			this.tpTable.Location = new System.Drawing.Point(4, 22);
			this.tpTable.Name = "tpTable";
			this.tpTable.Padding = new System.Windows.Forms.Padding(3);
			this.tpTable.Size = new System.Drawing.Size(715, 364);
			this.tpTable.TabIndex = 3;
			this.tpTable.Text = "Table";
			this.tpTable.UseVisualStyleBackColor = true;
			// 
			// tpAccount
			// 
			this.tpAccount.Location = new System.Drawing.Point(4, 22);
			this.tpAccount.Name = "tpAccount";
			this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
			this.tpAccount.Size = new System.Drawing.Size(715, 364);
			this.tpAccount.TabIndex = 4;
			this.tpAccount.Text = "Account";
			this.tpAccount.UseVisualStyleBackColor = true;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 414);
			this.Controls.Add(this.tcBill);
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Admin";
			this.tcBill.ResumeLayout(false);
			this.tpDoanhThu.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
			this.tpFood.ResumeLayout(false);
			this.tpFood.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tcBill;
		private System.Windows.Forms.TabPage tpDoanhThu;
		private System.Windows.Forms.TabPage tpFood;
		private System.Windows.Forms.TabPage tpCategory;
		private System.Windows.Forms.TabPage tpTable;
		private System.Windows.Forms.TabPage tpAccount;
		private System.Windows.Forms.Button btnViewBill;
		private System.Windows.Forms.DateTimePicker dtpkToDay;
		private System.Windows.Forms.DateTimePicker dtpkFormDate;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dtgvBill;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txbGia;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txbDanhMuc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbTenMon;
		private System.Windows.Forms.TextBox txbID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txbName;
		private System.Windows.Forms.Button btnSearchFood;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dtgvFood;
	}
}