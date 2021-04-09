using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Text.RegularExpressions;

using System.Configuration;
using System.Data.SqlClient;
using System.Collections;

namespace Invoice_Application_Project.Models
{
	public class Service
	{
		//SQL connection
		SqlConnection connection;
		string connectionString = ConfigurationManager.ConnectionStrings["Invoice_Application_Project.Properties.Settings.InvoiceDatabaseConnectionString"].ConnectionString;
		//string connectionString = ""; //use this for user testing 


		//Fields
		private int id;
		private string name;
		private decimal price;


		//Constructor
		public Service() {

		}

		//Used for Ticket 14 method for making a list type of this class
		private Service(int idInput, string nameInput) {

			id = idInput;
			name = nameInput;

		}

		//Properties
		public int ServiceId {

			get { return id; }
			set { id = value; }
		}

		public string ServiceName {

			get { return name; }
			set { name = value; }
		}
		public decimal ServicePrice {

			get { return price; }
			set { price = value; }
		}


		//Methods

		/// <summary>
		/// Show list of services - Ticket 7
		/// </summary>
		public ArrayList ShowListServices()
		{
			ArrayList arrayServiceList = new ArrayList();

			//comboBox_ChooseService.Items.Clear(); TO CLEAR AGAIN

			//SQL
			connection = new SqlConnection(connectionString);
			connection.Open();

			string sqlQuery_DisplayServices = "SELECT serviceName FROM Service;";

			SqlCommand cmd = new SqlCommand(sqlQuery_DisplayServices, connection);
			SqlDataReader read = cmd.ExecuteReader();

			//Reads all list of service in the database
			while (read.Read())
			{
				arrayServiceList.Add(read.GetValue(0).ToString());
			}

			//Close connection
			connection.Close();

			//Return
			return arrayServiceList;
		}


		/// <summary>
		/// Add the chosen service in the list view and ServiceChosen table database - Ticket 8
		/// </summary>
		public ListViewItem AddService(ListViewItem item)
		{

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
				if (read.GetValue(0).ToString() == item.Text)
				{

					//get Price
					item.SubItems.Add(string.Format("{0:0.00}", read.GetValue(1)));

					break;
				}
			}

			//Close connection
			connection.Close();

			return item;

		}


		/// <summary>
		/// Ticket - 14 (Save Chosen Service)
		/// </summary>
		public void AddRecord_ServiceChosen(int currentCustomer, int currentInvoiceId, ListView items)
		{
			//SQL1
			connection = new SqlConnection(connectionString);
			connection.Open();

			//List of services in arraylist
			List<Service> listOfServices = new List<Service>();


			string sqlQuery_GetServiceId = "SELECT serviceId, serviceName FROM Service;";

			SqlCommand cmd1 = new SqlCommand(sqlQuery_GetServiceId, connection);

			SqlDataReader read = cmd1.ExecuteReader();

			//Gets all list of services from database and store into List
			while (read.Read()){

				listOfServices.Add( new Service(Convert.ToInt32(read.GetValue(0)), read.GetValue(1).ToString()));
			}
			connection.Close(); //Closed for cmd1


			//Adding the place holder value for service Id

			for (int i = 0; i < listOfServices.Count; i++)
				{
					foreach (ListViewItem list in items.Items)
					{
						//If the Name is the same as the listview items of chosen services
						if (listOfServices[i].ServiceName == list.SubItems[0].Text)
						{
							connection.Open(); //Open for cmd
							string sqlQuery_InsertRecord = "INSERT INTO ServiceChosen (serviceId, customerId, invoiceRecordId) VALUES (@serviceChosen, @currentCustomer, @invoiceRecordId);";
							SqlCommand cmd = new SqlCommand(sqlQuery_InsertRecord, connection);

							//get service Id
							cmd.Parameters.AddWithValue("@serviceChosen", listOfServices[i].ServiceId);

							//Adding the place holder values for customer id and invoice number
							cmd.Parameters.AddWithValue("@currentCustomer", currentCustomer);
							cmd.Parameters.AddWithValue("@invoiceRecordId", currentInvoiceId);


							//Insert record in database
							cmd.ExecuteNonQuery();

							connection.Close(); //Close for cmd
							
						}

					}

			}

		}

		/// <summary>
		/// Stop Saving ServiceChosen Record - Ticket 026.1
		/// Notes - Reseeding is not neccessary here as it does not make any effect to records, the table only stores records as long the Id is unique
		/// </summary>
		public void RemoveChosenServiceRecord(ListView items) {

			//Check if items contains something
			if (items.Items.Count >= 1) {

				//number of service
				int numberOfService = items.Items.Count;

				//List of recently added services
				List<int> listOfrecentIds = new List<int>();


				//Open connection
				connection = new SqlConnection(connectionString);
				connection.Open();

				//Selecting recent added id
				string sqlQuery_recentId = "SELECT IDENT_CURRENT ('ServiceChosen') as RecentId";

				//Removing recent added record
				string sqlQuery_removeRecent = "DELETE FROM ServiceChosen WHERE serviceChosenId = @recentId";

				SqlCommand cmd1 = new SqlCommand(sqlQuery_recentId, connection);
				SqlCommand cmd2 = new SqlCommand(sqlQuery_removeRecent, connection);


				//Getting the last recent added Id
				SqlDataReader reader = cmd1.ExecuteReader();
				reader.Read();
				int recentId = Convert.ToInt32(reader.GetValue(0));

				//Getting the list of recently added services id
				for (int i = 0; i < numberOfService; i++) {

					listOfrecentIds.Add(recentId);

					recentId--;

				}

				connection.Close();


				//Deleting the record
				connection.Open();

				//Gets the list of recent ids added and use it for the cmd2 parameter
				for (int i = 0; i < listOfrecentIds.Count; i++) {

					cmd2.Parameters.AddWithValue("@recentId", listOfrecentIds[i]);

					cmd2.ExecuteNonQuery();

					cmd2.Parameters.Clear(); //Resets parameters especially the value

				}
				connection.Close();

			}

			else
			{
				//Do nothing - this means there were no service chosen
			}

		}

		/// <summary>
		/// Calculate total price of added service - Ticket 011
		/// </summary>
		public decimal CalculatePrice(ListView item)
		{

			decimal currentPrice = 0m;

			foreach (ListViewItem list in item.Items)
			{
				currentPrice += Convert.ToDecimal(list.SubItems[1].Text);
			}
			return currentPrice;

		}


		/// <summary>
		///  - Apply Discount - Ticket 019
		/// </summary>
		/// <returns></returns>
		public decimal CalculateDiscountPrice(string inputCurrentPrice, decimal discountVal)
		{

			//Ticket 19 - Apply Disocunt
			decimal totalDiscountedPrice = 0m;

			decimal currentPrice = Convert.ToDecimal(inputCurrentPrice);

			decimal discountValue = discountVal / 100m;

			totalDiscountedPrice = currentPrice - (currentPrice * discountValue);

			return Math.Round(totalDiscountedPrice,2);
		}


		/// <summary>
		/// Removes Item and selected item - Ticket 018 and 018.1
		/// </summary>
		public void RemoveServiceItem(ListView.SelectedListViewItemCollection service, ListView listView_Services) {

			try
			{

				//Ticket 018.1 - Remove Selected Service
				if (service.Count == 1)
				{

					foreach (ListViewItem item in service)
					{

						listView_Services.Items.RemoveAt(item.Index);

					}
				}
				//Ticket 18 - Remove service item
				else
				{
					listView_Services.Items.RemoveAt(0);
				}

			}

			catch
			{
				MessageBox.Show("⚠️ No Services Selected ⚠️");
			}



		}


		//Ticket 20.3
		public void SaveService_Database(string servicename, decimal price) {

			//Open connection
			connection = new SqlConnection(connectionString);
			connection.Open();

			//Selecting recent added id
			string sqlQuery_Insert = "INSERT INTO Service (serviceName, price) VALUES (@serviceName, @servicePrice);";

			SqlCommand cmd1 = new SqlCommand(sqlQuery_Insert, connection);

			cmd1.Parameters.AddWithValue("@serviceName", servicename);

			cmd1.Parameters.AddWithValue("@servicePrice", price);

			//Insert new service record in database
			cmd1.ExecuteNonQuery();

			connection.Close(); //Close for cmd

		}

		/// <summary>
		///  - Apply VAT - Ticket 21.3
		/// </summary>
		/// <returns></returns>
		public decimal CalculateVAT(string inputCurrentPrice, decimal vat_Val)
		{

			//- Apply VAT
			decimal totalDiscountedPrice = 0m;

			decimal currentPrice = Convert.ToDecimal(inputCurrentPrice);

			decimal discountValue = vat_Val / 100m;

			totalDiscountedPrice = currentPrice + (currentPrice * discountValue);

			return Math.Round(totalDiscountedPrice, 2);
		}



		//Regular expression for notes
		public bool regularExpression_Notes(string notesInput) {

			bool result = false;

			Regex notesPattern = new Regex(@"^[a-zA-Z0-9\s+\,.!?%£/:+\-]*$");//Matches lower to upper case, space, comma, dot, exclamation, question mark and dash

			if (notesPattern.IsMatch(notesInput) != true)
			{
				MessageBox.Show("Do not uncommon symbols in the notes", "Invalid text");
				result = true;
			}

			return result;

		}





	}

}
