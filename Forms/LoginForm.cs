using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System.Runtime.InteropServices;
using QuanLyQuanCafe.Forms;

namespace QuanLyQuanCafe
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
			this.ControlBox = false;
			this.Text = String.Empty;
			this.btnClose.Paint += DrawCloseButton;
			this.btnMax.Paint += DrawMaxButton;
			this.btnMin.Paint += DrawMinButton;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string userName = txbUserName.Text;
			string password = txbPassword.Text;
			if (userName != "" && password != "")
			{
				Account account = AccountDAO.GetAccountByUserName(userName);
				if (Login(userName, password) == true)
				{
					this.Hide();
					using (MainForm mainForm = new MainForm(account))
					{
						if (account.Type == 1)
						{
							mainForm.btnAdmin.Enabled = true;
						}
						mainForm.ShowDialog();
					}
				}
				else
				{
					NotifyFormOk notifyForm = new NotifyFormOk();
					notifyForm.lb.Text = "Login failed. Please make sure that you type correctly password.";
					notifyForm.ShowDialog();
				}
			}
			else
			{
				NotifyFormOk notifyForm = new NotifyFormOk();
				notifyForm.lb.Text = "Login failed. Please make sure that you type correctly password.";
				notifyForm.ShowDialog();
			}
		}

		private bool Login(string username, string password)
		{
			return AccountDAO.Login(username, password);
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

		private void btnMin_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
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
	}
}
