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
			// TODO: This line of code loads data into the 'invoiceDatabaseDataSet1.ServiceChosen' table. You can move, or remove it, as needed.
			this.serviceChosenTableAdapter.Fill(this.invoiceDatabaseDataSet1.ServiceChosen);

		}

		private void Button_Next_Click(object sender, EventArgs e)
		{
			this.serviceChosenBindingSource.MoveNext();
		}

		private void Button_backwithpoint_Click(object sender, EventArgs e)
		{
			this.serviceChosenBindingSource.MovePrevious();
		}


		private void TextBox_search_TextChanged(object sender, EventArgs e)
		{
			//Once typing the name finds a matching name from database and returns value of customer's ID

			int searchCustomerId = 0;

			//SQL
			SqlConnection connection;
			string connectionString = ConfigurationManager.ConnectionStrings["Invoice_Application_Project.Properties.Settings.InvoiceDatabaseConnectionString"].ConnectionString;

			connection = new SqlConnection(connectionString);
			connection.Open();

			string sqlQuery_GetServiceName = "SELECT customerId, customerName FROM Customer;";

			SqlCommand cmd = new SqlCommand(sqlQuery_GetServiceName, connection);
			SqlDataReader read = cmd.ExecuteReader();

			//For loop each service list and find texbox
			//Reads all the records
			while (read.Read())
			{
				//If the name is the same as the textbox, assigns the customer id in searchCustomerId
				if (read.GetValue(1).ToString() == textBox_search.Text)
				{
					//get Name
					searchCustomerId = Convert.ToInt32(read.GetValue(0));
					break;
				}
			}
			//Close connection
			connection.Close();


			//Assign to the filter
			try
			{
				this.serviceChosenTableAdapter.SearchInvoiceId(this.invoiceDatabaseDataSet1.ServiceChosen, ((int)(System.Convert.ChangeType(searchCustomerId, typeof(int)))));
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			

		}

		private void ServiceIdTextBox_TextChanged(object sender, EventArgs e)
		{
			//Show the name of the service
			GetServiceName();

		}

		private void CustomerIdTextBox_TextChanged(object sender, EventArgs e)
		{
			//Show the name of the customer
			GetCustomerName();
		}


		//Show service name
		public void GetServiceName()
		{
			//SQL
			SqlConnection connection;
			string connectionString = ConfigurationManager.ConnectionStrings["Invoice_Application_Project.Properties.Settings.InvoiceDatabaseConnectionString"].ConnectionString;

			connection = new SqlConnection(connectionString);
			connection.Open();

			string sqlQuery_GetServiceName = "SELECT serviceId, serviceName, price FROM Service;";

			SqlCommand cmd = new SqlCommand(sqlQuery_GetServiceName, connection);
			SqlDataReader read = cmd.ExecuteReader();

			//For loop each service list and find texbox
			//Reads all the records
			while (read.Read())
			{
				//If the id is the same as the textbox, display the name in the textbox
				if (read.GetValue(0).ToString() == serviceIdTextBox.Text)
				{
					//get Name
					textBox_ServiceName.Text = read.GetValue(1).ToString();
					break;
				}
			}

			//Close connection
			connection.Close();

		}


		//Show customer name
		public void GetCustomerName(){

			//SQL
			SqlConnection connection;
			string connectionString = ConfigurationManager.ConnectionStrings["Invoice_Application_Project.Properties.Settings.InvoiceDatabaseConnectionString"].ConnectionString;

			connection = new SqlConnection(connectionString);
			connection.Open();

			string sqlQuery_GetCustomerName = "SELECT customerId, customerName FROM Customer;";

			SqlCommand cmd = new SqlCommand(sqlQuery_GetCustomerName, connection);
			SqlDataReader read = cmd.ExecuteReader();

			//For loop each service list and find texbox
			//Reads all the records
			while (read.Read())
			{
				//If the id is the same as the textbox, display the name in the textbox
				if (read.GetValue(0).ToString() == customerIdTextBox.Text)
				{
					//get Name
					textBox_CustomerName.Text = read.GetValue(1).ToString();
					break;
				}
			}
			//Close connection
			connection.Close();

		}

		private void TextBox_search_Click(object sender, EventArgs e)
		{
			textBox_search.Text = "";
		}

		private void TextBox_search_Leave(object sender, EventArgs e)
		{
			textBox_search.Text = "🔍 Search Customer";
			this.serviceChosenTableAdapter.Fill(this.invoiceDatabaseDataSet1.ServiceChosen);
		}

		private void Button_Back_Click(object sender, EventArgs e)
		{
			ViewUpdate_Form viewUpdate_Form = new ViewUpdate_Form();
			viewUpdate_Form.Show();
			this.Close();
		}
	}
}
