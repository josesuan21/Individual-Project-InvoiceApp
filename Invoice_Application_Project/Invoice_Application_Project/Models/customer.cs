﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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


		//Default Contructor
		public Customer()
		{

		}

		public Customer(int inputId, string inputName, string inputEmail, string inputAdd, string inputPostcode)
		{

			id = inputId;
			name = inputName;
			email = inputEmail;
			address = inputAdd;
			postcode = inputPostcode;

		}
		//Static list of customers
		static List<Customer> customerList = new List<Customer>();


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

			//Where system
			string sqlQuery_InsertCustomerId = "INSERT INTO Customer (customerName,email,address,postCode) VALUES ('New Customer','new@email','New Address','XX1 1XX'); SELECT SCOPE_IDENTITY() as RecentId";

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
			try
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
			catch
			{

			}

		}

		/// <summary>
		/// Produce list of items in customer details field to suggest to the user -  Ticket 022
		/// </summary>
		public AutoCompleteStringCollection ProducePredicted_Customer() {

			//Open connection
			connection = new SqlConnection(connectionString);

			connection.Open();

			//where system
			string sqlQuery_ListOfCustomer = "SELECT customerId, customerName, email, address, postCode from Customer";

			SqlCommand cmd = new SqlCommand(sqlQuery_ListOfCustomer, connection);

			//Execute command and get current added customer
			SqlDataReader reader = cmd.ExecuteReader();

			AutoCompleteStringCollection autoText = new AutoCompleteStringCollection(); //Contains list of names.

			while (reader.Read())
			{
				//Name + address + postcode
				//autoText.Add(reader[1].ToString() +", "+ reader[3].ToString()+", "+reader[4].ToString());
				customerList.Add(new Customer(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()));
			}

			for (int i =0; i<customerList.Count; i++) {

				//To show in the suggestion textbox name
				autoText.Add( customerList[i].CustomerName +", "+ customerList[i].CustomerAddress +", "+ customerList[i].CustomerPostcode);

			}

			connection.Close();

			return autoText;
		}



		//Get the id first then we do the return name....

		//Ticket 024
		public string[] CustomerFullDetails(string customerDetails) {

			//ArrayList customerFullDetails = new ArrayList();

			string[] customerFullDetails = new string[5];

			for (int i = 0; i < customerList.Count; i++) {

				if (customerList[i].CustomerName + ", " + customerList[i].CustomerAddress + ", " + customerList[i].CustomerPostcode == customerDetails) {

					//Assigns to each index's array
					customerFullDetails[0] = customerList[i].CustomerId.ToString();
					customerFullDetails[1] = customerList[i].CustomerName;
					customerFullDetails[2] = customerList[i].CustomerEmail; 
					customerFullDetails[3] = customerList[i].CustomerAddress;
					customerFullDetails[4] = customerList[i].CustomerPostcode;

					break;
				}


			}

			return customerFullDetails;


		}


		//Regular Expressions

		public bool RegularExpression(int textboxNum, string textboxInput) {

			//FALSE means nothing violates the expression
			bool result = false;

			//Checks whether what textbox is using
			switch (textboxNum) {

				//Name
				case 1:

					Regex namePattern = new Regex(@"^[a-zA-Z\s+\-|^$]*$");//Matches lower to upper case, space and dash
					if (namePattern.IsMatch(textboxInput) != true)
					{
						MessageBox.Show("Name text only accept: \n 1. Letters \n 2. Numbers \n 3. Signs (@, £, $, €, ¥, #) \n 4. Symbols (full stop, comma, colon, semi-colon, hypen) ","Invalid text name");
						result = true;
					}
					if (textboxInput == "") {
						MessageBox.Show("Name required!");
						result = true;
					}

					break;

				//Email
				case 2:

					Regex emailPattern = new Regex(@"(@)(.+)$"); //From Microsoft Docs

					if (emailPattern.IsMatch(textboxInput) != true) {
						MessageBox.Show("Make sure that the email is correct with no spaces","Invalid email");
						result = true;
					}

					break;

				//Address
				case 3:

					Regex addressPattern = new Regex(@"^[a-zA-Z0-9\s+\,.+\-]*$");//Matches lower to upper case, space, comma, dot and dash

					if (addressPattern.IsMatch(textboxInput) != true) {
						MessageBox.Show("Do not use signs in the address", "Invalid address");
						result = true;
					}
					if (textboxInput == "")
					{
						MessageBox.Show("Address required!");
						result = true;
					}

					break;

				//Post code
				case 4:

					Regex postcodePattern = new Regex(@"[A-Z]{1,2}[0-9][A-Z0-9]? ?[0-9][A-Z]{2}$");// Post code format from wiki

					if (postcodePattern.IsMatch(textboxInput) != true)
					{
						MessageBox.Show("Ensure it is a UK Post code. \n e.g. CT1 1QU or CT11QU", "Invalid Post code");
						result = true;
					}
					if (textboxInput == "")
					{
						MessageBox.Show("Post code required!");
						result = true;
					}

					break;

			}

			return result;

		}

		//BUG 009 
		public bool CheckCustomerDetails(string name, string address, string postcode) {


			bool result = false;

			string[] customerDetails = new string[3];
			customerDetails[0] = name;
			//email is not included because its optional
			customerDetails[1] = address;
			customerDetails[2] = postcode;

			for (int i = 0; i < customerDetails.Length; i++)
			{

				if (customerDetails[i] != "")
				{
					result = true;
				}
				else
				{
					result = false;
					break;
				}

			}

			return result;
			
		}

	}

}
