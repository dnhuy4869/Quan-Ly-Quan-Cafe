using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyQuanCafe
{
	public static class DataProvider
	{
		private static string connectionStr = "Data Source=LAPTOP-A3PLJ4DF;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";

		public static DataTable ExecuteQuery(string query, object[] parameters = null)
		{
			DataTable dataTable = new DataTable();

			using (SqlConnection connection = new SqlConnection(connectionStr))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(query, connection);
				if (parameters != null)
				{
					string[] listparameters = query.Split(' ');
					int i = 0;
					foreach (string item in listparameters)
					{
						if (item.Contains('@'))
						{
							command.Parameters.AddWithValue(item, parameters[i]);
							i++;
						}
					}
				}
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				adapter.Fill(dataTable);
				connection.Close();
			}	

			return dataTable;
		}

		public static int ExecuteNonQuery(string query, object[] parameters = null)
		{
			int data = 0;

			using (SqlConnection connection = new SqlConnection(connectionStr))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(query, connection);
				if (parameters != null)
				{
					string[] listparameters = query.Split(' ');
					int i = 0;
					foreach (string item in listparameters)
					{
						if (item.Contains('@'))
						{
							command.Parameters.AddWithValue(item, parameters[i]);
							i++;
						}
					}
				}
				data = command.ExecuteNonQuery();
				connection.Close();
			}

			return data;
		}

		public static object ExecuteScalar(string query, object[] parameters = null)
		{
			object data = 0;

			using (SqlConnection connection = new SqlConnection(connectionStr))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(query, connection);
				if (parameters != null)
				{
					string[] listparameters = query.Split(' ');
					int i = 0;
					foreach (string item in listparameters)
					{
						if (item.Contains('@'))
						{
							command.Parameters.AddWithValue(item, parameters[i]);
							i++;
						}
					}
				}
				data = command.ExecuteScalar();
				connection.Close();
			}

			return data;
		}
	}
}
