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
	public partial class ServiceRecords_Form : Form
	{
		public ServiceRecords_Form()
		{
			InitializeComponent();
		}

		private void ServiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.serviceBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.invoiceDatabaseDataSet1);

		}

		private void ServiceRecords_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'invoiceDatabaseDataSet1.Service' table. You can move, or remove it, as needed.
			this.serviceTableAdapter.Fill(this.invoiceDatabaseDataSet1.Service);

		}

		private void Button_Back_Click(object sender, EventArgs e)
		{
			ViewUpdate_Form viewUpdate_Form = new ViewUpdate_Form();
			viewUpdate_Form.Show();
			this.Close();
		}
	}
}
