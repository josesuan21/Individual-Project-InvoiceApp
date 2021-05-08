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
	public partial class StatisticReport_Form : Form
	{
		public StatisticReport_Form()
		{
			InitializeComponent();
		}

		private void StatisticReport_Form_Load(object sender, EventArgs e)
		{
			//Ticket 039.1(1-4) - (Statistics) Statisc form and Graphs

			// TODO: This line of code loads data into the 'invoiceDatabaseDataSet1.LoyalCustomers' table. You can move, or remove it, as needed.
			this.loyalCustomersTableAdapter.Fill(this.invoiceDatabaseDataSet1.LoyalCustomers);
			// TODO: This line of code loads data into the 'invoiceDatabaseDataSet1.Income_CurrentYear' table. You can move, or remove it, as needed.
			this.income_CurrentYearTableAdapter.Fill(this.invoiceDatabaseDataSet1.Income_CurrentYear);
			// TODO: This line of code loads data into the 'invoiceDatabaseDataSet1.Popular_Area' table. You can move, or remove it, as needed.
			this.popular_AreaTableAdapter.Fill(this.invoiceDatabaseDataSet1.Popular_Area);
			// TODO: This line of code loads data into the 'invoiceDatabaseDataSet1.ServiceName_Total' table. You can move, or remove it, as needed.
			this.serviceName_TotalTableAdapter.Fill(this.invoiceDatabaseDataSet1.ServiceName_Total);


		}

	}
}
