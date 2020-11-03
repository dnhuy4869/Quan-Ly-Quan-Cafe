using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
	public static class MenuDAO
	{
		public static List<Menu> GetListMenuByTable(int id)
		{
			List<Menu> listMenu = new List<Menu>();
			DataTable data = DataProvider.ExecuteQuery("SELECT f.Name, bi.Count, f.Price, f.Price * bi.Count AS TotalPrice  FROM dbo.Bill AS b, dbo.BillInfo AS bi, dbo.Food AS f WHERE bi.IdBill = b.Id AND bi.IdFood = f.Id AND b.IdTable =" + id + "AND b.Status = 0");
			foreach(DataRow item in data.Rows)
			{
				Menu menu = new Menu(item);
				listMenu.Add(menu);
			}

			return listMenu;
		}
	}
}
