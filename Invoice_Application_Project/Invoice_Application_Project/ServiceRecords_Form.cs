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
			this.Close();
		}

		private void Button_backwithpoint_Click(object sender, EventArgs e)
		{
			this.serviceBindingSource.MovePrevious();
		}

		private void Button_Next_Click(object sender, EventArgs e)
		{
			this.serviceBindingSource.MoveNext();
		}

		private void Button_AddData_Click(object sender, EventArgs e)
		{
			//Create a new record
			this.serviceBindingSource.AddNew();
			serviceIdTextBox.Text = "###";
			//Focus name
			serviceNameTextBox.Focus();
			//Done button true
			button_Done.Visible = true;
			//Buttons to false
			EnableState_Buttons(false);
			//Update button to false
			button_update.Visible = false;
			//textfields to true
			EnableState_TextFields(true);
		}

		//Disable major buttons
		public void EnableState_Buttons(bool result)
		{

			if (result)
			{
				button_AddData.Enabled = true;
				button_Next.Enabled = true;
				button_backwithpoint.Enabled = true;
			}
			else
			{
				button_AddData.Enabled = false;
				button_Next.Enabled = false;
				button_backwithpoint.Enabled = false;
			}
		}
		//Disable Textfields 
		public void EnableState_TextFields(bool result)
		{

			if (result)
			{
				serviceIdTextBox.Enabled = true;
				serviceNameTextBox.Enabled = true;
				priceTextBox.Enabled = true;
			}
			else
			{
				serviceIdTextBox.Enabled = false;
				serviceNameTextBox.Enabled = false;
				priceTextBox.Enabled = false;
			}

		}
		//Save method
		public void SaveData()
		{
			//Saves
			this.Validate();
			this.serviceBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.invoiceDatabaseDataSet1);
		}

		private void Button_Done_Click(object sender, EventArgs e)
		{
			SaveArchive_OldService();
			this.serviceBindingSource.AddNew();
			this.serviceBindingSource.RemoveCurrent();
			button_Done.Visible = false;
			button_update.Visible = true;
			EnableState_Buttons(true);
			EnableState_TextFields(false);
			SaveData();
		}

		private void Button_update_Click(object sender, EventArgs e)
		{
			EnableState_TextFields(true);
			button_update.Visible = false;
			button_Done.Visible = true;
			EnableState_Buttons(false);
		}


		private void TextBox_search_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.serviceTableAdapter.SearchService(this.invoiceDatabaseDataSet1.Service, textBox_search.Text);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}

		private void TextBox_search_MouseClick(object sender, MouseEventArgs e)
		{
			textBox_search.Clear();
		}

		//Ticket 042 - Save old service price details in the archive storage
		public void SaveArchive_OldService() {
		
			//INSERT that copy of the id in the new table
			//SQL connection
			SqlConnection connection;
			string connectionString = ConfigurationManager.ConnectionStrings["Invoice_Application_Project.Properties.Settings.InvoiceDatabaseConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);

			string[] serviceDetails = new string[3];
			try
			{
				//ServiceRecord
				connection.Open();

				string sqlQuery_DisplayServices = "SELECT serviceId, serviceName, price FROM Service WHERE serviceID = @id;";

				SqlCommand cmd = new SqlCommand(sqlQuery_DisplayServices, connection);

				cmd.Parameters.AddWithValue("@id", serviceIdTextBox.Text);

				SqlDataReader read = cmd.ExecuteReader();

				read.Read();
				//Reads all list of service in the database
				for (int i = 0; i < serviceDetails.Length; i++)
				{
					serviceDetails[i] = (read.GetValue(i).ToString());
				}

				//Close connection
				connection.Close();


				//Old_ServiceRecord
				connection.Open();

				string sqlQuery_InsertOldRecord = "INSERT INTO Old_ServiceRecord (previousId,serviceName,servicePrice) VALUES (@currentId, @name, @price);";

				SqlCommand cmd1 = new SqlCommand(sqlQuery_InsertOldRecord, connection);
				//Get the id of the current one and get the details
				cmd1.Parameters.AddWithValue("@currentId", serviceDetails[0]);
				cmd1.Parameters.AddWithValue("@name", serviceDetails[1]);
				cmd1.Parameters.AddWithValue("@price", serviceDetails[2]);
				cmd1.ExecuteNonQuery();

				connection.Close();
			}
			catch
			{
				//Do nothing
			}
		}

		private void Label_OldServices_Click(object sender, EventArgs e)
		{
			OldServices_Form oldServices = new OldServices_Form();
			oldServices.ShowDialog();
		}

		private void Label_Help_Click(object sender, EventArgs e)
		{
			
		}
	}
}
