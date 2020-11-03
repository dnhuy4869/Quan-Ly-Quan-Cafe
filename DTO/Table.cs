using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
	public class Table
	{
		private int id;
		private string name;
		private string status;

		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public string Status { get => status; set => status = value; }

		public Table(int id, string name, string status)
		{
			this.Id = id;
			this.Name = name;
			this.Status = status;
		}

		public Table(DataRow row)
		{
			this.Id = (int)row["Id"];
			this.Name = row["Name"].ToString();
			this.Status = row["Status"].ToString();
		}
	}
}
