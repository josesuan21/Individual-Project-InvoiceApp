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

		private void Invoice_Form_Load(object sender, EventArgs e)
		{
			//Current Date
			dateTimePicker_date.Value = DateTime.Today;

			//Invoice Create
			InvoiceNumber_Creator();
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
				//No records exist
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

		private void Button_SavePDF_Click(object sender, EventArgs e)
		{
			
		}
	}
}
