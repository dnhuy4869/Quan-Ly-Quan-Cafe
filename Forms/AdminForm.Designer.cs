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
			this.panel6 = new System.Windows.Forms.Panel();
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.btnMin = new System.Windows.Forms.Button();
			this.btnMax = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.btnApendix = new System.Windows.Forms.Button();
			this.btnGun = new System.Windows.Forms.Button();
			this.btnBullet = new System.Windows.Forms.Button();
			this.btnMed = new System.Windows.Forms.Button();
			this.btnScope = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
			this.dtpkFormDate = new System.Windows.Forms.DateTimePicker();
			this.btnInventory = new System.Windows.Forms.Button();
			this.dtgvBill = new System.Windows.Forms.DataGridView();
			this.pnlTitle.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
			this.SuspendLayout();
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.DarkGray;
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.ForeColor = System.Drawing.Color.White;
			this.panel6.Location = new System.Drawing.Point(0, 25);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(747, 1);
			this.panel6.TabIndex = 11;
			// 
			// pnlTitle
			// 
			this.pnlTitle.Controls.Add(this.btnMin);
			this.pnlTitle.Controls.Add(this.btnMax);
			this.pnlTitle.Controls.Add(this.btnClose);
			this.pnlTitle.Controls.Add(this.label6);
			this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(747, 25);
			this.pnlTitle.TabIndex = 10;
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
			this.btnMin.Location = new System.Drawing.Point(630, 0);
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
			this.btnMax.Location = new System.Drawing.Point(669, 0);
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
			this.btnClose.Location = new System.Drawing.Point(708, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(39, 25);
			this.btnClose.TabIndex = 1;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 4);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "ACCOUNT";
			// 
			// btnApendix
			// 
			this.btnApendix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnApendix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnApendix.FlatAppearance.BorderSize = 0;
			this.btnApendix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnApendix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnApendix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnApendix.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnApendix.ForeColor = System.Drawing.Color.White;
			this.btnApendix.Location = new System.Drawing.Point(143, 42);
			this.btnApendix.Name = "btnApendix";
			this.btnApendix.Size = new System.Drawing.Size(114, 30);
			this.btnApendix.TabIndex = 34;
			this.btnApendix.Text = "Category";
			this.btnApendix.UseVisualStyleBackColor = false;
			this.btnApendix.Click += new System.EventHandler(this.btnApendix_Click);
			// 
			// btnGun
			// 
			this.btnGun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnGun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnGun.FlatAppearance.BorderSize = 0;
			this.btnGun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnGun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnGun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGun.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGun.ForeColor = System.Drawing.Color.White;
			this.btnGun.Location = new System.Drawing.Point(26, 42);
			this.btnGun.Name = "btnGun";
			this.btnGun.Size = new System.Drawing.Size(114, 30);
			this.btnGun.TabIndex = 33;
			this.btnGun.Text = "Revenue";
			this.btnGun.UseVisualStyleBackColor = false;
			this.btnGun.Click += new System.EventHandler(this.btnGun_Click);
			// 
			// btnBullet
			// 
			this.btnBullet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnBullet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnBullet.FlatAppearance.BorderSize = 0;
			this.btnBullet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnBullet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnBullet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBullet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBullet.ForeColor = System.Drawing.Color.White;
			this.btnBullet.Location = new System.Drawing.Point(260, 42);
			this.btnBullet.Name = "btnBullet";
			this.btnBullet.Size = new System.Drawing.Size(114, 30);
			this.btnBullet.TabIndex = 37;
			this.btnBullet.Text = "Food";
			this.btnBullet.UseVisualStyleBackColor = false;
			this.btnBullet.Click += new System.EventHandler(this.btnBullet_Click);
			// 
			// btnMed
			// 
			this.btnMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnMed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnMed.FlatAppearance.BorderSize = 0;
			this.btnMed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnMed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMed.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMed.ForeColor = System.Drawing.Color.White;
			this.btnMed.Location = new System.Drawing.Point(377, 42);
			this.btnMed.Name = "btnMed";
			this.btnMed.Size = new System.Drawing.Size(114, 30);
			this.btnMed.TabIndex = 36;
			this.btnMed.Text = "Bill";
			this.btnMed.UseVisualStyleBackColor = false;
			this.btnMed.Click += new System.EventHandler(this.btnMed_Click);
			// 
			// btnScope
			// 
			this.btnScope.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnScope.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnScope.FlatAppearance.BorderSize = 0;
			this.btnScope.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnScope.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnScope.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnScope.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnScope.ForeColor = System.Drawing.Color.White;
			this.btnScope.Location = new System.Drawing.Point(494, 42);
			this.btnScope.Name = "btnScope";
			this.btnScope.Size = new System.Drawing.Size(114, 30);
			this.btnScope.TabIndex = 35;
			this.btnScope.Text = "Account";
			this.btnScope.UseVisualStyleBackColor = false;
			this.btnScope.Click += new System.EventHandler(this.btnScope_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dtgvBill);
			this.panel1.Controls.Add(this.btnInventory);
			this.panel1.Controls.Add(this.dtpkFormDate);
			this.panel1.Controls.Add(this.dtpkToDate);
			this.panel1.Location = new System.Drawing.Point(26, 79);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(692, 323);
			this.panel1.TabIndex = 38;
			// 
			// dtpkToDate
			// 
			this.dtpkToDate.Location = new System.Drawing.Point(15, 13);
			this.dtpkToDate.Name = "dtpkToDate";
			this.dtpkToDate.Size = new System.Drawing.Size(200, 22);
			this.dtpkToDate.TabIndex = 0;
			// 
			// dtpkFormDate
			// 
			this.dtpkFormDate.Location = new System.Drawing.Point(221, 13);
			this.dtpkFormDate.Name = "dtpkFormDate";
			this.dtpkFormDate.Size = new System.Drawing.Size(200, 22);
			this.dtpkFormDate.TabIndex = 1;
			// 
			// btnInventory
			// 
			this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnInventory.FlatAppearance.BorderSize = 0;
			this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
			this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInventory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInventory.ForeColor = System.Drawing.Color.White;
			this.btnInventory.Location = new System.Drawing.Point(468, 10);
			this.btnInventory.Name = "btnInventory";
			this.btnInventory.Size = new System.Drawing.Size(114, 30);
			this.btnInventory.TabIndex = 34;
			this.btnInventory.Text = "Inventory";
			this.btnInventory.UseVisualStyleBackColor = false;
			// 
			// dtgvBill
			// 
			this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvBill.Location = new System.Drawing.Point(3, 46);
			this.dtgvBill.Name = "dtgvBill";
			this.dtgvBill.Size = new System.Drawing.Size(686, 274);
			this.dtgvBill.TabIndex = 35;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(747, 414);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnApendix);
			this.Controls.Add(this.btnGun);
			this.Controls.Add(this.btnBullet);
			this.Controls.Add(this.btnMed);
			this.Controls.Add(this.btnScope);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.pnlTitle);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Admin";
			this.pnlTitle.ResumeLayout(false);
			this.pnlTitle.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Button btnMin;
		private System.Windows.Forms.Button btnMax;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnApendix;
		private System.Windows.Forms.Button btnGun;
		private System.Windows.Forms.Button btnBullet;
		private System.Windows.Forms.Button btnMed;
		private System.Windows.Forms.Button btnScope;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dtgvBill;
		private System.Windows.Forms.Button btnInventory;
		private System.Windows.Forms.DateTimePicker dtpkFormDate;
		private System.Windows.Forms.DateTimePicker dtpkToDate;
	}
}