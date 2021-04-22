using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace Invoice_Application_Project
{
	public partial class ServiceChosen_Form : Form
	{
		public ServiceChosen_Form()
		{
			InitializeComponent();
		}


		private void ServiceChosen_Form_Load(object sender, EventArgs e)
		{
			this.serviceChosen_InnerJoinTableAdapter.Fill(this.invoiceDatabaseDataSet1.ServiceChosen_InnerJoin);

		}

		private void Button_Next_Click(object sender, EventArgs e)
		{
			this.serviceChosen_InnerJoinBindingSource.MoveNext();
		}

		private void Button_backwithpoint_Click(object sender, EventArgs e)
		{
			this.serviceChosen_InnerJoinBindingSource.MovePrevious();
		}


		private void TextBox_search_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.serviceChosen_InnerJoinTableAdapter.FindCustomerName(this.invoiceDatabaseDataSet1.ServiceChosen_InnerJoin, textBox_search.Text);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}

		private void TextBox_search_Click(object sender, EventArgs e)
		{
			textBox_search.Text = "";
		}

		private void TextBox_search_Leave(object sender, EventArgs e)
		{
			textBox_search.Text = "🔍 Search Customer";
			this.serviceChosen_InnerJoinTableAdapter.Fill(this.invoiceDatabaseDataSet1.ServiceChosen_InnerJoin);
		}

		private void Button_Back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
