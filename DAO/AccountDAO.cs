using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
	public static class AccountDAO
	{
		public static bool Login(string username, string password)
		{
			string query = "EXECUTE dbo.sp_Login @username , @password";
			DataTable result = DataProvider.ExecuteQuery(query, new object[] { username, password });
			if (result.Rows.Count > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static Account GetAccountByUserName(string username)
		{
			DataTable data = DataProvider.ExecuteQuery("SELECT * FROM dbo.Account WHERE UserName = " + username);
			var temp = data.Rows[0];
			Account account = new Account(temp);
			return account;
		}
	}
}
