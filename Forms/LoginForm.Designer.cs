namespace QuanLyQuanCafe
{
	partial class LoginForm
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
			this.txbUserName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txbPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.btnMin = new System.Windows.Forms.Button();
			this.btnMax = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlTitle.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txbUserName
			// 
			this.txbUserName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbUserName.Location = new System.Drawing.Point(133, 20);
			this.txbUserName.Name = "txbUserName";
			this.txbUserName.Size = new System.Drawing.Size(422, 22);
			this.txbUserName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			// 
			// txbPassword
			// 
			this.txbPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbPassword.Location = new System.Drawing.Point(133, 20);
			this.txbPassword.Name = "txbPassword";
			this.txbPassword.Size = new System.Drawing.Size(422, 22);
			this.txbPassword.TabIndex = 1;
			this.txbPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Password";
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.MediumBlue;
			this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(243, 204);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(211, 47);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
			this.pnlTitle.Size = new System.Drawing.Size(672, 25);
			this.pnlTitle.TabIndex = 3;
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
			this.btnMin.Location = new System.Drawing.Point(555, 0);
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
			this.btnMax.Location = new System.Drawing.Point(594, 0);
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
			this.btnClose.Location = new System.Drawing.Point(633, 0);
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
			this.label3.Size = new System.Drawing.Size(46, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "LOGIN";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.DarkGray;
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.ForeColor = System.Drawing.Color.White;
			this.panel4.Location = new System.Drawing.Point(0, 25);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(672, 1);
			this.panel4.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txbUserName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(45, 49);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(581, 56);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txbPassword);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(45, 127);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(581, 56);
			this.panel2.TabIndex = 1;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(672, 279);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.pnlTitle);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.pnlTitle.ResumeLayout(false);
			this.pnlTitle.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox txbUserName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txbPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnMin;
		private System.Windows.Forms.Button btnMax;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}

