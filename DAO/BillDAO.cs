using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
	public static class BillDAO
	{
		public static int GetUncheckIdBillByIdTable(int id)
		{
			DataTable data = DataProvider.ExecuteQuery("SELECT * FROM dbo.Bill WHERE IdTable =" + id + "AND Status = 0");
			if (data.Rows.Count > 0)
			{
				Bill bill = new Bill(data.Rows[0]);
				return bill.Id;
			}
			else
			{
				return -1;
			}
		}

		public static void InsertBill(int id)
		{
			DataProvider.ExecuteNonQuery("EXEC dbo.sp_InsertBill @idtable =" + id);
		}

		public static int GetMaxIdBill()
		{
			try
			{
				return (int)DataProvider.ExecuteScalar("SELECT MAX(Id) FROM dbo.Bill");
			}
			catch
			{
				return 1;
			}
		}

		public static void CheckOut(int id, int discount, float totalprice)
		{
			DataProvider.ExecuteNonQuery("UPDATE dbo.Bill SET DateCheckOut = GETDATE(), TotalPrice =" + totalprice + ", Status = 1," + "Discount =" + discount + "WHERE Id =" + id);
		}

		public static DataTable GetListBillByDate(DateTime datecheckin, DateTime datecheckout)
		{
			return DataProvider.ExecuteQuery("EXEC dbo.sp_GetListBillByDate @datecheckin , @datecheckout ", new object[] { datecheckin, datecheckout });
		}
	}
}
