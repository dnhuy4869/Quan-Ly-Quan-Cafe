using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe
{
	public partial class AdminForm : Form
	{
		public AdminForm()
		{
			InitializeComponent();
			LoadDateTimePicker();
			LoadListBill(dtpkFormDate.Value, dtpkToDay.Value);
		}

		private void btnViewBill_Click(object sender, EventArgs e)
		{
			LoadListBill(dtpkFormDate.Value, dtpkToDay.Value);
		}

		private void LoadListBill(DateTime datecheckin, DateTime datecheckout)
		{
			dtgvBill.DataSource = BillDAO.GetListBillByDate(datecheckin, datecheckout);
		}

		private void LoadDateTimePicker()
		{
			DateTime today = DateTime.Now;
			dtpkFormDate.Value = new DateTime(today.Year, today.Month, 1);
			dtpkToDay.Value = dtpkFormDate.Value.AddMonths(1).AddDays(-1);
		}
	}
}
