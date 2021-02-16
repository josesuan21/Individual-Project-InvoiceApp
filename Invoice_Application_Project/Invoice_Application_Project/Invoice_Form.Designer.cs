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
			this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
			this.groupBox_CustomerDetails = new System.Windows.Forms.GroupBox();
			this.textBox_PostCode = new System.Windows.Forms.TextBox();
			this.textBox_Address = new System.Windows.Forms.TextBox();
			this.textBox_CustomerName = new System.Windows.Forms.TextBox();
			this.label_PostCode = new System.Windows.Forms.Label();
			this.label_Address = new System.Windows.Forms.Label();
			this.label_CustomerName = new System.Windows.Forms.Label();
			this.textBox_InvoiceNum = new System.Windows.Forms.TextBox();
			this.label_InvoiceNumber = new System.Windows.Forms.Label();
			this.groupBox_ServicesDetails = new System.Windows.Forms.GroupBox();
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
			this.groupBox_CustomerDetails.SuspendLayout();
			this.groupBox_ServicesDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Discount)).BeginInit();
			this.groupBox_PaymentDetails.SuspendLayout();
			this.groupBox_Confirmation.SuspendLayout();
			this.SuspendLayout();
			// 
			// dateTimePicker_date
			// 
			this.dateTimePicker_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker_date.Location = new System.Drawing.Point(472, 24);
			this.dateTimePicker_date.Name = "dateTimePicker_date";
			this.dateTimePicker_date.Size = new System.Drawing.Size(169, 24);
			this.dateTimePicker_date.TabIndex = 0;
			this.dateTimePicker_date.Value = new System.DateTime(2021, 2, 2, 1, 29, 55, 0);
			// 
			// pictureBox_Logo
			// 
			this.pictureBox_Logo.Image = global::Invoice_Application_Project.Properties.Resources.smIcon_Transparent_;
			this.pictureBox_Logo.Location = new System.Drawing.Point(12, 3);
			this.pictureBox_Logo.Name = "pictureBox_Logo";
			this.pictureBox_Logo.Size = new System.Drawing.Size(182, 80);
			this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_Logo.TabIndex = 5;
			this.pictureBox_Logo.TabStop = false;
			// 
			// groupBox_CustomerDetails
			// 
			this.groupBox_CustomerDetails.Controls.Add(this.textBox_PostCode);
			this.groupBox_CustomerDetails.Controls.Add(this.textBox_Address);
			this.groupBox_CustomerDetails.Controls.Add(this.textBox_CustomerName);
			this.groupBox_CustomerDetails.Controls.Add(this.label_PostCode);
			this.groupBox_CustomerDetails.Controls.Add(this.label_Address);
			this.groupBox_CustomerDetails.Controls.Add(this.label_CustomerName);
			this.groupBox_CustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_CustomerDetails.Location = new System.Drawing.Point(12, 135);
			this.groupBox_CustomerDetails.Name = "groupBox_CustomerDetails";
			this.groupBox_CustomerDetails.Size = new System.Drawing.Size(633, 171);
			this.groupBox_CustomerDetails.TabIndex = 6;
			this.groupBox_CustomerDetails.TabStop = false;
			this.groupBox_CustomerDetails.Text = "Customer Details";
			// 
			// textBox_PostCode
			// 
			this.textBox_PostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_PostCode.Location = new System.Drawing.Point(194, 132);
			this.textBox_PostCode.Name = "textBox_PostCode";
			this.textBox_PostCode.Size = new System.Drawing.Size(86, 24);
			this.textBox_PostCode.TabIndex = 6;
			// 
			// textBox_Address
			// 
			this.textBox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Address.Location = new System.Drawing.Point(194, 72);
			this.textBox_Address.Multiline = true;
			this.textBox_Address.Name = "textBox_Address";
			this.textBox_Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_Address.Size = new System.Drawing.Size(316, 50);
			this.textBox_Address.TabIndex = 5;
			// 
			// textBox_CustomerName
			// 
			this.textBox_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_CustomerName.Location = new System.Drawing.Point(194, 41);
			this.textBox_CustomerName.Name = "textBox_CustomerName";
			this.textBox_CustomerName.Size = new System.Drawing.Size(316, 24);
			this.textBox_CustomerName.TabIndex = 4;
			// 
			// label_PostCode
			// 
			this.label_PostCode.AutoSize = true;
			this.label_PostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_PostCode.Location = new System.Drawing.Point(95, 132);
			this.label_PostCode.Name = "label_PostCode";
			this.label_PostCode.Size = new System.Drawing.Size(76, 18);
			this.label_PostCode.TabIndex = 3;
			this.label_PostCode.Text = "Post code";
			// 
			// label_Address
			// 
			this.label_Address.AutoSize = true;
			this.label_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Address.Location = new System.Drawing.Point(109, 72);
			this.label_Address.Name = "label_Address";
			this.label_Address.Size = new System.Drawing.Size(62, 18);
			this.label_Address.TabIndex = 2;
			this.label_Address.Text = "Address";
			// 
			// label_CustomerName
			// 
			this.label_CustomerName.AutoSize = true;
			this.label_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_CustomerName.Location = new System.Drawing.Point(56, 41);
			this.label_CustomerName.Name = "label_CustomerName";
			this.label_CustomerName.Size = new System.Drawing.Size(115, 18);
			this.label_CustomerName.TabIndex = 1;
			this.label_CustomerName.Text = "Customer name";
			// 
			// textBox_InvoiceNum
			// 
			this.textBox_InvoiceNum.Location = new System.Drawing.Point(152, 106);
			this.textBox_InvoiceNum.Name = "textBox_InvoiceNum";
			this.textBox_InvoiceNum.Size = new System.Drawing.Size(115, 20);
			this.textBox_InvoiceNum.TabIndex = 7;
			this.textBox_InvoiceNum.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// label_InvoiceNumber
			// 
			this.label_InvoiceNumber.AutoSize = true;
			this.label_InvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_InvoiceNumber.Location = new System.Drawing.Point(15, 105);
			this.label_InvoiceNumber.Name = "label_InvoiceNumber";
			this.label_InvoiceNumber.Size = new System.Drawing.Size(135, 18);
			this.label_InvoiceNumber.TabIndex = 8;
			this.label_InvoiceNumber.Text = "Invoice Number: ";
			// 
			// groupBox_ServicesDetails
			// 
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
			this.groupBox_ServicesDetails.Location = new System.Drawing.Point(12, 318);
			this.groupBox_ServicesDetails.Name = "groupBox_ServicesDetails";
			this.groupBox_ServicesDetails.Size = new System.Drawing.Size(633, 276);
			this.groupBox_ServicesDetails.TabIndex = 7;
			this.groupBox_ServicesDetails.TabStop = false;
			this.groupBox_ServicesDetails.Text = "Service Details";
			// 
			// checkBox_Notes
			// 
			this.checkBox_Notes.AutoSize = true;
			this.checkBox_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_Notes.Location = new System.Drawing.Point(24, 144);
			this.checkBox_Notes.Name = "checkBox_Notes";
			this.checkBox_Notes.Size = new System.Drawing.Size(96, 22);
			this.checkBox_Notes.TabIndex = 14;
			this.checkBox_Notes.Text = "Add Notes";
			this.checkBox_Notes.UseVisualStyleBackColor = true;
			this.checkBox_Notes.CheckedChanged += new System.EventHandler(this.CheckBox_Notes_CheckedChanged);
			// 
			// numericUpDown_Discount
			// 
			this.numericUpDown_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown_Discount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_Discount.Location = new System.Drawing.Point(524, 203);
			this.numericUpDown_Discount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_Discount.Name = "numericUpDown_Discount";
			this.numericUpDown_Discount.Size = new System.Drawing.Size(43, 24);
			this.numericUpDown_Discount.TabIndex = 12;
			this.numericUpDown_Discount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_Discount.Visible = false;
			// 
			// textBox_TotalPrice
			// 
			this.textBox_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_TotalPrice.Location = new System.Drawing.Point(474, 235);
			this.textBox_TotalPrice.Name = "textBox_TotalPrice";
			this.textBox_TotalPrice.ReadOnly = true;
			this.textBox_TotalPrice.Size = new System.Drawing.Size(94, 24);
			this.textBox_TotalPrice.TabIndex = 11;
			// 
			// textBox_InvoiceNotes
			// 
			this.textBox_InvoiceNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_InvoiceNotes.Location = new System.Drawing.Point(24, 169);
			this.textBox_InvoiceNotes.Multiline = true;
			this.textBox_InvoiceNotes.Name = "textBox_InvoiceNotes";
			this.textBox_InvoiceNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_InvoiceNotes.Size = new System.Drawing.Size(321, 92);
			this.textBox_InvoiceNotes.TabIndex = 0;
			this.textBox_InvoiceNotes.Visible = false;
			// 
			// label_TotalPrice
			// 
			this.label_TotalPrice.AutoSize = true;
			this.label_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_TotalPrice.Location = new System.Drawing.Point(373, 238);
			this.label_TotalPrice.Name = "label_TotalPrice";
			this.label_TotalPrice.Size = new System.Drawing.Size(79, 18);
			this.label_TotalPrice.TabIndex = 10;
			this.label_TotalPrice.Text = "Total Price";
			// 
			// checkBox_ApplyDiscount
			// 
			this.checkBox_ApplyDiscount.AutoSize = true;
			this.checkBox_ApplyDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_ApplyDiscount.Location = new System.Drawing.Point(375, 203);
			this.checkBox_ApplyDiscount.Name = "checkBox_ApplyDiscount";
			this.checkBox_ApplyDiscount.Size = new System.Drawing.Size(152, 22);
			this.checkBox_ApplyDiscount.TabIndex = 9;
			this.checkBox_ApplyDiscount.Text = "Apply Discount (%)";
			this.checkBox_ApplyDiscount.UseVisualStyleBackColor = true;
			this.checkBox_ApplyDiscount.CheckedChanged += new System.EventHandler(this.CheckBox_ApplyDiscount_CheckedChanged);
			// 
			// textBox_CurrentPrice
			// 
			this.textBox_CurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_CurrentPrice.Location = new System.Drawing.Point(474, 167);
			this.textBox_CurrentPrice.Name = "textBox_CurrentPrice";
			this.textBox_CurrentPrice.ReadOnly = true;
			this.textBox_CurrentPrice.Size = new System.Drawing.Size(94, 24);
			this.textBox_CurrentPrice.TabIndex = 6;
			// 
			// label_CurrentPrice
			// 
			this.label_CurrentPrice.AutoSize = true;
			this.label_CurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_CurrentPrice.Location = new System.Drawing.Point(373, 168);
			this.label_CurrentPrice.Name = "label_CurrentPrice";
			this.label_CurrentPrice.Size = new System.Drawing.Size(95, 18);
			this.label_CurrentPrice.TabIndex = 5;
			this.label_CurrentPrice.Text = "Current Price";
			// 
			// listView_Services
			// 
			this.listView_Services.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listView_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView_Services.HideSelection = false;
			this.listView_Services.Location = new System.Drawing.Point(394, 33);
			this.listView_Services.Name = "listView_Services";
			this.listView_Services.Size = new System.Drawing.Size(174, 106);
			this.listView_Services.TabIndex = 4;
			this.listView_Services.UseCompatibleStateImageBehavior = false;
			this.listView_Services.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Service";
			this.columnHeader1.Width = 90;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Price";
			// 
			// button_ChooseService
			// 
			this.button_ChooseService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_ChooseService.Location = new System.Drawing.Point(272, 33);
			this.button_ChooseService.Name = "button_ChooseService";
			this.button_ChooseService.Size = new System.Drawing.Size(84, 46);
			this.button_ChooseService.TabIndex = 3;
			this.button_ChooseService.Text = "Add";
			this.button_ChooseService.UseVisualStyleBackColor = true;
			// 
			// comboBox_ChooseService
			// 
			this.comboBox_ChooseService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_ChooseService.FormattingEnabled = true;
			this.comboBox_ChooseService.ItemHeight = 18;
			this.comboBox_ChooseService.Items.AddRange(new object[] {
            "Carpet Cleaning",
            "End of Tenancy",
            "Overn Cleaning",
            "Communal Cleaning",
            "Other"});
			this.comboBox_ChooseService.Location = new System.Drawing.Point(87, 44);
			this.comboBox_ChooseService.Name = "comboBox_ChooseService";
			this.comboBox_ChooseService.Size = new System.Drawing.Size(153, 26);
			this.comboBox_ChooseService.TabIndex = 2;
			this.comboBox_ChooseService.Text = "Choose service";
			// 
			// groupBox_PaymentDetails
			// 
			this.groupBox_PaymentDetails.Controls.Add(this.label_ChequePayment);
			this.groupBox_PaymentDetails.Controls.Add(this.label_DirectTransfer);
			this.groupBox_PaymentDetails.Controls.Add(this.textBox_ChequePayment);
			this.groupBox_PaymentDetails.Controls.Add(this.textBox_PaymentTransfer);
			this.groupBox_PaymentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_PaymentDetails.Location = new System.Drawing.Point(12, 613);
			this.groupBox_PaymentDetails.Name = "groupBox_PaymentDetails";
			this.groupBox_PaymentDetails.Size = new System.Drawing.Size(633, 181);
			this.groupBox_PaymentDetails.TabIndex = 8;
			this.groupBox_PaymentDetails.TabStop = false;
			this.groupBox_PaymentDetails.Text = "Payment Details";
			// 
			// label_ChequePayment
			// 
			this.label_ChequePayment.AutoSize = true;
			this.label_ChequePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_ChequePayment.Location = new System.Drawing.Point(322, 29);
			this.label_ChequePayment.Name = "label_ChequePayment";
			this.label_ChequePayment.Size = new System.Drawing.Size(121, 18);
			this.label_ChequePayment.TabIndex = 13;
			this.label_ChequePayment.Text = "Cheque Payment";
			// 
			// label_DirectTransfer
			// 
			this.label_DirectTransfer.AutoSize = true;
			this.label_DirectTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_DirectTransfer.Location = new System.Drawing.Point(36, 29);
			this.label_DirectTransfer.Name = "label_DirectTransfer";
			this.label_DirectTransfer.Size = new System.Drawing.Size(101, 18);
			this.label_DirectTransfer.TabIndex = 12;
			this.label_DirectTransfer.Text = "Direct transfer";
			// 
			// textBox_ChequePayment
			// 
			this.textBox_ChequePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_ChequePayment.Location = new System.Drawing.Point(323, 50);
			this.textBox_ChequePayment.Multiline = true;
			this.textBox_ChequePayment.Name = "textBox_ChequePayment";
			this.textBox_ChequePayment.Size = new System.Drawing.Size(267, 110);
			this.textBox_ChequePayment.TabIndex = 2;
			// 
			// textBox_PaymentTransfer
			// 
			this.textBox_PaymentTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_PaymentTransfer.Location = new System.Drawing.Point(37, 50);
			this.textBox_PaymentTransfer.Multiline = true;
			this.textBox_PaymentTransfer.Name = "textBox_PaymentTransfer";
			this.textBox_PaymentTransfer.Size = new System.Drawing.Size(258, 110);
			this.textBox_PaymentTransfer.TabIndex = 1;
			// 
			// groupBox_Confirmation
			// 
			this.groupBox_Confirmation.Controls.Add(this.button_SavePDF);
			this.groupBox_Confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_Confirmation.Location = new System.Drawing.Point(12, 800);
			this.groupBox_Confirmation.Name = "groupBox_Confirmation";
			this.groupBox_Confirmation.Size = new System.Drawing.Size(633, 114);
			this.groupBox_Confirmation.TabIndex = 9;
			this.groupBox_Confirmation.TabStop = false;
			this.groupBox_Confirmation.Text = "Confirmation";
			// 
			// button_SavePDF
			// 
			this.button_SavePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_SavePDF.Location = new System.Drawing.Point(248, 32);
			this.button_SavePDF.Name = "button_SavePDF";
			this.button_SavePDF.Size = new System.Drawing.Size(128, 50);
			this.button_SavePDF.TabIndex = 0;
			this.button_SavePDF.Text = "Save PDF";
			this.button_SavePDF.UseVisualStyleBackColor = true;
			this.button_SavePDF.Click += new System.EventHandler(this.Button_SavePDF_Click);
			// 
			// Invoice_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(663, 944);
			this.Controls.Add(this.groupBox_Confirmation);
			this.Controls.Add(this.groupBox_PaymentDetails);
			this.Controls.Add(this.groupBox_ServicesDetails);
			this.Controls.Add(this.label_InvoiceNumber);
			this.Controls.Add(this.textBox_InvoiceNum);
			this.Controls.Add(this.groupBox_CustomerDetails);
			this.Controls.Add(this.pictureBox_Logo);
			this.Controls.Add(this.dateTimePicker_date);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Invoice_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Invoice Form";
			this.Load += new System.EventHandler(this.Invoice_Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
			this.groupBox_CustomerDetails.ResumeLayout(false);
			this.groupBox_CustomerDetails.PerformLayout();
			this.groupBox_ServicesDetails.ResumeLayout(false);
			this.groupBox_ServicesDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Discount)).EndInit();
			this.groupBox_PaymentDetails.ResumeLayout(false);
			this.groupBox_PaymentDetails.PerformLayout();
			this.groupBox_Confirmation.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

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
	}
}