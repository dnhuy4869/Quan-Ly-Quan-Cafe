using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
	public class Food
	{
		private int id;
		private string name;
		private int idCategory;
		private float price;

		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public int IdCategory { get => idCategory; set => idCategory = value; }
		public float Price { get => price; set => price = value; }

		public Food(int id, string name, int idcategory, float price)
		{
			this.Id = id;
			this.Name = name;
			this.IdCategory = idcategory;
			this.Price = price;
		}

		public Food(DataRow row)
		{
			this.Id = (int)row["Id"];
			this.Name = row["Name"].ToString();
			this.IdCategory = (int)row["IdCategory"];
			this.Price = (float)Convert.ToDouble(row["Price"]);
		}
	}
}
