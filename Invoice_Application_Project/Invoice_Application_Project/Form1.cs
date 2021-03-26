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
		//Initialised form
		Invoice_Form invoice_Form = new Invoice_Form();
		ViewUpdate_Form viewUpdate = new ViewUpdate_Form();

		public Form_Menu()
		{
			InitializeComponent();

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			invoice_Form.Show();
		}

		private void Button_UpdateRecord_Click(object sender, EventArgs e)
		{
			viewUpdate.Show();
		}
	}
}
