using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
	public static class BillInfoDAO
	{
		public static List<BillInfo> GetListBillInfo(int id)
		{
			List<BillInfo> listBillInfo = new List<BillInfo>();
			DataTable data = DataProvider.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE IdBill =" + id);
			foreach(DataRow item in data.Rows)
			{
				BillInfo billInfo = new BillInfo(item);
				listBillInfo.Add(billInfo);
			}

			return listBillInfo;
		}

		public static void InsertBillInfo(int idbill, int idfood, int count)
		{
			DataProvider.ExecuteNonQuery("EXEC dbo.sp_InsertBillInfo @idbill , @idfood , @count ", new object[] { idbill, idfood, count});
		}
	}
}
