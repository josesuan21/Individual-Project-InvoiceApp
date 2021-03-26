using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualBasic;

using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace Invoice_Application_Project.Models
{
	public class InvoiceRecord
	{
		//SQL connection
		SqlConnection connection;
		string connectionString = ConfigurationManager.ConnectionStrings["Invoice_Application_Project.Properties.Settings.InvoiceDatabaseConnectionString"].ConnectionString;


		//Fields
		int id;
		decimal discount;
		decimal totalPrice;
		string notes;
		DateTime date;
		DateTime dueDate;


		//Properties
		public int InvoiceId{

			get { return id; }
			set { id = value; }
		}
		public decimal InvoiceDiscount{

			get { return discount; }
			set { discount = value; }
		}
		public decimal InvoiceTotalPrice{

			get { return totalPrice; }
			set { totalPrice = value; }
		}
		public string InvoiceNotes {
			get { return notes; }
			set { notes = value; }
		}
		public DateTime InvoiceDate
		{
			get { return date; }
			set { date = value; }
		}
		public DateTime InvoiceDueDate
		{
			get { return dueDate; }
			set { dueDate = value; }
		}


		//Methods

		/// <summary>
		/// Checks whether there are exisiting records
		/// </summary>
		/// <returns></returns>
		private bool CheckInvoiceRecord()
		{

			//Open connection
			connection = new SqlConnection(connectionString);

			connection.Open();

			//Call the function to check whether records do exist
			string sqlQuery_CheckRecordsFunction = "SELECT dbo.CheckInvoice_Records();";

			SqlCommand cmd = new SqlCommand(sqlQuery_CheckRecordsFunction, connection);

			int a = Convert.ToInt32(cmd.ExecuteScalar()); //returns value of the query function

			bool containRecords = false;

			if (a == 0)
			{	
				//No records
				containRecords = false;

			}
			else if(a==1)
			{
				//Contains records
				containRecords = true;
			}

			connection.Close();

			return containRecords;
		}



		/// <summary>
		/// Creating Invoice Number - Ticket 4
		/// </summary>
		public void InvoiceNumber_Creator()
		{

			//Open connection
			connection = new SqlConnection(connectionString);

			connection.Open();

			//Reseed Identity
			string sqlQuery_Reseed = "DBCC CHECKIDENT ('InvoiceRecord',reseed,@reseedVal)";

			//Add record with Invoice Id
			string sqlQuery_Insert = "INSERT INTO InvoiceRecord (date, duedate) VALUES (@formDate, @formDuedate); SELECT SCOPE_IDENTITY() as RecentId";

			
			SqlCommand cmd1 = new SqlCommand(sqlQuery_Reseed, connection);
			SqlCommand cmd2 = new SqlCommand(sqlQuery_Insert, connection);


			//Adding the date
			cmd2.Parameters.AddWithValue("@formDate", InvoiceDate);
			//Adding the due date - Ticket 21.2
			cmd2.Parameters.AddWithValue("@formDuedate", InvoiceDueDate);


			if (CheckInvoiceRecord() == false)
			{
				//No records exist - Ticket 5
				string newInvoiceNum = Interaction.InputBox("No existing records in the database \n Please add a new Invoice Number:", "Add invoice number", "Type Here", 500);


				//Checks input

				//If the input is correct format and not null
				if (int.TryParse(newInvoiceNum, out int i ) && newInvoiceNum != null)
				{
					cmd1.Parameters.AddWithValue("@reseedVal", Convert.ToInt32(newInvoiceNum) - 1); //Minus 1 it because SQL starts to increment
					cmd1.ExecuteNonQuery();


					//Reads Invoice Id and assign it to id field
					SqlDataReader reader = cmd2.ExecuteReader();
					reader.Read();
					InvoiceId = Convert.ToInt32(reader.GetValue(0));
				}
				else
				{
					Form_Menu menu = new Form_Menu();
					
					
					MessageBox.Show("Invoice number must be added. Try again");

					//Show menu form
					menu.Show();

					//Closing invoice Form
					foreach (Form form in System.Windows.Forms.Application.OpenForms) {

						if (form is Invoice_Form) {
							form.Close();
							break;
						}
					}


				}

			}
			else if (CheckInvoiceRecord() == true)
			{
				//With records exist, just simply add in database
				SqlDataReader reader = cmd2.ExecuteReader();
				reader.Read();
				InvoiceId = Convert.ToInt32(reader.GetValue(0));

			}
			else
			{
				MessageBox.Show("An error occured! Please contact the developer of this program. \n j.e.suan1210@canterbury.ac.uk");
			}

			connection.Close();

		}


		/// <summary>
		/// Saving the note in database - Ticket 10
		/// </summary>
		public void AddNotes()
		{
			//Open connection
			connection = new SqlConnection(connectionString);

			connection.Open();

			//where system
			string sqlQuery_UpdateNotes = "UPDATE InvoiceRecord SET notes = @notes WHERE invoiceRecordId = @currentInvoiceId;";

			SqlCommand cmd = new SqlCommand(sqlQuery_UpdateNotes, connection);

			//Adding values from form
			cmd.Parameters.AddWithValue("@notes", InvoiceNotes);
			cmd.Parameters.AddWithValue("@currentInvoiceId", InvoiceId);

			//Execute command
			cmd.ExecuteNonQuery();

			//Close connection
			connection.Close();
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
			cmd.Parameters.AddWithValue("@disocunVal", InvoiceDiscount);
			cmd.Parameters.AddWithValue("@totalPrice", InvoiceTotalPrice);
			cmd.Parameters.AddWithValue("@currentInvoiceId", InvoiceId);

			//Execute command
			cmd.ExecuteNonQuery();

			//Close connection
			connection.Close();

		}


		/// <summary>
		/// Stop saving record if PDF is not saved - Ticket 026
		/// </summary>
		public void RemoveDefaultAdded_InvoiceRecord() {
			//Open connection
			connection = new SqlConnection(connectionString);

			connection.Open();

			//Reseed
			string sqlQuery_Reseed = "DBCC CHECKIDENT ('InvoiceRecord',reseed,@reseedVal)";

			//Selecting recent added id
			string sqlQuery_recentId = "SELECT IDENT_CURRENT ('InvoiceRecord') as RecentId";

			//Removing recent added record
			string sqlQuery_removeRecent = "DELETE FROM InvoiceRecord WHERE invoiceRecordId = @recentId";


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
			cmd1.Parameters.AddWithValue("@reseedVal", recentId-1);
			cmd1.ExecuteNonQuery();

			connection.Close();

		}


	}

}
