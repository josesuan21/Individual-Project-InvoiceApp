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
	public partial class ViewUpdate_Form : Form
	{
		public ViewUpdate_Form()
		{
			InitializeComponent();
		}

		private void Button_Back_Click(object sender, EventArgs e)
		{
			foreach (Form form in System.Windows.Forms.Application.OpenForms)
			{

				if (form is Form_Menu)
				{
					form.Show();
					break;
				}
			}

			this.Close();
			
		}

		private void Button_Customer_Click(object sender, EventArgs e)
		{
			CustomerRecord_Form customerRecord_Form = new CustomerRecord_Form();

			customerRecord_Form.ShowDialog();

		}

		private void Button_Services_Click(object sender, EventArgs e)
		{
			ServiceRecords_Form serviceRecords = new ServiceRecords_Form();

			serviceRecords.ShowDialog();

		}

		private void Button_Invoice_Click(object sender, EventArgs e)
		{
			InvoiceRecords_Form invoiceRecords_Form = new InvoiceRecords_Form();
			invoiceRecords_Form.ShowDialog();

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			ServiceChosen_Form serviceChosen_Form = new ServiceChosen_Form();
			serviceChosen_Form.ShowDialog();

		}

		private void ViewUpdate_Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach (Form form in System.Windows.Forms.Application.OpenForms)
			{

				if (form is Form_Menu)
				{
					form.Show();
					break;
				}
			}
		}
	}
}
