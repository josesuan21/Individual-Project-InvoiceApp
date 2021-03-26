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
	public partial class InvoiceRecords_Form : Form
	{
		public InvoiceRecords_Form()
		{
			InitializeComponent();
		}

		private void InvoiceRecordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.invoiceRecordBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.invoiceDatabaseDataSet1);

		}

		private void InvoiceRecords_Form_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'invoiceDatabaseDataSet1.InvoiceRecord' table. You can move, or remove it, as needed.
			this.invoiceRecordTableAdapter.Fill(this.invoiceDatabaseDataSet1.InvoiceRecord);

		}

		private void Button_Back_Click(object sender, EventArgs e)
		{
			ViewUpdate_Form viewUpdate_Form = new ViewUpdate_Form();
			viewUpdate_Form.Show();
			this.Close();
		}
	}
}
