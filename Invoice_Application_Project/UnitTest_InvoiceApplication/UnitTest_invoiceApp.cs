using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_InvoiceApplication
{
	[TestClass]
	public class UnitTest_invoiceApp
	{

		/// <summary>
		///  Create Unit Testing - Ticket 29
		/// </summary>

		Invoice_Application_Project.Invoice_Form invoice_Form = new Invoice_Application_Project.Invoice_Form();

		[TestMethod]
		/// <summary>
		/// Customer
		/// </summary>
		public void Test_CustomerDetails(){

			//Arrange
			int id = 1;
			string name = "Jose";
			string email = "j.e.suan1210@ymail";
			string address = "25 Mereworth Road";
			string postCode = "Tn4 9PL";

			bool validData;

			//Act 
			try
			{

				invoice_Form.CustomerId_Text = id;
				invoice_Form.CustomerName_Text = name;
				invoice_Form.CustomerEmail_Text = email;
				invoice_Form.CustomerAddress_Text = address;
				invoice_Form.CustomerPostcode_Text = postCode;


				validData = true;
			}
			catch
			{
				validData = false;
			}

			//Assert
			Assert.AreEqual(true,validData);


		}


		[TestMethod]

		/// <summary>
		/// Invoice Record Details
		/// </summary>
		public void Test_Service() {

		//Arrange
		int id = 1;
		decimal discountVal = 0;
		decimal totalPrice = 0;
		string note = "This is a test note";
		DateTime date = DateTime.Today;
		DateTime duedate = DateTime.Today.AddDays(1);

		bool validData;

		//Act 
			try
			{

				invoice_Form.InvoiceId_Text = id;
				invoice_Form.InvoiceDiscount_Text = discountVal;
				invoice_Form.InvoiceTotalPrice_Text = totalPrice;
				invoice_Form.InvoiceNote_Text = note;
				invoice_Form.InvoiceDate_Text = date;
				invoice_Form.InvoiceDueDate_Text = duedate;


				validData = true;
			}
		catch
			{
				validData = false;
			}

		//Assert
		Assert.AreEqual(true, validData);


		}




	}
}
