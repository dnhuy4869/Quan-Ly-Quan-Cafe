using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
	public class Account
	{
		private int id;
		private string displayName;
		private string userName;
		private string password;
		private int type;

		public int Id { get => id; set => id = value; }
		public string DisplayName { get => displayName; set => displayName = value; }
		public string UserName { get => userName; set => userName = value; }
		public string Password { get => password; set => password = value; }
		public int Type { get => type; set => type = value; }

		public Account(int id, string displayname, string username, string password, int type)
		{
			this.Id = id;
			this.UserName = username;
			this.DisplayName = displayname;
			this.Password = password;
			this.Type = type;
		}

		public Account(DataRow row)
		{
			this.Id = (int)row["Id"];
			this.UserName = row["UserName"].ToString();
			this.DisplayName = row["DisplayName"].ToString();
			this.Password = row["Password"].ToString();
			this.Type = (int)row["Type"];
		}
	}
}
