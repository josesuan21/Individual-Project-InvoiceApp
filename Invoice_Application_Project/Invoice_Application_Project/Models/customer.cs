using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;

namespace Invoice_Application_Project.Models
{

	public class Customer
	{
		//SQL connection
		SqlConnection connection;
		string connectionString = ConfigurationManager.ConnectionStrings["Invoice_Application_Project.Properties.Settings.InvoiceDatabaseConnectionString"].ConnectionString;

		//Attributes or fields
		private int id;
		private string name;
		private string email;
		private string address;
		private string postcode;


		//Properties
		public int CustomerId {
			get {return id; }
			set { id = value; } 
		}
		public string CustomerName {
			get { return name ; }
			set {  name = value; }
		}
		public string CustomerEmail {
			get { return email; }
			set {  email = value; }
		}
		public string CustomerAddress {
			get { return address; }
			set { address  = value; }
		}
		public string CustomerPostcode {
			get { return postcode; }
			set { postcode = value; }
		}


		//Methods

		/// <summary>
		/// Create a customer Id when invoice form loads - Ticket 15
		/// </summary>
		public void createCustomerId()
		{
			//Open connection
			connection = new SqlConnection(connectionString);

			connection.Open();

			//where system
			string sqlQuery_InsertCustomerId = "INSERT INTO Customer (customerName) VALUES ('New Customer'); SELECT SCOPE_IDENTITY() as RecentId";

			SqlCommand cmd = new SqlCommand(sqlQuery_InsertCustomerId, connection);

			//Execute command and get current added customer
			SqlDataReader reader = cmd.ExecuteReader();
			reader.Read();

			//setting the id
			CustomerId = Convert.ToInt32(reader.GetValue(0).ToString());

			//Close connection
			connection.Close();
		}


		/// <summary>
		/// Saves customer details - Ticket 6
		/// </summary>
		public void saveCustomerDetails()
		{

			//Open connection
			connection = new SqlConnection(connectionString);

			connection.Open();

			//where system
			string sqlQuery_UpdateCustomerDetails = "UPDATE Customer SET customerName = @name, email = @email, address = @address, postCode = @postcode WHERE customerId = @currentCustomerId;";

			SqlCommand cmd = new SqlCommand(sqlQuery_UpdateCustomerDetails, connection);

			//Adding values from form
			cmd.Parameters.AddWithValue("@name", CustomerName);
			cmd.Parameters.AddWithValue("@email", CustomerEmail);
			cmd.Parameters.AddWithValue("@address", CustomerAddress);
			cmd.Parameters.AddWithValue("@postcode", CustomerPostcode);

			cmd.Parameters.AddWithValue("@currentCustomerId", CustomerId);

			//Execute command
			cmd.ExecuteNonQuery();

			//Close connection
			connection.Close();
		}

		/// <summary>
		/// Stop Saving record if PDF is not saved - Ticket 026
		/// </summary>
		public void RemoveDefaultAdded_CustomerRecord()
		{
			//Open connection
			connection = new SqlConnection(connectionString);

			connection.Open();

			//Reseed
			string sqlQuery_Reseed = "DBCC CHECKIDENT ('Customer',reseed,@reseedVal)";

			//Selecting recent added id
			string sqlQuery_recentId = "SELECT IDENT_CURRENT ('Customer') as RecentId";

			//Removing recent added record
			string sqlQuery_removeRecent = "DELETE FROM Customer WHERE customerId = @recentId";


			SqlCommand cmd1 = new SqlCommand(sqlQuery_Reseed, connection);
			SqlCommand cmd2 = new SqlCommand(sqlQuery_recentId, connection);
			SqlCommand cmd3 = new SqlCommand(sqlQuery_removeRecent, connection);


			//Getting the recent added Id
			SqlDataReader reader = cmd2.ExecuteReader();
			reader.Read();
			int recentId = Convert.ToInt32(reader.GetValue(0));

			connection.Close();


			//Deleting the record
			connection.Open();
			cmd3.Parameters.AddWithValue("@recentId", recentId);
			cmd3.ExecuteNonQuery();

			connection.Close();


			//Reseeding record

			connection.Open();
			cmd1.Parameters.AddWithValue("@reseedVal", recentId - 1);
			cmd1.ExecuteNonQuery();

			connection.Close();

		}






	}

}
