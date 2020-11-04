using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe
{
	public partial class AdminForm : Form
	{
		Button currentButton;
		public AdminForm()
		{
			InitializeComponent();
			this.ControlBox = false;
			this.Text = String.Empty;
			panel1.Visible = false;
			this.btnClose.Paint += DrawCloseButton;
			this.btnMax.Paint += DrawMaxButton;
			this.btnMin.Paint += DrawMinButton;
			ActivateButton(btnGun);
			panel1.Visible = true;
			LoadDateTimePicker();
			LoadListBill(dtpkFormDate.Value, dtpkToDate.Value);
		}

		private void btnViewBill_Click(object sender, EventArgs e)
		{
			LoadListBill(dtpkFormDate.Value, dtpkToDate.Value);
		}

		private void LoadListBill(DateTime datecheckin, DateTime datecheckout)
		{
			dtgvBill.DataSource = BillDAO.GetListBillByDate(datecheckin, datecheckout);
		}

		private void LoadDateTimePicker()
		{
			DateTime today = DateTime.Now;
			dtpkFormDate.Value = new DateTime(today.Year, today.Month, 1);
			dtpkToDate.Value = dtpkFormDate.Value.AddMonths(1).AddDays(-1);
		}

		private void DrawCloseButton(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			e.Graphics.DrawLine(new Pen(Color.Black, 0.5f), 15, 8, 24, 17);
			e.Graphics.DrawLine(new Pen(Color.Black, 0.5f), 15, 17, 24, 8);
		}

		private void DrawMaxButton(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			e.Graphics.DrawLine(new Pen(Color.Black, 1f), 15, 8, 24, 8);
			e.Graphics.DrawLine(new Pen(Color.Black, 1f), 15, 8, 15, 17);
			e.Graphics.DrawLine(new Pen(Color.Black, 1f), 24, 8, 24, 17);
			e.Graphics.DrawLine(new Pen(Color.Black, 1f), 15, 17, 24, 17);
		}

		private void DrawMinButton(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			e.Graphics.DrawLine(new Pen(Color.Black, 1f), 14, 13, 25, 13);
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void ActivateButton(object senderBtn)
		{
			if (senderBtn != null)
			{
				DisableButton();
				currentButton = (Button)senderBtn;
				currentButton.BackColor = Color.FromArgb(108, 123, 139);
			}
		}

		private void DisableButton()
		{
			if (currentButton != null)
			{
				currentButton.BackColor = Color.FromArgb(31, 30, 68);
			}
		}

		private void btnGun_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			panel1.Visible = true;
		}

		private void btnApendix_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			panel1.Visible = false;
		}

		private void btnBullet_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			panel1.Visible = false;
		}

		private void btnMed_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			panel1.Visible = false;
		}

		private void btnScope_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			panel1.Visible = false;
		}

		private void btnMin_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
