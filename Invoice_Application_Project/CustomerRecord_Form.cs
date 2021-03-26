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
	public partial class CustomerRecord_Form : Form
	{
		public CustomerRecord_Form()
		{
			InitializeComponent();
		}

		private void CustomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.customerBindingSource.EndEdit();


		}

		private void CustomerRecord_Form_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'invoiceDatabaseDataSet1.Customer' table. You can move, or remove it, as needed.
			this.customerTableAdapter.Fill(this.invoiceDatabaseDataSet1.Customer);

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			ViewUpdate_Form viewUpdate_Form = new ViewUpdate_Form();
			viewUpdate_Form.Show();
			this.Close();
		}

		private void CustomerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
		{
			this.Validate();
			this.customerBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.invoiceDatabaseDataSet1);

		}
	}
}
