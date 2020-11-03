using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
	public class Menu
	{
		private string foodName;
		private int count;
		private float price;
		private float totalPrice;

		public string FoodName { get => foodName; set => foodName = value; }
		public int Count { get => count; set => count = value; }
		public float TotalPrice { get => totalPrice; set => totalPrice = value; }
		public float Price { get => price; set => price = value; }

		public Menu(string foodname, int count, float price, float totalprice)
		{
			this.FoodName = foodname;
			this.Count = count;
			this.Price = price;
			this.TotalPrice = totalprice;
		}

		public Menu(DataRow row)
		{
			this.FoodName = row["Name"].ToString();
			this.Count = (int)row["Count"];
			this.Price = (float)Convert.ToDouble(row["Price"]);
			this.TotalPrice = (float)Convert.ToDouble(row["TotalPrice"]);
		}
	}
}
