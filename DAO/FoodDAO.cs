using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
	public static class FoodDAO
	{
		public static List<Food> GetListFoodByIdCategory(int id)
		{
			List<Food> listFood = new List<Food>();
			DataTable data = DataProvider.ExecuteQuery("SELECT * FROM dbo.Food WHERE IdCategory =" + id);
			foreach (DataRow item in data.Rows)
			{
				Food food = new Food(item);
				listFood.Add(food);
			}

			return listFood;
		}
	}
}
