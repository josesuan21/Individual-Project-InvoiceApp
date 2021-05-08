using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Invoice_Application_Project.Models
{
	public class PaymentDetails
	{
		//SQL connection
		SqlConnection connection;
		string connectionString = ConfigurationManager.ConnectionStrings["Invoice_Application_Project.Properties.Settings.InvoiceDatabaseConnectionString"].ConnectionString;



		//Fields
		private int id;
		private string details;



		//Properties
		public int PaymentId
		{

			get { return id; }
			set { id = value; }
		}

		public string PaymentDetail
		{
			get { return details; }
			set { details = value; }
		}




		//Methods

		public string LoadPaymentDetails_1()
		{

			connection = new SqlConnection(connectionString);
			connection.Open();

			string sqlQuery_DisplayPaymentDetail1 = "SELECT Details FROM PaymentDetails WHERE Id = 1;";


			SqlCommand cmd = new SqlCommand(sqlQuery_DisplayPaymentDetail1, connection);
			SqlDataReader read = cmd.ExecuteReader();

			read.Read();

			PaymentDetail = read.GetValue(0).ToString();

			return PaymentDetail;

		}


		public string LoadPaymentDetails_2()
		{

			connection = new SqlConnection(connectionString);
			connection.Open();

			string sqlQuery_DisplayPaymentDetail1 = "SELECT Details FROM PaymentDetails WHERE Id = 2;";


			SqlCommand cmd = new SqlCommand(sqlQuery_DisplayPaymentDetail1, connection);
			SqlDataReader read = cmd.ExecuteReader();

			read.Read();

			PaymentDetail = read.GetValue(0).ToString();

			return PaymentDetail;

		}


		//Regular expression for notes
		public bool regularExpression_PaymentDetails(int textNum, string notesInput)
		{

			bool result = false;

			Regex paymentDetailsPattern = new Regex(@"^[a-zA-Z0-9\s+\,.!?%£/:+\-]*$");//Matches lower to upper case, space, comma, dot, exclamation, question mark and dash

			switch (textNum) {

			case 1:
				if (paymentDetailsPattern.IsMatch(notesInput) != true)
				{
					MessageBox.Show("Do not use unwanted symbols in the direct transfer", "Invalid text");
					result = true;
				}
			break;

			case 2:
				if (paymentDetailsPattern.IsMatch(notesInput) != true)
				{
					MessageBox.Show("Do not use unwanted symbols in the cheque", "Invalid text");
					result = true;
				}
			break;

			}

			return result;

		}

		//Ticket 31.1 Update changes to database
		public void UpdatePaymentDetails(bool answer, string directTransfer, string chequePayment) {

			//If the user wanted to save the payment details in the future
			if (answer == true) {

				connection = new SqlConnection(connectionString);
				string sqlQuery_UpdateDirectTransDetail = "UPDATE PaymentDetails SET Details = @NewDetails WHERE Id = 1;";
				string sqlQuery_UpdateChequeDetail = "UPDATE PaymentDetails SET Details = @NewDetails WHERE Id = 2;";

				connection.Open();
				SqlCommand cmd = new SqlCommand(sqlQuery_UpdateDirectTransDetail, connection);
				SqlCommand cmd1 = new SqlCommand(sqlQuery_UpdateChequeDetail, connection);

				//Adding values from form
				cmd.Parameters.AddWithValue("@NewDetails", directTransfer);

				//Execute command
				cmd.ExecuteNonQuery();

				//Close connection
				connection.Close();

				connection.Open();
				//Adding values from form
				cmd1.Parameters.AddWithValue("@NewDetails", chequePayment);

				//Execute command
				cmd.ExecuteNonQuery();

				//Close connection
				connection.Close();

			}
			else
			{
				//Do nothing
			}

		}

	}


}
