using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
	public partial class AccountForm : Form
	{
		private Account account;

		public AccountForm(Account account)
		{
			InitializeComponent();
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
	}
}
