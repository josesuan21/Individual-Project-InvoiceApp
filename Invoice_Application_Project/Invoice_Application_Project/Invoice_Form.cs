using System;
using System.ComponentModel;
using System.Drawing;
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

		//Flag create service
		static string newService_Name;
		static string newService_Price;

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
		public string PDFvat_Text { get { return numericUpDown_vat.Text; } set { numericUpDown_vat.Text = value; } }
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
				checkBox_Notes.ForeColor = Color.Black;
			}
		}

		/// <summary>
		/// Load forms
		/// </summary>
		private void Invoice_Form_Load(object sender, EventArgs e)
		{

			//Current Date
			dateTimePicker_date.Value = DateTime.Today;
			//Validate date = due date
			dateTimePicker_date.MaxDate = dateTimePicker_DueDate.Value;
			//Due date plus 1 day
			dateTimePicker_DueDate.Value = DateTime.Today.AddDays(1);
			//Validate due date
			dateTimePicker_DueDate.MinDate = dateTimePicker_date.Value;

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

				//Predict Existing Customer - Ticket 022
				textBox_CustomerName.AutoCompleteMode = AutoCompleteMode.Suggest;
				textBox_CustomerName.AutoCompleteSource = AutoCompleteSource.CustomSource;
				//Do the sorting here
				textBox_CustomerName.AutoCompleteCustomSource = customerPresenter.ProducePredicted_Customer();
				 

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

				//Calculate total price (Discount and VAT)
				textBox_TotalPrice.Text = string.Format("{0:0.00}", servicePresenter.CalculateVAT(servicePresenter.CalculateDiscountPrice(textBox_CurrentPrice.Text, numericUpDown_Discount.Value).ToString(), numericUpDown_vat.Value));

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

			//Calculate total price (Discount and VAT)
			textBox_TotalPrice.Text = string.Format("{0:0.00}", servicePresenter.CalculateVAT(servicePresenter.CalculateDiscountPrice(textBox_CurrentPrice.Text, numericUpDown_Discount.Value).ToString(), numericUpDown_vat.Value));


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

			//Calculate total price (Discount and VAT)
			textBox_TotalPrice.Text = string.Format("{0:0.00}", servicePresenter.CalculateVAT(servicePresenter.CalculateDiscountPrice(textBox_CurrentPrice.Text, numericUpDown_Discount.Value).ToString(), numericUpDown_vat.Value));

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

		private void Button_CreateService_Click(object sender, EventArgs e)
		{
			
			CreateService createServiceForm = new CreateService();
			ServicePresenter servicePresenter = new ServicePresenter(this);

			createServiceForm.ShowDialog();

			if (newService_Name != null || newService_Price != null)
			{
				ListViewItem item = new ListViewItem();
				item.Text = newService_Name;
				item.SubItems.Add(newService_Price);

				//Add Custom Service and Price - Ticket 20.1
				listView_Services.Items.Add(item);

				//Update price
				//Calculate price (Service presenter)
				textBox_CurrentPrice.Text = string.Format("{0:0.00}", servicePresenter.CalculatePrice(listView_Services).ToString());
				//Updates total price
				textBox_TotalPrice.Text = textBox_CurrentPrice.Text;

				//Calculate total price (Discount and VAT)
				textBox_TotalPrice.Text = string.Format("{0:0.00}", servicePresenter.CalculateVAT(servicePresenter.CalculateDiscountPrice(textBox_CurrentPrice.Text, numericUpDown_Discount.Value).ToString(), numericUpDown_vat.Value));


				//reset custom service data
				newService_Name = null;
				newService_Price = null;

				//reset combo box incase of newly saved service in database
				comboBox_ChooseService.Items.Clear();
				label_chooseAservice.Visible = true;
				for (int i = 0; i < servicePresenter.ShowListServices().Count; i++)
				{
					
					comboBox_ChooseService.Items.Add(servicePresenter.ShowListServices()[i]);

				}


			}


		}
		
		public void GetNewService(string newService, decimal newPrice) {
			newService_Name = newService;
			newService_Price = newPrice.ToString();
		}

		//Ticket 21.3
		private void CheckBox_Vat_CheckedChanged(object sender, EventArgs e)
		{

			if (checkBox_Vat.Checked)
			{
				numericUpDown_vat.Visible = true;
				numericUpDown_vat.Value = 20; //standard VAT UK
			}
			else
			{
				numericUpDown_vat.Visible = false;
				numericUpDown_vat.Value = 0; //Sets to zero if unchecked
			}

		}

		private void NumericUpDown_vat_ValueChanged(object sender, EventArgs e)
		{
			ServicePresenter servicePresenter = new ServicePresenter(this);
			//Calculate total price (Discount and VAT)
			textBox_TotalPrice.Text = string.Format("{0:0.00}", servicePresenter.CalculateVAT(servicePresenter.CalculateDiscountPrice(textBox_CurrentPrice.Text, numericUpDown_Discount.Value).ToString(), numericUpDown_vat.Value));
		}

		//Ticket 022.1
		private void TextBox_CustomerName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter) {

				CustomerPresenter customer = new CustomerPresenter(this);
				string[] customerDetails = new string[5];

				//*****Get customer name details and Assign textboxes using array
				customerDetails = customer.CustomerFullDetails(textBox_CustomerName.Text);
				//BUG 004 creating the if
				if (customerDetails[0] != null) {
					//Ticket 022.1
					//*****Return full details in an arrayList or List
					//0 - id - Ticket 24
					curentCustomerId = Convert.ToInt32(customerDetails[0]);
					//1 - name
					textBox_CustomerName.Text = customerDetails[1];
					//2 - email
					textBox_Email.Text = customerDetails[2];
					//3 - address
					textBox_Address.Text = customerDetails[3];
					//4 - Postcode
					textBox_PostCode.Text = customerDetails[4];

					//*****Remove created deafault customer
					customer.RemoveDefaultAdded_CustomerRecord();

					//Disable textboxes
					textBox_CustomerName.Enabled = false;
					textBox_Email.Enabled = false;
					textBox_Address.Enabled = false;
					textBox_PostCode.Enabled = false;

					//Make button create new customer visible
					button_NewCustomer.Visible = true;

				}
				
			}

		}

		//BUG 004
		private void Button_NewCustomer_Click(object sender, EventArgs e)
		{
			CustomerPresenter customer = new CustomerPresenter(this);
			//Create a new non existing customer
			customer.CreateCustomerId();

			//Assigns and get the current customer Id
			curentCustomerId = customer.GetCustomerId();

			//Clear textboxes fields
			textBox_CustomerName.Clear();
			textBox_Email.Clear();
			textBox_Address.Clear(); 
			textBox_PostCode.Clear();

			//Enable textboxes
			textBox_CustomerName.Enabled = true;
			textBox_Email.Enabled = true;
			textBox_Address.Enabled = true;
			textBox_PostCode.Enabled = true;

			//Make button invisible
			button_NewCustomer.Visible = false;

		}

		// Validate header input details (date and due date) -  Ticket 38
		private void DateTimePicker_DueDate_ValueChanged(object sender, EventArgs e)
		{
			dateTimePicker_date.MaxDate = dateTimePicker_DueDate.Value;
		}

		private void DateTimePicker_date_ValueChanged(object sender, EventArgs e)
		{
			dateTimePicker_DueDate.MinDate = dateTimePicker_date.Value;
		}

		// Validation Customer input details - Ticket 38.1
		private void TextBox_CustomerName_Validating(object sender, CancelEventArgs e)
		{
			CustomerPresenter customer = new CustomerPresenter(this);

			if (customer.RegularExpression(1,textBox_CustomerName.Text)) {
				e.Cancel = true;
				label_CustomerName.ForeColor = Color.Red;
			}
			else
			{
				label_CustomerName.ForeColor = Color.Black;
				e.Cancel = false;
			}

		}

		private void TextBox_Email_Validating(object sender, CancelEventArgs e)
		{
			CustomerPresenter customer = new CustomerPresenter(this);

			if (customer.RegularExpression(2, textBox_Email.Text)) {
				textBox_Email.Clear();
				label_Email.ForeColor = Color.Red;
			}
			else
			{
				label_Email.ForeColor = Color.Black;
				e.Cancel = false;
			}

		}

		private void TextBox_Address_Validating(object sender, CancelEventArgs e)
		{
			CustomerPresenter customer = new CustomerPresenter(this);

			if (customer.RegularExpression(3, textBox_Address.Text))
			{
				textBox_Address.Clear();
				label_Address.ForeColor = Color.Red;
			}
			else
			{
				label_Address.ForeColor = Color.Black;
				e.Cancel = false;
			}
		}

		private void TextBox_PostCode_Validating(object sender, CancelEventArgs e)
		{
			CustomerPresenter customer = new CustomerPresenter(this);
			if (customer.RegularExpression(4, textBox_PostCode.Text))
			{
				textBox_PostCode.Clear();
				label_PostCode.ForeColor = Color.Red;
			}
			else
			{
				label_PostCode.ForeColor = Color.Black;
				
			}

		}

		//(Validation) Service input details - Ticket 038.2 
		private void ComboBox_ChooseService_DropDownClosed(object sender, EventArgs e)
		{
			label_chooseAservice.Visible = false;
		}

		private void TextBox_InvoiceNotes_Validating(object sender, CancelEventArgs e)
		{
			ServicePresenter servicePresenter = new ServicePresenter(this);
			if (servicePresenter.regularExpression_Notes(textBox_InvoiceNotes.Text)) {
				textBox_InvoiceNotes.Clear();
				checkBox_Notes.ForeColor = Color.Red;
			}
			else
			{
				checkBox_Notes.ForeColor = Color.Black;
				e.Cancel = false;
			}

		}

		//(Validation) Payment input details - Ticket 038.3 
		private void TextBox_PaymentTransfer_Validating(object sender, CancelEventArgs e)
		{
			PaymentDetailsPresenter paymentDetails = new PaymentDetailsPresenter(this);
			if (paymentDetails.regularExpression_PaymentDetails(1,textBox_PaymentTransfer.Text))
			{
				e.Cancel = true;
				label_DirectTransfer.ForeColor = Color.Red;
			}
			else
			{
				label_DirectTransfer.ForeColor = Color.Black;
				e.Cancel = false;
			}

		}

		private void TextBox_ChequePayment_Validating(object sender, CancelEventArgs e)
		{
			PaymentDetailsPresenter paymentDetails = new PaymentDetailsPresenter(this);
			if (paymentDetails.regularExpression_PaymentDetails(2, textBox_ChequePayment.Text))
			{
				e.Cancel = true;
				label_ChequePayment.ForeColor = Color.Red;

			}
			else
			{
				label_ChequePayment.ForeColor = Color.Black;
				e.Cancel = false;
			}
		}
		//Add service focus - Ticket 033
		private void ComboBox_ChooseService_SelectedIndexChanged(object sender, EventArgs e)
		{
			button_ChooseService.Focus();
		}



		



	}

}
