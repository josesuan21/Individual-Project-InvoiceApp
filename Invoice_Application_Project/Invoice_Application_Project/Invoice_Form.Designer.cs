namespace Invoice_Application_Project
{
	partial class Invoice_Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice_Form));
			this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
			this.groupBox_CustomerDetails = new System.Windows.Forms.GroupBox();
			this.button_NewCustomer = new System.Windows.Forms.Button();
			this.textBox_Email = new System.Windows.Forms.TextBox();
			this.label_Email = new System.Windows.Forms.Label();
			this.textBox_PostCode = new System.Windows.Forms.TextBox();
			this.textBox_Address = new System.Windows.Forms.TextBox();
			this.textBox_CustomerName = new System.Windows.Forms.TextBox();
			this.label_PostCode = new System.Windows.Forms.Label();
			this.label_Address = new System.Windows.Forms.Label();
			this.label_CustomerName = new System.Windows.Forms.Label();
			this.textBox_InvoiceNum = new System.Windows.Forms.TextBox();
			this.label_InvoiceNumber = new System.Windows.Forms.Label();
			this.groupBox_ServicesDetails = new System.Windows.Forms.GroupBox();
			this.label_chooseAservice = new System.Windows.Forms.Label();
			this.numericUpDown_vat = new System.Windows.Forms.NumericUpDown();
			this.checkBox_Vat = new System.Windows.Forms.CheckBox();
			this.button_CreateService = new System.Windows.Forms.Button();
			this.button_RemoveService = new System.Windows.Forms.Button();
			this.checkBox_Notes = new System.Windows.Forms.CheckBox();
			this.numericUpDown_Discount = new System.Windows.Forms.NumericUpDown();
			this.textBox_TotalPrice = new System.Windows.Forms.TextBox();
			this.textBox_InvoiceNotes = new System.Windows.Forms.TextBox();
			this.label_TotalPrice = new System.Windows.Forms.Label();
			this.checkBox_ApplyDiscount = new System.Windows.Forms.CheckBox();
			this.textBox_CurrentPrice = new System.Windows.Forms.TextBox();
			this.label_CurrentPrice = new System.Windows.Forms.Label();
			this.listView_Services = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button_ChooseService = new System.Windows.Forms.Button();
			this.comboBox_ChooseService = new System.Windows.Forms.ComboBox();
			this.groupBox_PaymentDetails = new System.Windows.Forms.GroupBox();
			this.label_ChequePayment = new System.Windows.Forms.Label();
			this.label_DirectTransfer = new System.Windows.Forms.Label();
			this.textBox_ChequePayment = new System.Windows.Forms.TextBox();
			this.textBox_PaymentTransfer = new System.Windows.Forms.TextBox();
			this.groupBox_Confirmation = new System.Windows.Forms.GroupBox();
			this.button_SavePDF = new System.Windows.Forms.Button();
			this.header = new System.Windows.Forms.Panel();
			this.label_Duedate = new System.Windows.Forms.Label();
			this.label_Date = new System.Windows.Forms.Label();
			this.dateTimePicker_DueDate = new System.Windows.Forms.DateTimePicker();
			this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
			this.groupBox_CustomerDetails.SuspendLayout();
			this.groupBox_ServicesDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Discount)).BeginInit();
			this.groupBox_PaymentDetails.SuspendLayout();
			this.groupBox_Confirmation.SuspendLayout();
			this.header.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
			this.SuspendLayout();
			// 
			// dateTimePicker_date
			// 
			this.dateTimePicker_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker_date.Location = new System.Drawing.Point(457, 22);
			this.dateTimePicker_date.MaximumSize = new System.Drawing.Size(200, 24);
			this.dateTimePicker_date.Name = "dateTimePicker_date";
			this.dateTimePicker_date.Size = new System.Drawing.Size(169, 24);
			this.dateTimePicker_date.TabIndex = 100;
			this.dateTimePicker_date.Value = new System.DateTime(2021, 2, 2, 1, 29, 55, 0);
			this.dateTimePicker_date.ValueChanged += new System.EventHandler(this.DateTimePicker_date_ValueChanged);
			// 
			// groupBox_CustomerDetails
			// 
			this.groupBox_CustomerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_CustomerDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox_CustomerDetails.Controls.Add(this.button_NewCustomer);
			this.groupBox_CustomerDetails.Controls.Add(this.textBox_Email);
			this.groupBox_CustomerDetails.Controls.Add(this.label_Email);
			this.groupBox_CustomerDetails.Controls.Add(this.textBox_PostCode);
			this.groupBox_CustomerDetails.Controls.Add(this.textBox_Address);
			this.groupBox_CustomerDetails.Controls.Add(this.textBox_CustomerName);
			this.groupBox_CustomerDetails.Controls.Add(this.label_PostCode);
			this.groupBox_CustomerDetails.Controls.Add(this.label_Address);
			this.groupBox_CustomerDetails.Controls.Add(this.label_CustomerName);
			this.groupBox_CustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_CustomerDetails.Location = new System.Drawing.Point(8, 139);
			this.groupBox_CustomerDetails.MinimumSize = new System.Drawing.Size(631, 180);
			this.groupBox_CustomerDetails.Name = "groupBox_CustomerDetails";
			this.groupBox_CustomerDetails.Size = new System.Drawing.Size(631, 180);
			this.groupBox_CustomerDetails.TabIndex = 6;
			this.groupBox_CustomerDetails.TabStop = false;
			this.groupBox_CustomerDetails.Text = "Customer Details";
			// 
			// button_NewCustomer
			// 
			this.button_NewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_NewCustomer.Location = new System.Drawing.Point(543, 65);
			this.button_NewCustomer.Name = "button_NewCustomer";
			this.button_NewCustomer.Size = new System.Drawing.Size(75, 44);
			this.button_NewCustomer.TabIndex = 8;
			this.button_NewCustomer.Text = "New Customer";
			this.button_NewCustomer.UseVisualStyleBackColor = true;
			this.button_NewCustomer.Visible = false;
			this.button_NewCustomer.Click += new System.EventHandler(this.Button_NewCustomer_Click);
			// 
			// textBox_Email
			// 
			this.textBox_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Email.Location = new System.Drawing.Point(213, 60);
			this.textBox_Email.Name = "textBox_Email";
			this.textBox_Email.Size = new System.Drawing.Size(314, 24);
			this.textBox_Email.TabIndex = 5;
			this.textBox_Email.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Email_Validating);
			// 
			// label_Email
			// 
			this.label_Email.AutoSize = true;
			this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Email.Location = new System.Drawing.Point(145, 58);
			this.label_Email.Name = "label_Email";
			this.label_Email.Size = new System.Drawing.Size(45, 18);
			this.label_Email.TabIndex = 7;
			this.label_Email.Text = "Email";
			// 
			// textBox_PostCode
			// 
			this.textBox_PostCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_PostCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBox_PostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_PostCode.Location = new System.Drawing.Point(213, 144);
			this.textBox_PostCode.Name = "textBox_PostCode";
			this.textBox_PostCode.Size = new System.Drawing.Size(84, 24);
			this.textBox_PostCode.TabIndex = 7;
			this.textBox_PostCode.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_PostCode_Validating);
			// 
			// textBox_Address
			// 
			this.textBox_Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Address.Location = new System.Drawing.Point(213, 89);
			this.textBox_Address.Multiline = true;
			this.textBox_Address.Name = "textBox_Address";
			this.textBox_Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_Address.Size = new System.Drawing.Size(314, 50);
			this.textBox_Address.TabIndex = 6;
			this.textBox_Address.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Address_Validating);
			// 
			// textBox_CustomerName
			// 
			this.textBox_CustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_CustomerName.Location = new System.Drawing.Point(213, 30);
			this.textBox_CustomerName.MaximumSize = new System.Drawing.Size(500, 50);
			this.textBox_CustomerName.MaxLength = 70;
			this.textBox_CustomerName.MinimumSize = new System.Drawing.Size(314, 24);
			this.textBox_CustomerName.Name = "textBox_CustomerName";
			this.textBox_CustomerName.Size = new System.Drawing.Size(314, 24);
			this.textBox_CustomerName.TabIndex = 0;
			this.textBox_CustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_CustomerName_KeyDown);
			this.textBox_CustomerName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_CustomerName_Validating);
			// 
			// label_PostCode
			// 
			this.label_PostCode.AutoSize = true;
			this.label_PostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_PostCode.Location = new System.Drawing.Point(114, 144);
			this.label_PostCode.Name = "label_PostCode";
			this.label_PostCode.Size = new System.Drawing.Size(76, 18);
			this.label_PostCode.TabIndex = 3;
			this.label_PostCode.Text = "Post code";
			// 
			// label_Address
			// 
			this.label_Address.AutoSize = true;
			this.label_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Address.Location = new System.Drawing.Point(129, 91);
			this.label_Address.Name = "label_Address";
			this.label_Address.Size = new System.Drawing.Size(62, 18);
			this.label_Address.TabIndex = 2;
			this.label_Address.Text = "Address";
			// 
			// label_CustomerName
			// 
			this.label_CustomerName.AutoSize = true;
			this.label_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_CustomerName.Location = new System.Drawing.Point(75, 30);
			this.label_CustomerName.Name = "label_CustomerName";
			this.label_CustomerName.Size = new System.Drawing.Size(115, 18);
			this.label_CustomerName.TabIndex = 1;
			this.label_CustomerName.Text = "Customer name";
			// 
			// textBox_InvoiceNum
			// 
			this.textBox_InvoiceNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_InvoiceNum.Enabled = false;
			this.textBox_InvoiceNum.Location = new System.Drawing.Point(140, 97);
			this.textBox_InvoiceNum.MaximumSize = new System.Drawing.Size(140, 20);
			this.textBox_InvoiceNum.Name = "textBox_InvoiceNum";
			this.textBox_InvoiceNum.Size = new System.Drawing.Size(88, 20);
			this.textBox_InvoiceNum.TabIndex = 100;
			this.textBox_InvoiceNum.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// label_InvoiceNumber
			// 
			this.label_InvoiceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label_InvoiceNumber.AutoSize = true;
			this.label_InvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_InvoiceNumber.Location = new System.Drawing.Point(3, 96);
			this.label_InvoiceNumber.Name = "label_InvoiceNumber";
			this.label_InvoiceNumber.Size = new System.Drawing.Size(135, 18);
			this.label_InvoiceNumber.TabIndex = 8;
			this.label_InvoiceNumber.Text = "Invoice Number: ";
			// 
			// groupBox_ServicesDetails
			// 
			this.groupBox_ServicesDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_ServicesDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox_ServicesDetails.Controls.Add(this.label_chooseAservice);
			this.groupBox_ServicesDetails.Controls.Add(this.numericUpDown_vat);
			this.groupBox_ServicesDetails.Controls.Add(this.checkBox_Vat);
			this.groupBox_ServicesDetails.Controls.Add(this.button_CreateService);
			this.groupBox_ServicesDetails.Controls.Add(this.button_RemoveService);
			this.groupBox_ServicesDetails.Controls.Add(this.checkBox_Notes);
			this.groupBox_ServicesDetails.Controls.Add(this.numericUpDown_Discount);
			this.groupBox_ServicesDetails.Controls.Add(this.textBox_TotalPrice);
			this.groupBox_ServicesDetails.Controls.Add(this.textBox_InvoiceNotes);
			this.groupBox_ServicesDetails.Controls.Add(this.label_TotalPrice);
			this.groupBox_ServicesDetails.Controls.Add(this.checkBox_ApplyDiscount);
			this.groupBox_ServicesDetails.Controls.Add(this.textBox_CurrentPrice);
			this.groupBox_ServicesDetails.Controls.Add(this.label_CurrentPrice);
			this.groupBox_ServicesDetails.Controls.Add(this.listView_Services);
			this.groupBox_ServicesDetails.Controls.Add(this.button_ChooseService);
			this.groupBox_ServicesDetails.Controls.Add(this.comboBox_ChooseService);
			this.groupBox_ServicesDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_ServicesDetails.Location = new System.Drawing.Point(7, 324);
			this.groupBox_ServicesDetails.MinimumSize = new System.Drawing.Size(631, 276);
			this.groupBox_ServicesDetails.Name = "groupBox_ServicesDetails";
			this.groupBox_ServicesDetails.Size = new System.Drawing.Size(631, 294);
			this.groupBox_ServicesDetails.TabIndex = 7;
			this.groupBox_ServicesDetails.TabStop = false;
			this.groupBox_ServicesDetails.Text = "Service Details";
			// 
			// label_chooseAservice
			// 
			this.label_chooseAservice.AutoSize = true;
			this.label_chooseAservice.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label_chooseAservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_chooseAservice.Location = new System.Drawing.Point(12, 48);
			this.label_chooseAservice.Name = "label_chooseAservice";
			this.label_chooseAservice.Size = new System.Drawing.Size(124, 18);
			this.label_chooseAservice.TabIndex = 17;
			this.label_chooseAservice.Text = "Choose a service";
			// 
			// numericUpDown_vat
			// 
			this.numericUpDown_vat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown_vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown_vat.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_vat.Location = new System.Drawing.Point(573, 235);
			this.numericUpDown_vat.Name = "numericUpDown_vat";
			this.numericUpDown_vat.Size = new System.Drawing.Size(43, 24);
			this.numericUpDown_vat.TabIndex = 16;
			this.numericUpDown_vat.Visible = false;
			this.numericUpDown_vat.ValueChanged += new System.EventHandler(this.NumericUpDown_vat_ValueChanged);
			// 
			// checkBox_Vat
			// 
			this.checkBox_Vat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox_Vat.AutoSize = true;
			this.checkBox_Vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_Vat.Location = new System.Drawing.Point(424, 234);
			this.checkBox_Vat.Name = "checkBox_Vat";
			this.checkBox_Vat.Size = new System.Drawing.Size(120, 22);
			this.checkBox_Vat.TabIndex = 15;
			this.checkBox_Vat.Text = "Apply VAT (%)";
			this.checkBox_Vat.UseVisualStyleBackColor = true;
			this.checkBox_Vat.CheckedChanged += new System.EventHandler(this.CheckBox_Vat_CheckedChanged);
			// 
			// button_CreateService
			// 
			this.button_CreateService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CreateService.Location = new System.Drawing.Point(9, 78);
			this.button_CreateService.Name = "button_CreateService";
			this.button_CreateService.Size = new System.Drawing.Size(238, 28);
			this.button_CreateService.TabIndex = 14;
			this.button_CreateService.Text = "Create service";
			this.button_CreateService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_CreateService.UseVisualStyleBackColor = true;
			this.button_CreateService.Click += new System.EventHandler(this.Button_CreateService_Click);
			// 
			// button_RemoveService
			// 
			this.button_RemoveService.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button_RemoveService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_RemoveService.Location = new System.Drawing.Point(278, 86);
			this.button_RemoveService.Name = "button_RemoveService";
			this.button_RemoveService.Size = new System.Drawing.Size(84, 46);
			this.button_RemoveService.TabIndex = 13;
			this.button_RemoveService.Text = "Remove";
			this.button_RemoveService.UseVisualStyleBackColor = true;
			this.button_RemoveService.Click += new System.EventHandler(this.Button_RemoveService_Click);
			// 
			// checkBox_Notes
			// 
			this.checkBox_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBox_Notes.AutoSize = true;
			this.checkBox_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_Notes.Location = new System.Drawing.Point(9, 153);
			this.checkBox_Notes.Name = "checkBox_Notes";
			this.checkBox_Notes.Size = new System.Drawing.Size(96, 22);
			this.checkBox_Notes.TabIndex = 9;
			this.checkBox_Notes.Text = "Add Notes";
			this.checkBox_Notes.UseVisualStyleBackColor = true;
			this.checkBox_Notes.CheckedChanged += new System.EventHandler(this.CheckBox_Notes_CheckedChanged);
			// 
			// numericUpDown_Discount
			// 
			this.numericUpDown_Discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown_Discount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_Discount.Location = new System.Drawing.Point(573, 205);
			this.numericUpDown_Discount.Name = "numericUpDown_Discount";
			this.numericUpDown_Discount.Size = new System.Drawing.Size(43, 24);
			this.numericUpDown_Discount.TabIndex = 12;
			this.numericUpDown_Discount.Visible = false;
			this.numericUpDown_Discount.ValueChanged += new System.EventHandler(this.NumericUpDown_Discount_ValueChanged);
			// 
			// textBox_TotalPrice
			// 
			this.textBox_TotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_TotalPrice.Location = new System.Drawing.Point(523, 265);
			this.textBox_TotalPrice.Name = "textBox_TotalPrice";
			this.textBox_TotalPrice.ReadOnly = true;
			this.textBox_TotalPrice.Size = new System.Drawing.Size(94, 24);
			this.textBox_TotalPrice.TabIndex = 11;
			// 
			// textBox_InvoiceNotes
			// 
			this.textBox_InvoiceNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_InvoiceNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_InvoiceNotes.Location = new System.Drawing.Point(9, 181);
			this.textBox_InvoiceNotes.MaximumSize = new System.Drawing.Size(600, 92);
			this.textBox_InvoiceNotes.Multiline = true;
			this.textBox_InvoiceNotes.Name = "textBox_InvoiceNotes";
			this.textBox_InvoiceNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_InvoiceNotes.Size = new System.Drawing.Size(339, 92);
			this.textBox_InvoiceNotes.TabIndex = 10;
			this.textBox_InvoiceNotes.Visible = false;
			this.textBox_InvoiceNotes.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_InvoiceNotes_Validating);
			// 
			// label_TotalPrice
			// 
			this.label_TotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_TotalPrice.AutoSize = true;
			this.label_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_TotalPrice.Location = new System.Drawing.Point(422, 268);
			this.label_TotalPrice.Name = "label_TotalPrice";
			this.label_TotalPrice.Size = new System.Drawing.Size(79, 18);
			this.label_TotalPrice.TabIndex = 10;
			this.label_TotalPrice.Text = "Total Price";
			// 
			// checkBox_ApplyDiscount
			// 
			this.checkBox_ApplyDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox_ApplyDiscount.AutoSize = true;
			this.checkBox_ApplyDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_ApplyDiscount.Location = new System.Drawing.Point(424, 204);
			this.checkBox_ApplyDiscount.Name = "checkBox_ApplyDiscount";
			this.checkBox_ApplyDiscount.Size = new System.Drawing.Size(152, 22);
			this.checkBox_ApplyDiscount.TabIndex = 11;
			this.checkBox_ApplyDiscount.Text = "Apply Discount (%)";
			this.checkBox_ApplyDiscount.UseVisualStyleBackColor = true;
			this.checkBox_ApplyDiscount.CheckedChanged += new System.EventHandler(this.CheckBox_ApplyDiscount_CheckedChanged);
			// 
			// textBox_CurrentPrice
			// 
			this.textBox_CurrentPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_CurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_CurrentPrice.Location = new System.Drawing.Point(523, 169);
			this.textBox_CurrentPrice.Name = "textBox_CurrentPrice";
			this.textBox_CurrentPrice.ReadOnly = true;
			this.textBox_CurrentPrice.Size = new System.Drawing.Size(94, 24);
			this.textBox_CurrentPrice.TabIndex = 6;
			// 
			// label_CurrentPrice
			// 
			this.label_CurrentPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_CurrentPrice.AutoSize = true;
			this.label_CurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_CurrentPrice.Location = new System.Drawing.Point(422, 171);
			this.label_CurrentPrice.Name = "label_CurrentPrice";
			this.label_CurrentPrice.Size = new System.Drawing.Size(95, 18);
			this.label_CurrentPrice.TabIndex = 5;
			this.label_CurrentPrice.Text = "Current Price";
			// 
			// listView_Services
			// 
			this.listView_Services.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.listView_Services.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listView_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView_Services.GridLines = true;
			this.listView_Services.HideSelection = false;
			this.listView_Services.Location = new System.Drawing.Point(375, 33);
			this.listView_Services.Name = "listView_Services";
			this.listView_Services.Size = new System.Drawing.Size(250, 106);
			this.listView_Services.TabIndex = 4;
			this.listView_Services.UseCompatibleStateImageBehavior = false;
			this.listView_Services.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Service";
			this.columnHeader1.Width = 150;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Price";
			this.columnHeader2.Width = 96;
			// 
			// button_ChooseService
			// 
			this.button_ChooseService.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button_ChooseService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_ChooseService.Location = new System.Drawing.Point(278, 33);
			this.button_ChooseService.Name = "button_ChooseService";
			this.button_ChooseService.Size = new System.Drawing.Size(84, 46);
			this.button_ChooseService.TabIndex = 3;
			this.button_ChooseService.Text = "Add";
			this.button_ChooseService.UseVisualStyleBackColor = true;
			this.button_ChooseService.Click += new System.EventHandler(this.Button_ChooseService_Click);
			// 
			// comboBox_ChooseService
			// 
			this.comboBox_ChooseService.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
			this.comboBox_ChooseService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox_ChooseService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_ChooseService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_ChooseService.FormattingEnabled = true;
			this.comboBox_ChooseService.ItemHeight = 18;
			this.comboBox_ChooseService.Items.AddRange(new object[] {
            "Carpet Cleaning",
            "End of Tenancy",
            "Overn Cleaning",
            "Communal Cleaning",
            "Other"});
			this.comboBox_ChooseService.Location = new System.Drawing.Point(9, 44);
			this.comboBox_ChooseService.MaximumSize = new System.Drawing.Size(300, 0);
			this.comboBox_ChooseService.MaxLength = 238;
			this.comboBox_ChooseService.Name = "comboBox_ChooseService";
			this.comboBox_ChooseService.Size = new System.Drawing.Size(238, 26);
			this.comboBox_ChooseService.TabIndex = 8;
			this.comboBox_ChooseService.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ChooseService_SelectedIndexChanged);
			this.comboBox_ChooseService.DropDownClosed += new System.EventHandler(this.ComboBox_ChooseService_DropDownClosed);
			// 
			// groupBox_PaymentDetails
			// 
			this.groupBox_PaymentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_PaymentDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox_PaymentDetails.Controls.Add(this.label_ChequePayment);
			this.groupBox_PaymentDetails.Controls.Add(this.label_DirectTransfer);
			this.groupBox_PaymentDetails.Controls.Add(this.textBox_ChequePayment);
			this.groupBox_PaymentDetails.Controls.Add(this.textBox_PaymentTransfer);
			this.groupBox_PaymentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_PaymentDetails.Location = new System.Drawing.Point(6, 614);
			this.groupBox_PaymentDetails.MinimumSize = new System.Drawing.Size(631, 105);
			this.groupBox_PaymentDetails.Name = "groupBox_PaymentDetails";
			this.groupBox_PaymentDetails.Size = new System.Drawing.Size(631, 181);
			this.groupBox_PaymentDetails.TabIndex = 8;
			this.groupBox_PaymentDetails.TabStop = false;
			this.groupBox_PaymentDetails.Text = "Payment Details";
			// 
			// label_ChequePayment
			// 
			this.label_ChequePayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label_ChequePayment.AutoSize = true;
			this.label_ChequePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_ChequePayment.Location = new System.Drawing.Point(320, 29);
			this.label_ChequePayment.Name = "label_ChequePayment";
			this.label_ChequePayment.Size = new System.Drawing.Size(121, 18);
			this.label_ChequePayment.TabIndex = 13;
			this.label_ChequePayment.Text = "Cheque Payment";
			// 
			// label_DirectTransfer
			// 
			this.label_DirectTransfer.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label_DirectTransfer.AutoSize = true;
			this.label_DirectTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_DirectTransfer.Location = new System.Drawing.Point(39, 29);
			this.label_DirectTransfer.Name = "label_DirectTransfer";
			this.label_DirectTransfer.Size = new System.Drawing.Size(101, 18);
			this.label_DirectTransfer.TabIndex = 12;
			this.label_DirectTransfer.Text = "Direct transfer";
			// 
			// textBox_ChequePayment
			// 
			this.textBox_ChequePayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textBox_ChequePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_ChequePayment.Location = new System.Drawing.Point(323, 50);
			this.textBox_ChequePayment.Multiline = true;
			this.textBox_ChequePayment.Name = "textBox_ChequePayment";
			this.textBox_ChequePayment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_ChequePayment.Size = new System.Drawing.Size(267, 120);
			this.textBox_ChequePayment.TabIndex = 13;
			this.textBox_ChequePayment.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_ChequePayment_Validating);
			// 
			// textBox_PaymentTransfer
			// 
			this.textBox_PaymentTransfer.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textBox_PaymentTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_PaymentTransfer.Location = new System.Drawing.Point(37, 50);
			this.textBox_PaymentTransfer.Multiline = true;
			this.textBox_PaymentTransfer.Name = "textBox_PaymentTransfer";
			this.textBox_PaymentTransfer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_PaymentTransfer.Size = new System.Drawing.Size(258, 120);
			this.textBox_PaymentTransfer.TabIndex = 12;
			this.textBox_PaymentTransfer.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_PaymentTransfer_Validating);
			// 
			// groupBox_Confirmation
			// 
			this.groupBox_Confirmation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_Confirmation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox_Confirmation.Controls.Add(this.button_SavePDF);
			this.groupBox_Confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_Confirmation.Location = new System.Drawing.Point(6, 801);
			this.groupBox_Confirmation.MinimumSize = new System.Drawing.Size(631, 105);
			this.groupBox_Confirmation.Name = "groupBox_Confirmation";
			this.groupBox_Confirmation.Size = new System.Drawing.Size(631, 105);
			this.groupBox_Confirmation.TabIndex = 9;
			this.groupBox_Confirmation.TabStop = false;
			this.groupBox_Confirmation.Text = "Confirmation";
			// 
			// button_SavePDF
			// 
			this.button_SavePDF.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button_SavePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_SavePDF.Location = new System.Drawing.Point(247, 34);
			this.button_SavePDF.Name = "button_SavePDF";
			this.button_SavePDF.Size = new System.Drawing.Size(128, 53);
			this.button_SavePDF.TabIndex = 14;
			this.button_SavePDF.Text = "Save PDF";
			this.button_SavePDF.UseVisualStyleBackColor = true;
			this.button_SavePDF.Click += new System.EventHandler(this.Button_SavePDF_Click);
			// 
			// header
			// 
			this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.header.BackColor = System.Drawing.Color.Transparent;
			this.header.Controls.Add(this.label_Duedate);
			this.header.Controls.Add(this.label_Date);
			this.header.Controls.Add(this.dateTimePicker_DueDate);
			this.header.Controls.Add(this.dateTimePicker_date);
			this.header.Controls.Add(this.label_InvoiceNumber);
			this.header.Controls.Add(this.textBox_InvoiceNum);
			this.header.Controls.Add(this.pictureBox_Logo);
			this.header.Location = new System.Drawing.Point(8, 12);
			this.header.MinimumSize = new System.Drawing.Size(631, 120);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(631, 120);
			this.header.TabIndex = 101;
			// 
			// label_Duedate
			// 
			this.label_Duedate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Duedate.AutoSize = true;
			this.label_Duedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Duedate.Location = new System.Drawing.Point(454, 72);
			this.label_Duedate.Name = "label_Duedate";
			this.label_Duedate.Size = new System.Drawing.Size(75, 18);
			this.label_Duedate.TabIndex = 103;
			this.label_Duedate.Text = "Due date";
			// 
			// label_Date
			// 
			this.label_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Date.AutoSize = true;
			this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Date.Location = new System.Drawing.Point(453, 3);
			this.label_Date.Name = "label_Date";
			this.label_Date.Size = new System.Drawing.Size(43, 18);
			this.label_Date.TabIndex = 102;
			this.label_Date.Text = "Date";
			// 
			// dateTimePicker_DueDate
			// 
			this.dateTimePicker_DueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker_DueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker_DueDate.Location = new System.Drawing.Point(457, 93);
			this.dateTimePicker_DueDate.MaximumSize = new System.Drawing.Size(200, 24);
			this.dateTimePicker_DueDate.Name = "dateTimePicker_DueDate";
			this.dateTimePicker_DueDate.Size = new System.Drawing.Size(169, 24);
			this.dateTimePicker_DueDate.TabIndex = 101;
			this.dateTimePicker_DueDate.ValueChanged += new System.EventHandler(this.DateTimePicker_DueDate_ValueChanged);
			// 
			// pictureBox_Logo
			// 
			this.pictureBox_Logo.Image = global::Invoice_Application_Project.Properties.Resources.smIcon_Transparent_;
			this.pictureBox_Logo.Location = new System.Drawing.Point(8, 5);
			this.pictureBox_Logo.Name = "pictureBox_Logo";
			this.pictureBox_Logo.Size = new System.Drawing.Size(182, 80);
			this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_Logo.TabIndex = 5;
			this.pictureBox_Logo.TabStop = false;
			// 
			// Invoice_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(671, 661);
			this.Controls.Add(this.header);
			this.Controls.Add(this.groupBox_Confirmation);
			this.Controls.Add(this.groupBox_PaymentDetails);
			this.Controls.Add(this.groupBox_ServicesDetails);
			this.Controls.Add(this.groupBox_CustomerDetails);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(675, 700);
			this.Name = "Invoice_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Invoice Form";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Invoice_Form_FormClosing);
			this.Load += new System.EventHandler(this.Invoice_Form_Load);
			this.groupBox_CustomerDetails.ResumeLayout(false);
			this.groupBox_CustomerDetails.PerformLayout();
			this.groupBox_ServicesDetails.ResumeLayout(false);
			this.groupBox_ServicesDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Discount)).EndInit();
			this.groupBox_PaymentDetails.ResumeLayout(false);
			this.groupBox_PaymentDetails.PerformLayout();
			this.groupBox_Confirmation.ResumeLayout(false);
			this.header.ResumeLayout(false);
			this.header.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker_date;
		private System.Windows.Forms.PictureBox pictureBox_Logo;
		private System.Windows.Forms.GroupBox groupBox_CustomerDetails;
		private System.Windows.Forms.TextBox textBox_InvoiceNum;
		private System.Windows.Forms.Label label_InvoiceNumber;
		private System.Windows.Forms.GroupBox groupBox_ServicesDetails;
		private System.Windows.Forms.GroupBox groupBox_PaymentDetails;
		private System.Windows.Forms.GroupBox groupBox_Confirmation;
		private System.Windows.Forms.Button button_SavePDF;
		private System.Windows.Forms.TextBox textBox_PostCode;
		private System.Windows.Forms.TextBox textBox_Address;
		private System.Windows.Forms.TextBox textBox_CustomerName;
		private System.Windows.Forms.Label label_PostCode;
		private System.Windows.Forms.Label label_Address;
		private System.Windows.Forms.Label label_CustomerName;
		private System.Windows.Forms.ComboBox comboBox_ChooseService;
		private System.Windows.Forms.Button button_ChooseService;
		private System.Windows.Forms.ListView listView_Services;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.TextBox textBox_TotalPrice;
		private System.Windows.Forms.Label label_TotalPrice;
		private System.Windows.Forms.CheckBox checkBox_ApplyDiscount;
		private System.Windows.Forms.TextBox textBox_CurrentPrice;
		private System.Windows.Forms.Label label_CurrentPrice;
		private System.Windows.Forms.Label label_ChequePayment;
		private System.Windows.Forms.Label label_DirectTransfer;
		private System.Windows.Forms.TextBox textBox_ChequePayment;
		private System.Windows.Forms.TextBox textBox_PaymentTransfer;
		private System.Windows.Forms.TextBox textBox_InvoiceNotes;
		private System.Windows.Forms.NumericUpDown numericUpDown_Discount;
		private System.Windows.Forms.CheckBox checkBox_Notes;
		private System.Windows.Forms.Label label_Email;
		private System.Windows.Forms.TextBox textBox_Email;
		private System.Windows.Forms.Panel header;
		private System.Windows.Forms.Button button_RemoveService;
		private System.Windows.Forms.Label label_Duedate;
		private System.Windows.Forms.Label label_Date;
		private System.Windows.Forms.DateTimePicker dateTimePicker_DueDate;
		private System.Windows.Forms.Button button_CreateService;
		private System.Windows.Forms.CheckBox checkBox_Vat;
		private System.Windows.Forms.NumericUpDown numericUpDown_vat;
		private System.Windows.Forms.Button button_NewCustomer;
		private System.Windows.Forms.Label label_chooseAservice;
	}

	
}