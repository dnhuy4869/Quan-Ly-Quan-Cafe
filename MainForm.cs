using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using static System.Windows.Forms.ListViewItem;
using Menu = QuanLyQuanCafe.DTO.Menu;
using System.Globalization;

namespace QuanLyQuanCafe
{
	public partial class MainForm : Form
	{
		AdminForm adminForm = new AdminForm();
		CultureInfo cultureInfo = new CultureInfo("vi-VN");

		private Account account;

		public Account Account { get => account; set => account = value; }

		public MainForm(Account account)
		{
			InitializeComponent();
			LoadTable();
			LoadCategory();
			LoadCbTable(cbSwitchTable);
			this.Account = account;
		}

		private void thongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (AccountForm accountForm = new AccountForm(Account))
			{
				accountForm.ShowDialog();
			}
		}

		private void adminToolStripMenuItem_Click(object sender, EventArgs e)
		{
			adminForm.ShowDialog();
		}

		private void LoadTable()
		{
			pnlTable.Controls.Clear();
			List<Table> listTable = TableDAO.LoadTable();
			foreach(Table item in listTable)
			{
				Button btn = new Button() { Width = 100, Height = 100 };
				btn.Click += Btn_Click;
				btn.Tag = item;
				btn.Text = item.Name + "\n" + item.Status;
				switch(item.Status)
				{
					case "Empty":
						btn.BackColor = Color.Aqua;
						break;
					case "Using":
						btn.BackColor = Color.Red;
						break;
					default:
						btn.BackColor = Color.Aqua;
						break;
				}
				pnlTable.Controls.Add(btn);
			}
		}

		private void Btn_Click(object sender, EventArgs e)
		{
			int idTable = ((sender as Button).Tag as Table).Id;
			lvBill.Tag = (sender as Button).Tag;
			ShowBill(idTable);
		}

		private void ShowBill(int id)
		{
			lvBill.Items.Clear();
			List<Menu> listMenu = MenuDAO.GetListMenuByTable(id);
			float totalPrice = 0;
			foreach (Menu item in listMenu)
			{
				ListViewItem lvItem = new ListViewItem(item.FoodName.ToString());
				lvItem.SubItems.Add(item.Count.ToString());
				lvItem.SubItems.Add(item.Price.ToString());
				lvItem.SubItems.Add(item.TotalPrice.ToString());
				totalPrice += item.TotalPrice;
				lvBill.Items.Add(lvItem);
			}
			txbCalc.Text = totalPrice.ToString("c", cultureInfo);
		}

		private void LoadCategory()
		{
			List<Category> listCategory = CategoryDAO.LoadListCategory();
			cbCategory.DataSource = listCategory;
			cbCategory.DisplayMember = "Name";
		}

		private void LoadFood(int id)
		{
			List<Food> listFood = FoodDAO.GetListFoodByIdCategory(id);
			cbFood.DataSource = listFood;
			cbFood.DisplayMember = "Name";
		}

		private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			int id = 0;
			ComboBox cb = sender as ComboBox;
			if(cb.SelectedItem != null)
			{
				id = (cb.SelectedItem as Category).Id;
			}
			LoadFood(id);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Table table = lvBill.Tag as Table;
			int idBill = BillDAO.GetUncheckIdBillByIdTable(table.Id);
			int idFood = (cbFood.SelectedItem as Food).Id;
			int count = (int)nudFoodCount.Value;
			if(idBill == -1)
			{
				BillDAO.InsertBill(table.Id);
				BillInfoDAO.InsertBillInfo(BillDAO.GetMaxIdBill(), idFood, count);
			}
			else
			{
				BillInfoDAO.InsertBillInfo(idBill, idFood, count);
			}

			ShowBill(table.Id);
			LoadTable();
		}

		private void btnCheckout_Click(object sender, EventArgs e)
		{
			Table table = lvBill.Tag as Table;
			int idBill = BillDAO.GetUncheckIdBillByIdTable(table.Id);
			int discount = (int)nudDiscount.Value;
			double totalPrice = Convert.ToDouble(txbCalc.Text.Split(',')[0].Replace(".", ""));
			double finalTotalPrice = totalPrice - (totalPrice / 100) * discount; 
			if (idBill != -1)
			{
				if (MessageBox.Show("Confirm check out for " + table.Name + " with " + finalTotalPrice.ToString(), "Warning", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
				{
					BillDAO.CheckOut(idBill, discount, (float)finalTotalPrice);
					ShowBill(table.Id);
				}
				LoadTable();
			}
		}

		private void LoadCbTable(ComboBox cb)
		{
			cb.DataSource = TableDAO.LoadTable();
			cb.DisplayMember = "Name";
		}

		private void btnSwitch_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Switch table " + (lvBill.Tag as Table).Name.ToString() + " to " + (cbSwitchTable.SelectedItem as Table).Name.ToString(), "Warning", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				int id1 = (lvBill.Tag as Table).Id;
				int id2 = (cbSwitchTable.SelectedItem as Table).Id;
				TableDAO.SwitchTable(id1, id2);
				LoadTable();
			}
		}
	}
}
