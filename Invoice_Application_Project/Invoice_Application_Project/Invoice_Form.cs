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
using Microsoft.VisualBasic;

namespace Invoice_Application_Project
{
	public partial class Invoice_Form : Form
	{
		//Declare
		SqlConnection connection;

		//Connection String
		string connectionString;

		//Current Customer
		int cuurentCustomerId;


		public Invoice_Form()
		{
			InitializeComponent();
			//Change the data directory when using a different device
			connectionString = ConfigurationManager.ConnectionStrings["Invoice_Application_Project.Properties.Settings.InvoiceDatabaseConnectionString"].ConnectionString;
		}


		private void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}


		private void CheckBox_ApplyDiscount_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_ApplyDiscount.Checked) {
				numericUpDown_Discount.Visible = true;
			}
			else
			{
				numericUpDown_Discount.Visible = false;
				numericUpDown_Discount.Value = 0; //Sets to zero if unchecked
			}
		}


		private void CheckBox_Notes_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_Notes.Checked)
			{
				textBox_InvoiceNotes.Visible = true;
			}
			else
			{
				textBox_InvoiceNotes.Visible = false;
			}
		}

		/// <summary>
		/// Load forms
		/// </summary>
		private void Invoice_Form_Load(object sender, EventArgs e)
		{
			//Current Date
			dateTimePicker_date.Value = DateTime.Today;

			//Invoice Create
			InvoiceNumber_Creator();

			//Create customer Id
			createCustomerId();

			//List of services
			ShowListServices();
		}

		/// <summary>
		/// Creating Invoice Number - Ticket 4
		/// </summary>
		private void InvoiceNumber_Creator() {

			//Open connection
			connection = new SqlConnection(connectionString);

			connection.Open();

			//Call the function to check whether records do exist
			string sqlQuery_CheckRecordsFunction = "SELECT dbo.CheckInvoice_Records();";

			//Reseed Identity
			string sqlQuery_Reseed = "DBCC CHECKIDENT ('InvoiceRecord',reseed,@reseedVal)";

			//Add record with Invoice Id
			string sqlQuery_Insert = "INSERT INTO InvoiceRecord (date) VALUES (@formDate); SELECT SCOPE_IDENTITY() as RecentId";

			

			SqlCommand cmd = new SqlCommand(sqlQuery_CheckRecordsFunction, connection);
			SqlCommand cmd1 = new SqlCommand(sqlQuery_Reseed, connection);
			SqlCommand cmd2 = new SqlCommand(sqlQuery_Insert, connection);


			//Adding the date
			cmd2.Parameters.AddWithValue("@formDate",dateTimePicker_date.Value);


			int a = Convert.ToInt32(cmd.ExecuteScalar()); //returns value of the query function

			if (a == 0)
			{
				//No records exist - Ticket 5
				string newInvoiceNum = Interaction.InputBox("No existing records in the database \n Please add a new Invoice Number:", "Add invoice number", "Type Here",500);

				//Checks input
				if (int.TryParse(newInvoiceNum,out a) && newInvoiceNum != null)
				{
					cmd1.Parameters.AddWithValue("@reseedVal", Convert.ToInt32(newInvoiceNum) - 1);
					cmd1.ExecuteNonQuery();


					//Inserts and show current invoice id
					SqlDataReader reader = cmd2.ExecuteReader();
					reader.Read();
					textBox_InvoiceNum.Text = reader.GetValue(0).ToString();
				}
				else
				{
					Form_Menu menu = new Form_Menu();

					MessageBox.Show("Invoice number must be added. Try again");
					menu.Show();

					this.Close();

				}

			}
			else if (a == 1)
			{
				//With records exist
				SqlDataReader reader = cmd2.ExecuteReader();
				reader.Read();
				textBox_InvoiceNum.Text = reader.GetValue(0).ToString();

			}
			else
			{
				MessageBox.Show("An error occured! Please contact the developer of this program. \n j.e.suan1210@canterbury.ac.uk");
			}

			connection.Close();

		}

		/// <summary>
		/// Create a customer Id when invoice form loads - Ticket 15
		/// </summary>
		public void createCustomerId() {
			//Open connection
			connection = new SqlConnection(connectionString);

			connection.Open();

			//where system
			string sqlQuery_InsertCustomerId = "INSERT INTO Customer (customerName) VALUES ('New Customer'); SELECT SCOPE_IDENTITY() as RecentId";

			SqlCommand cmd = new SqlCommand(sqlQuery_InsertCustomerId, connection);

			//Execute command and get current added customer
			SqlDataReader reader = cmd.ExecuteReader();
			reader.Read();
			cuurentCustomerId = Convert.ToInt32(reader.GetValue(0).ToString());

			//Close connection
			connection.Close();
		}

		/// <summary>
		/// Saves customer details - Ticket 6
		/// </summary>
		public void saveCustomerDetails() {

			//Open connection
			connection = new SqlConnection(connectionString);

			connection.Open();

			//where system
			string sqlQuery_UpdateCustomerDetails = "UPDATE Customer SET customerName = @name, email = @email, address = @address, postCode = @postcode WHERE customerId = @currentCustomerId;";

			SqlCommand cmd = new SqlCommand(sqlQuery_UpdateCustomerDetails, connection);

			//Adding values from form
			cmd.Parameters.AddWithValue("@name",textBox_CustomerName.Text);
			cmd.Parameters.AddWithValue("@email",textBox_Email.Text);
			cmd.Parameters.AddWithValue("@address", textBox_Address.Text);
			cmd.Parameters.AddWithValue("@postcode",textBox_PostCode.Text);

			cmd.Parameters.AddWithValue("@currentCustomerId", cuurentCustomerId);

			//Execute command
			cmd.ExecuteNonQuery();

			//Close connection
			connection.Close();
		}

		/// <summary>
		/// Show list of services - Ticket 7
		/// </summary>
		public void ShowListServices() {

			comboBox_ChooseService.Items.Clear();

			//SQL
			connection = new SqlConnection(connectionString);
			connection.Open();

			string sqlQuery_DisplayServices = "SELECT serviceName FROM Service;";

			SqlCommand cmd = new SqlCommand(sqlQuery_DisplayServices,connection);
			SqlDataReader read = cmd.ExecuteReader();


			while (read.Read()) {

				comboBox_ChooseService.Items.Add(read.GetValue(0).ToString());
			}

			//Close connection
			connection.Close();


		}

		/// <summary>
		/// Add the chosen service in the list view and ServiceChosen table database - Ticket 8
		/// </summary>
		public void AddService(ListViewItem item) {

				//SQL
				connection = new SqlConnection(connectionString);
				connection.Open();

				string sqlQuery_GetServicePrice = "SELECT serviceName, price FROM Service;";

				SqlCommand cmd = new SqlCommand(sqlQuery_GetServicePrice, connection);
				SqlDataReader read = cmd.ExecuteReader();

				//Reads all the records
				while (read.Read())
				{
					//If the name is the same as the item, get and add price
					if (read.GetValue(0).ToString() == item.Text) {

						//get Price
						item.SubItems.Add(string.Format("{0:0.00}", read.GetValue(1)));

						break;
					}
				}

				//Close connection
				connection.Close();

				//Add items in the listview
				listView_Services.Items.Add(item);
			

		}

		/// <summary>
		///  Ticket - 9 (Prompt user to add service)
		/// </summary>
		public void Prompt_NoServices() {

			MessageBox.Show("Please Select a Service", "No Service Chosen");
		}

		private void Button_ChooseService_Click(object sender, EventArgs e)
		{
			//Takes the item in the combo box text
			ListViewItem item = new ListViewItem(comboBox_ChooseService.Text);

			if (item.Text != "Choose service" && item.Text != null)
			{
				
				//Save chosen service
				AddService(item);

				//Add record in ServiceChosen
				AddRecord_ServiceChosen();

				//Calculate price
				textBox_CurrentPrice.Text = string.Format("{0:0.00}", CalculatePrice().ToString());
				//Updates total price
				textBox_TotalPrice.Text = textBox_CurrentPrice.Text;

				//Calculate total price (with discount)
				textBox_TotalPrice.Text = CalculateDiscountPrice().ToString();
			}
			else
			{
				//No services
				Prompt_NoServices();

			}
		}

		/// <summary>
		/// Ticket - 14 (Save Chosen Service)
		/// </summary>
		public void AddRecord_ServiceChosen() {
			//SQL
			connection = new SqlConnection(connectionString);
			connection.Open();

			string sqlQuery_InsertRecord = "INSERT INTO ServiceChosen (serviceId, customerId, invoiceRecordId) VALUES (@serviceChosen, @currentCustomer, @invoiceRecordId);";

			string sqlQuery_GetServiceId = "SELECT serviceId, serviceName FROM Service;";

			SqlCommand cmd = new SqlCommand(sqlQuery_InsertRecord, connection);
			SqlCommand cmd1 = new SqlCommand(sqlQuery_GetServiceId,connection);

			SqlDataReader read = cmd1.ExecuteReader();

			//Adding the place holder value for service Id
			while (read.Read())
			{
				//If the name is the same as the text in combobox
				if (read.GetValue(1).ToString() == comboBox_ChooseService.Text)
				{
					//get service Id
					cmd.Parameters.AddWithValue("@serviceChosen", read.GetValue(0));
					
					connection.Close();
					break;

				}
			}

			connection.Open();
			//Adding the place holder values for customer id and invoice number
			cmd.Parameters.AddWithValue("@currentCustomer", cuurentCustomerId);
			cmd.Parameters.AddWithValue("@invoiceRecordId", textBox_InvoiceNum.Text);

			//Insert record
			cmd.ExecuteNonQuery();

			connection.Close();
		}

		/// <summary>
		/// Saving the note in database - Ticket 10
		/// </summary>
		public void AddNotes() {

			if (checkBox_Notes.Checked) {
				//Open connection
				connection = new SqlConnection(connectionString);

				connection.Open();

				//where system
				string sqlQuery_UpdateNotes = "UPDATE InvoiceRecord SET notes = @notes WHERE invoiceRecordId = @currentInvoiceId;";

				SqlCommand cmd = new SqlCommand(sqlQuery_UpdateNotes, connection);

				//Adding values from form
				cmd.Parameters.AddWithValue("@notes", textBox_InvoiceNotes.Text);
				cmd.Parameters.AddWithValue("@currentInvoiceId", textBox_InvoiceNum.Text);

				//Execute command
				cmd.ExecuteNonQuery();

				//Close connection
				connection.Close();
			}
		}

		/// <summary>
		/// Calculate total price of added service - Ticket 011
		/// </summary>
		public decimal CalculatePrice() {

			decimal currentPrice = 0;

			for (int i=0; i<listView_Services.Items.Count; i++) {

				currentPrice += Convert.ToDecimal(listView_Services.Items[i].SubItems[1].Text);
			}
			return currentPrice;
		
		}

		/// <summary>
		///  - Apply Discount - Ticket 019
		/// </summary>
		/// <returns></returns>
		public decimal CalculateDiscountPrice() {
			//Ticket 19 - Apply Disocunt
			decimal totalDiscountedPrice = 0;

			decimal currentPrice = Convert.ToDecimal(textBox_CurrentPrice.Text);

			decimal discountValue = numericUpDown_Discount.Value / 100;

			totalDiscountedPrice = currentPrice - (currentPrice * discountValue);

			return totalDiscountedPrice;
		}

		/// <summary>
		/// Saving the total price and discount val in the datbase - Ticket 12
		/// </summary>
		public void SaveTotalPrice_DisocuntVal() {
			//Open connection
			connection = new SqlConnection(connectionString);

			connection.Open();

			//where system
			string sqlQuery_SaveTotalPriceDis = "UPDATE InvoiceRecord SET discountGiven = @disocunVal, totalPrice = @totalPrice WHERE invoiceRecordId = @currentInvoiceId;";

			SqlCommand cmd = new SqlCommand(sqlQuery_SaveTotalPriceDis, connection);

			//Adding values from form
			cmd.Parameters.AddWithValue("@disocunVal", numericUpDown_Discount.Value);
			cmd.Parameters.AddWithValue("@totalPrice", textBox_TotalPrice.Text);
			cmd.Parameters.AddWithValue("@currentInvoiceId", textBox_InvoiceNum.Text);

			//Execute command
			cmd.ExecuteNonQuery();

			//Close connection
			connection.Close();


		}



		private void Button_SavePDF_Click(object sender, EventArgs e)
		{
			
			if (listView_Services.Items.Count != 0) {

				//SaveCustomer Details
				saveCustomerDetails();

				//Adding Notes 
				AddNotes();

				//Sacing total price and discount value
				SaveTotalPrice_DisocuntVal();

				//Saves PDF

			}
			else
			{
				//No services 
				Prompt_NoServices();
			}

		}

		private void NumericUpDown_Discount_ValueChanged(object sender, EventArgs e)
		{
			//Calculate total price (with discount)
			textBox_TotalPrice.Text = CalculateDiscountPrice().ToString();
		}
	}
}
