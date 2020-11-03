using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
	public static class CategoryDAO
	{
		public static List<Category> LoadListCategory()
		{
			List<Category> listCategory = new List<Category>();
			DataTable data = DataProvider.ExecuteQuery("SELECT * FROM dbo.FoodCategory");
			foreach (DataRow item in data.Rows)
			{
				Category category = new Category(item);
				listCategory.Add(category);
			}

			return listCategory;
		}
	}
}
