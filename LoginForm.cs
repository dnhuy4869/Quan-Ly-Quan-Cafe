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

namespace QuanLyQuanCafe
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string userName = txbUserName.Text;
			string password = txbPassword.Text;
			Account account = AccountDAO.GetAccountByUserName(userName);
			if (Login(userName, password) == true)
			{
				this.Hide();
				using (MainForm mainForm = new MainForm(account))
				{
					if (account.Type == 1)
					{
						mainForm.adminToolStripMenuItem.Enabled = true;
					}
					mainForm.ShowDialog();
				}
				this.Show();
			}
			else
			{
				MessageBox.Show("Login Failed");
			}
		}

		private bool Login(string username, string password)
		{
			return AccountDAO.Login(username, password);
		}
	}
}
