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
	public partial class Invoice_Form : Form
	{

		//Connection String
		string connectionString;

		//Declare
		SqlConnection connection;


		public Invoice_Form()
		{
			InitializeComponent();
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

			//Update invoice number
			InvoiceNumber_Creator();

		}

		private void InvoiceNumber_Creator() {


			//Open connection
			connection = new SqlConnection(connectionString);

			connection.Open();

			//Ascending so it will get the recent added invoice
			string sqlQuery = "SELECT invoiceId FROM InvoiceRecord ORDER BY invoiceId ASC"; 

			SqlCommand cmd = new SqlCommand(sqlQuery,connection);

			SqlDataReader reader = cmd.ExecuteReader();

			try
			{
				while (reader.Read())
				{

					textBox_InvoiceNum.Text = (Convert.ToInt32(reader.GetValue(0)) + 1).ToString();

				}
			}
			catch
			{
				MessageBox.Show("Does not have any record added");
			}

			connection.Close();

		}
	}
}
