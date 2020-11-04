using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Forms
{
	public partial class NotifyFormOk : Form
	{
		public NotifyFormOk()
		{
			InitializeComponent();
			this.ShowInTaskbar = false;
			this.Paint += DrawBorder;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void DrawBorder(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(new Pen(Color.Blue, 2f), this.DisplayRectangle);
		}
	}
}
