using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Invoice_Application_Project.Views;
using Invoice_Application_Project.Presenters;

namespace Invoice_Application_Project
{
	public partial class CreateService : Form, IService
	{
		public CreateService()
		{
			InitializeComponent();
			numericUpDown_Price.Value = 0.00m;
			numericUpDown_Price.Maximum = 10000000.00m; 
			numericUpDown_Price.Minimum = 0.00m;
		}

		public int ServiceId_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string ServiceName_Text { get { return textBox_Name.Text; } set { textBox_Name.Text = value; } }
		public decimal ServicePrice_Text { get { return numericUpDown_Price.Value; } set { numericUpDown_Price.Value = value; } }

		private void Button_CreateServiceAdd_Click(object sender, EventArgs e)
		{
			//Ticket 20.2
			if (ServiceName_Text != "") {
				Invoice_Form invoice_Form = new Invoice_Form();
				invoice_Form.GetNewService(ServiceName_Text, ServicePrice_Text);
				this.Hide();

				//Save databaseTicket 20.3
				if (checkBox_SaveService.Checked)
				{
					ServicePresenter service = new ServicePresenter(this);
					service.SaveNew_Service(ServiceName_Text,ServicePrice_Text);
				}

			}
			else
			{
				MessageBox.Show("Please provide a name");
			}

			

		}
	}
}
