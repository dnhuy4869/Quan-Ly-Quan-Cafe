using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
	public partial class AccountForm : Form
	{
		private Account account;

		public AccountForm(Account account)
		{
			InitializeComponent();
			this.ControlBox = false;
			this.Text = String.Empty;
			this.btnClose.Paint += DrawCloseButton;
			this.btnMax.Paint += DrawMaxButton;
			this.btnMin.Paint += DrawMinButton;
			this.Account = account;
			LoadAccountInfo();
		}

		public Account Account { get => account; set => account = value; }

		private void LoadAccountInfo()
		{
			this.txbUserName.Text = Account.UserName;
			this.txbDisplayName.Text = Account.DisplayName;
			this.txbPassword.Text = Account.Password;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (txbNewPass.Text != "")
			{
				if (txbNewPass.Text == txbRetype.Text)
				{
					DataProvider.ExecuteNonQuery("EXEC dbo.sp_UpdateAccount @displayname , @password , @username ", new object[] { txbDisplayName.Text, txbRetype.Text, txbUserName.Text });
					MessageBox.Show("Update successfully");
				}
				else
				{
					MessageBox.Show("Please enter correct password");
				}
			}
			else
			{
				DataProvider.ExecuteNonQuery("EXEC dbo.sp_UpdateAccountNoPass @displayname , @username ", new object[] { txbDisplayName.Text, txbUserName.Text });
				MessageBox.Show("Update successfully");
			}
		}

		private void DrawCloseButton(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			e.Graphics.DrawLine(new Pen(Color.Black, 0.5f), 15, 8, 24, 17);
			e.Graphics.DrawLine(new Pen(Color.Black, 0.5f), 15, 17, 24, 8);
		}

		private void DrawMaxButton(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			e.Graphics.DrawLine(new Pen(Color.Black, 1f), 15, 8, 24, 8);
			e.Graphics.DrawLine(new Pen(Color.Black, 1f), 15, 8, 15, 17);
			e.Graphics.DrawLine(new Pen(Color.Black, 1f), 24, 8, 24, 17);
			e.Graphics.DrawLine(new Pen(Color.Black, 1f), 15, 17, 24, 17);
		}

		private void DrawMinButton(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			e.Graphics.DrawLine(new Pen(Color.Black, 1f), 14, 13, 25, 13);
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMin_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
