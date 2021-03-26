using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Invoice_Application_Project.Views;
using Invoice_Application_Project.Presenters;


namespace Invoice_Application_Project
{
	public partial class Invoice_Form : Form,ICustomer,IinvoiceRecord,IService,IPdf,IPaymentDetails
	{
		//Current Invoice
		static int currentInvoiceId;

		//Current Customer
		static int curentCustomerId;

		//Flag for Save PDF button
		bool completedInvoice;


		//InvoiceRecord Interface - Ticket 30
		public int InvoiceId_Text { get {return currentInvoiceId; } set { currentInvoiceId = value; } }
		public decimal InvoiceDiscount_Text { get { return numericUpDown_Discount.Value; } set { numericUpDown_Discount.Value = value; } }
		public decimal InvoiceTotalPrice_Text { get { return Convert.ToDecimal(textBox_TotalPrice.Text); } set { textBox_TotalPrice.Text = value.ToString(); } }
		public string InvoiceNote_Text { get {return textBox_InvoiceNotes.Text;} set { textBox_InvoiceNotes.Text = value; } }
		public DateTime InvoiceDate_Text { get {return dateTimePicker_date.Value; } set { dateTimePicker_date.Value = value; } }
		//Ticket 21.2
		public DateTime InvoiceDueDate_Text { get { return dateTimePicker_DueDate.Value; } set { dateTimePicker_DueDate.Value = value; } }

		//Customer Interface - Ticket 30
		public int CustomerId_Text { get { return curentCustomerId; } set { curentCustomerId = value; } }
		public string CustomerName_Text { get { return textBox_CustomerName.Text; } set { textBox_CustomerName.Text = value; } }
		public string CustomerEmail_Text { get { return textBox_Email.Text; } set { textBox_Email.Text = value; } }
		public string CustomerAddress_Text { get { return textBox_Address.Text; } set { textBox_Address.Text = value; } }
		public string CustomerPostcode_Text { get { return textBox_PostCode.Text; } set { textBox_PostCode.Text = value; } }

		//Service Interface (Observe if needed any use for future tickets) - Ticket 30
		public int ServiceId_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string ServiceName_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public decimal ServicePrice_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		//PDF Interface - Ticket 30
		public string PDFinvoiceId_Text { get { return currentInvoiceId.ToString(); } set { currentInvoiceId = Convert.ToInt32(value); } }
		public DateTime PDFdate_Text { get { return dateTimePicker_date.Value; } set { dateTimePicker_date.Value = value; } }
		public DateTime PDFduedate_Text { get { return dateTimePicker_DueDate.Value; } set { dateTimePicker_DueDate.Value = value; } }
		public string PDFcustomerName_Text { get { return textBox_CustomerName.Text; } set { textBox_CustomerName.Text = value; } }
		public string PDFemail_Text { get { return textBox_Email.Text; } set { textBox_Email.Text = value; } }
		public string PDFaddress_Text { get { return textBox_Address.Text; } set { textBox_Address.Text = value; } }
		public string PDFpostCode_Text { get { return textBox_PostCode.Text; } set { textBox_PostCode.Text = value; } }
		public string PDFnotes_Text { get { return textBox_InvoiceNotes.Text; } set { textBox_InvoiceNotes.Text = value; } }
		//Save Payment Details to PDF - Ticket 017.2
		public string PDFnotes_PaymentTransfer { get { return textBox_PaymentTransfer.Text; } set { textBox_PaymentTransfer.Text = value; } }
		public string PDFnotes_PaymentCheque { get { return textBox_ChequePayment.Text; } set { textBox_ChequePayment.Text = value; } }


		public string PDFdiscountGiven_Text { get { return numericUpDown_Discount.Text; } set { numericUpDown_Discount.Text = value; } }
		public string PDFtotalPrice_Text { get { return textBox_TotalPrice.Text; } set { textBox_TotalPrice.Text = value; } }

		//Payment Details (Observe if needed any use for future tickets)  Ticket 17
		public int PaymentId_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string PaymentDetails_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		

		public Invoice_Form()
		{
			InitializeComponent();
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
				numericUpDown_Discount.Value = 0; //Sets to zero if unchecked
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

		/// <summary>
		/// Load forms
		/// </summary>
		private void Invoice_Form_Load(object sender, EventArgs e)
		{

			//Current Date
			dateTimePicker_date.Value = DateTime.Today;

			dateTimePicker_DueDate.Value = DateTime.Today.AddDays(1);

			//Create Invoice Number;
			InvoiceRecordPresenter invoiceRecordPresenter = new InvoiceRecordPresenter(this);
			invoiceRecordPresenter.CreateInvoiceId();
			currentInvoiceId = invoiceRecordPresenter.GetInvoiceId();
			textBox_InvoiceNum.Text = currentInvoiceId.ToString();

			//BUG 001 
			if (invoiceRecordPresenter.GetInvoiceId() != 0)
			{
				//Create customer Id (Customer Presenter)
				CustomerPresenter customerPresenter = new CustomerPresenter(this);
				customerPresenter.CreateCustomerId();

				//Assigns and get the current customer Id
				curentCustomerId = customerPresenter.GetCustomerId();


				//List of services (Service Presenter)
				comboBox_ChooseService.Items.Clear();
				ServicePresenter servicePresenter = new ServicePresenter(this);

				for (int i=0; i<servicePresenter.ShowListServices().Count;i++) {

					comboBox_ChooseService.Items.Add(servicePresenter.ShowListServices()[i]);

				}


			}

			//Show payment details - Ticket 017.1
			PaymentDetailsPresenter paymentDetails = new PaymentDetailsPresenter(this);
			textBox_PaymentTransfer.Text = paymentDetails.GetDirectTransfer();
			textBox_ChequePayment.Text = paymentDetails.GetChequePayment();

			

		}

		/// <summary>
		///  Ticket - 9 (Prompt user to add service)
		/// </summary>
		public void Prompt_NoServices() {

			MessageBox.Show("Please Select a Service", "No Service Chosen");
		}

		private void Button_ChooseService_Click(object sender, EventArgs e)
		{
			//Takes the item in the combo box text
			ListViewItem item = new ListViewItem(comboBox_ChooseService.Text);

			if (item.Text != "Choose service" && item.Text != null)
			{

				ServicePresenter servicePresenter = new ServicePresenter(this);

				//Add chosen service (Service presenter)
				listView_Services.Items.Add(servicePresenter.AddService(item));

				//Add record in ServiceChosen - Removed due to Ticket 14.1

				//Calculate price (Service presenter)
				textBox_CurrentPrice.Text = string.Format("{0:0.00}", servicePresenter.CalculatePrice(listView_Services).ToString());
				//Updates total price
				textBox_TotalPrice.Text = textBox_CurrentPrice.Text;

				//Calculate total price (with discount)
				textBox_TotalPrice.Text = string.Format("{0:0.00}",servicePresenter.CalculateDiscountPrice(textBox_CurrentPrice.Text, numericUpDown_Discount.Value).ToString());
			}
			else
			{
				//No services
				Prompt_NoServices();

			}
		}

		private void Button_SavePDF_Click(object sender, EventArgs e)
		{	

			//Create object presenters
			InvoiceRecordPresenter invoiceRecordPresenter = new InvoiceRecordPresenter(this);
			CustomerPresenter customerPresenter = new CustomerPresenter(this);
			ServicePresenter servicePresenter = new ServicePresenter(this);
			PdfPresenter pdfPresenter = new PdfPresenter(this);
			

			if (listView_Services.Items.Count != 0) {

				//SaveCustomer Details (Customer Presenter)
				customerPresenter.SaveCustomerDetails();

				//Adding Notes 
				if (checkBox_Notes.Checked) {
					
					invoiceRecordPresenter.AddNotes();
				}

				//Save Services (Service Presenter)
				servicePresenter.AddRecord_ServiceChosen(curentCustomerId, currentInvoiceId, listView_Services);


				//Saving total price and discount value (Service Presenter)
				invoiceRecordPresenter.SaveTotalPrice_Discount();


				//Set flag and Saves PDF (Pdf Presenter)
				//BUG 002 - Flag Saving Dialogue Cancel
				completedInvoice = pdfPresenter.SavePDF(listView_Services);


			}
			else
			{
				//No services 
				Prompt_NoServices();
			}


			//Close invoice and go to main menu
			Form_Menu openHome = new Form_Menu();

			openHome.Show();
			this.Close();

		}

		private void NumericUpDown_Discount_ValueChanged(object sender, EventArgs e)
		{
			ServicePresenter servicePresenter = new ServicePresenter(this);

			//Calculate total price (with discount)
			textBox_TotalPrice.Text = string.Format("{0:0.00}", servicePresenter.CalculateDiscountPrice(textBox_CurrentPrice.Text, numericUpDown_Discount.Value).ToString());
		}

		//Remove selected Service - Ticket 018
		private void Button_RemoveService_Click(object sender, EventArgs e)
		{
			ServicePresenter servicePresenter = new ServicePresenter(this);

			ListView.SelectedListViewItemCollection service = this.listView_Services.SelectedItems;
			servicePresenter.RemoveServiceItem(service,listView_Services);

			//Update price
			//Calculate price (Service presenter)
			textBox_CurrentPrice.Text = string.Format("{0:0.00}", servicePresenter.CalculatePrice(listView_Services).ToString());
			//Updates total price
			textBox_TotalPrice.Text = textBox_CurrentPrice.Text;

			//Calculate total price (with discount)
			textBox_TotalPrice.Text = string.Format("{0:#.00}", servicePresenter.CalculateDiscountPrice(textBox_CurrentPrice.Text, numericUpDown_Discount.Value).ToString());
		}

		//Ticket 026 - Stop Saving record if PDF is not completed
		private void Invoice_Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			//If the invoice is not finished by not clicking the save pdf button
			if (completedInvoice == false) {

				InvoiceRecordPresenter invoiceRecordPresenter = new InvoiceRecordPresenter(this);
				CustomerPresenter customer = new CustomerPresenter(this);
				ServicePresenter service = new ServicePresenter(this);
				Form_Menu form_Menu = new Form_Menu();

				//ServiceChosen record remove added services
				service.RemoveChosenServiceRecord(listView_Services);

				//Invoice record remove default added
				invoiceRecordPresenter.RemoveDefaultAdded_InvoiceRecord();
				//Customer record remove default added
				customer.RemoveDefaultAdded_CustomerRecord();

				MessageBox.Show("Invoice not finsihed");

				form_Menu.Show();
			}
			else
			{
				MessageBox.Show("Invoice Saved");
			}
			

		}
	}

}
