using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
	public class Bill
	{
		private int id;
		private DateTime? dateCheckIn;
		private DateTime? dateCheckOut;
		private int status;
		private int Discount;

		public int Id { get => id; set => id = value; }
		public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
		public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
		public int Status { get => status; set => status = value; }
		public int Discount1 { get => Discount; set => Discount = value; }

		public Bill(int id, DateTime? datecheckin, DateTime? datecheckout, int status, int discount = 0)
		{
			this.Id = id;
			this.DateCheckIn = datecheckin;
			this.DateCheckOut = datecheckout;
			this.Status = status;
			this.Discount = discount;
		}

		public Bill(DataRow row)
		{
			this.Id = (int)row["Id"];
			this.DateCheckIn = (DateTime?)row["DateCheckIn"];
			var temp = row["DateCheckOut"];
			if(temp.ToString() != "")
			{
				this.DateCheckOut = (DateTime?)temp;
			}
			this.Status = (int)row["Status"];
			this.Discount = (int)row["Discount"];
		}
	}
}
