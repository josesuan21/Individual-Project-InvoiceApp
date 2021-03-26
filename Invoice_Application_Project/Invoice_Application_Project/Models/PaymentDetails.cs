using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Configuration;
using System.Data.SqlClient;

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

		public string LoadPaymentDetails_1(){

			connection = new SqlConnection(connectionString);
			connection.Open();

			string sqlQuery_DisplayPaymentDetail1 = "SELECT Details FROM PaymentDetails WHERE Id = 1;";


			SqlCommand cmd = new SqlCommand(sqlQuery_DisplayPaymentDetail1, connection);
			SqlDataReader read = cmd.ExecuteReader();

			read.Read();

			PaymentDetail = read.GetValue(0).ToString();

			return PaymentDetail;

		}


		public string LoadPaymentDetails_2() {

			connection = new SqlConnection(connectionString);
			connection.Open();

			string sqlQuery_DisplayPaymentDetail1 = "SELECT Details FROM PaymentDetails WHERE Id = 2;";


			SqlCommand cmd = new SqlCommand(sqlQuery_DisplayPaymentDetail1, connection);
			SqlDataReader read = cmd.ExecuteReader();

			read.Read();

			PaymentDetail = read.GetValue(0).ToString();

			return PaymentDetail;

		}



	}
}
