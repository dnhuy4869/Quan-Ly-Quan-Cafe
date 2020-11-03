using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
	public class BillInfo
	{
		private int id;
		private int idBill;
		private int idFood;
		private int count;

		public int Id { get => id; set => id = value; }
		public int IdBill { get => idBill; set => idBill = value; }
		public int IdFood { get => idFood; set => idFood = value; }
		public int Count { get => count; set => count = value; }

		public BillInfo(int id, int idbill, int idfood, int count)
		{
			this.Id = id;
			this.IdBill = idbill;
			this.IdFood = idfood;
			this.Count = count;
		}

		public BillInfo(DataRow row)
		{
			this.Id = (int)row["Id"];
			this.IdBill = (int)row["IdBill"];
			this.IdFood = (int)row["IdFood"];
			this.Count = (int)row["Count"];
		}
	}
}
