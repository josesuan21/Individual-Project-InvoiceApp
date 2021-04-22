using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Invoice_Application_Project
{
	public partial class Form_Menu : Form
	{
		
		public Form_Menu()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			//Initialised form
			Invoice_Form invoice_Form = new Invoice_Form();
			//Ticket 042
			invoice_Form.ShowDialog();
		}

		private void Button_UpdateRecord_Click(object sender, EventArgs e)
		{
			ViewUpdate_Form viewUpdate = new ViewUpdate_Form();
			viewUpdate.Show();
			this.Hide();
		}

		private void Button_Statistic_Click(object sender, EventArgs e)
		{
			StatisticReport_Form report_Form = new StatisticReport_Form();
			report_Form.ShowDialog();
		}
	}
}
