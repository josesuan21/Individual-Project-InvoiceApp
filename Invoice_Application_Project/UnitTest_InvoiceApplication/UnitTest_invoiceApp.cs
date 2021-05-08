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
		Invoice_Application_Project.Models.Service service = new Invoice_Application_Project.Models.Service();

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


		[TestMethod]
		/// <summary>
		/// Inputs of service details
		/// </summary>
		public void Test_ServiceDetails() {

			string name = "End of tenancy";
			decimal price = 250.50m;

			bool validData;

			try
			{
				service.ServiceName = name;
				service.ServicePrice = price;
				validData = true;
			}
			catch
			{
				validData = false;
			}

			//Assert
			Assert.AreEqual(true, validData);


		}
		[TestMethod]
		/// <summary>
		/// Calculates price
		/// </summary>
		public void Test_CalculatePrice() {

			ListView listView = new ListView();
			
			ComboBox comboBox = new ComboBox();

			comboBox.Items.Add("200.50");
			comboBox.Items.Add("100.50");

			ListViewItem listItem1 = new ListViewItem();
			listItem1.SubItems.Add(comboBox.Items[0].ToString());
			ListViewItem listItem2 = new ListViewItem();
			listItem2.SubItems.Add(comboBox.Items[1].ToString());


			listView.Items.AddRange(new ListViewItem[] {listItem1,listItem2 });

			decimal totalPrice = 301.00m;

			bool validData = false;

			try
			{
				if (totalPrice==service.CalculatePrice(listView))
				{
					validData = true;
				}
			}
			catch
			{
				validData = false;
			}

			//Assert
			Assert.AreEqual(true, validData);

		}



		[TestMethod]
		/// <summary>
		/// Calculates Discount
		/// </summary>
		public void Test_CalculateDiscount() {

			string currentPrice = "301.00";
			decimal discountVAL = 20m;
			decimal totalPrice = 240.80m;

			bool validData = false;

			try
			{
				if (totalPrice == service.CalculateDiscountPrice(currentPrice, discountVAL)) {

					validData = true;
				}
			}
			catch
			{
				validData = false;
			}
			
			Assert.AreEqual(true, validData);
		}



		[TestMethod]
		/// <summary>
		/// Calculates VAT
		/// </summary>
		public void Test_CalculateVAT() {
			string currentPrice = "301.00";
			decimal vat = 20m;

			decimal totalPrice = 361.2m;

			bool validData = false;

			try
			{
				if (totalPrice == service.CalculateVAT(currentPrice, vat))
				{

					validData = true;
				}
			}
			catch
			{
				validData = false;
			}

			Assert.AreEqual(true, validData);
		}



		[TestMethod]
		/// <summary>
		/// DISCOUNT and VAT
		/// </summary>
		public void Test_DiscountVAL() {

			string currentPrice = "301.00";
			decimal discount = 20m;
			decimal vat = 20m;

			decimal totalPrice = 288.96m;

			bool validData = false;

			try
			{
				if (totalPrice == service.CalculateVAT(service.CalculateDiscountPrice(currentPrice,discount).ToString(),vat))
				{
					validData = true;
				}
			}
			catch
			{
				validData = false;
			}

			Assert.AreEqual(true, validData);

		}





	}
}
