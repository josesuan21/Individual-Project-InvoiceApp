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
	public partial class OldServices_Form : Form
	{
		public OldServices_Form()
		{
			InitializeComponent();
		}

		private void Old_ServiceRecordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.old_ServiceRecordBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.invoiceDatabaseDataSet1);

		}

		private void OldServices_Form_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'invoiceDatabaseDataSet1.Old_ServiceRecord' table. You can move, or remove it, as needed.
			this.old_ServiceRecordTableAdapter.Fill(this.invoiceDatabaseDataSet1.Old_ServiceRecord);

		}
	}
}
