using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
	public static class TableDAO
	{
		public static List<Table> LoadTable()
		{
			List<Table> listTable = new List<Table>();
			DataTable data = DataProvider.ExecuteQuery("EXEC dbo.sp_GetListTable");
			foreach (DataRow item in data.Rows)
			{
				Table table = new Table(item);
				listTable.Add(table);
			}

			return listTable;
		}

		public static void SwitchTable(int id1, int id2)
		{
			DataProvider.ExecuteNonQuery("EXEC dbo.sp_SwitchTable @IdTable1 , @IdTable2 ", new object[] { id1, id2 });  
		}
	}
}
