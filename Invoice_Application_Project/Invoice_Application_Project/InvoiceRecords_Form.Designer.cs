namespace Invoice_Application_Project
{
	partial class InvoiceRecords_Form
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label invoiceRecordIdLabel;
			System.Windows.Forms.Label discountGivenLabel;
			System.Windows.Forms.Label totalPriceLabel;
			System.Windows.Forms.Label notesLabel;
			System.Windows.Forms.Label dateLabel;
			System.Windows.Forms.Label duedateLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceRecords_Form));
			this.label_InvoiceRecords = new System.Windows.Forms.Label();
			this.invoiceRecordDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.invoiceRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.invoiceDatabaseDataSet1 = new Invoice_Application_Project.InvoiceDatabaseDataSet1();
			this.button_Back = new System.Windows.Forms.Button();
			this.label_Help = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.invoiceRecordIdTextBox = new System.Windows.Forms.TextBox();
			this.discountGivenTextBox = new System.Windows.Forms.TextBox();
			this.totalPriceTextBox = new System.Windows.Forms.TextBox();
			this.notesTextBox = new System.Windows.Forms.TextBox();
			this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.duedateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.button_backwithpoint = new System.Windows.Forms.Button();
			this.button_Next = new System.Windows.Forms.Button();
			this.label_RecordsDetails = new System.Windows.Forms.Label();
			this.textBox_search = new System.Windows.Forms.TextBox();
			this.invoiceRecordTableAdapter = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.InvoiceRecordTableAdapter();
			this.tableAdapterManager = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			invoiceRecordIdLabel = new System.Windows.Forms.Label();
			discountGivenLabel = new System.Windows.Forms.Label();
			totalPriceLabel = new System.Windows.Forms.Label();
			notesLabel = new System.Windows.Forms.Label();
			dateLabel = new System.Windows.Forms.Label();
			duedateLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.invoiceRecordDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceRecordBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// invoiceRecordIdLabel
			// 
			invoiceRecordIdLabel.AutoSize = true;
			invoiceRecordIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			invoiceRecordIdLabel.Location = new System.Drawing.Point(38, 16);
			invoiceRecordIdLabel.Name = "invoiceRecordIdLabel";
			invoiceRecordIdLabel.Size = new System.Drawing.Size(80, 18);
			invoiceRecordIdLabel.TabIndex = 7;
			invoiceRecordIdLabel.Text = "Invoice ID: ";
			// 
			// discountGivenLabel
			// 
			discountGivenLabel.AutoSize = true;
			discountGivenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			discountGivenLabel.Location = new System.Drawing.Point(5, 50);
			discountGivenLabel.Name = "discountGivenLabel";
			discountGivenLabel.Size = new System.Drawing.Size(113, 18);
			discountGivenLabel.TabIndex = 9;
			discountGivenLabel.Text = "Discount Given:";
			// 
			// totalPriceLabel
			// 
			totalPriceLabel.AutoSize = true;
			totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			totalPriceLabel.Location = new System.Drawing.Point(35, 83);
			totalPriceLabel.Name = "totalPriceLabel";
			totalPriceLabel.Size = new System.Drawing.Size(83, 18);
			totalPriceLabel.TabIndex = 11;
			totalPriceLabel.Text = "Total Price:";
			// 
			// notesLabel
			// 
			notesLabel.AutoSize = true;
			notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			notesLabel.Location = new System.Drawing.Point(66, 118);
			notesLabel.Name = "notesLabel";
			notesLabel.Size = new System.Drawing.Size(52, 18);
			notesLabel.TabIndex = 13;
			notesLabel.Text = "Notes:";
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dateLabel.Location = new System.Drawing.Point(75, 191);
			dateLabel.Name = "dateLabel";
			dateLabel.Size = new System.Drawing.Size(43, 18);
			dateLabel.TabIndex = 15;
			dateLabel.Text = "Date:";
			// 
			// duedateLabel
			// 
			duedateLabel.AutoSize = true;
			duedateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			duedateLabel.Location = new System.Drawing.Point(47, 227);
			duedateLabel.Name = "duedateLabel";
			duedateLabel.Size = new System.Drawing.Size(71, 18);
			duedateLabel.TabIndex = 17;
			duedateLabel.Text = "Due date:";
			// 
			// label_InvoiceRecords
			// 
			this.label_InvoiceRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_InvoiceRecords.AutoSize = true;
			this.label_InvoiceRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_InvoiceRecords.Location = new System.Drawing.Point(631, 58);
			this.label_InvoiceRecords.Name = "label_InvoiceRecords";
			this.label_InvoiceRecords.Size = new System.Drawing.Size(161, 24);
			this.label_InvoiceRecords.TabIndex = 4;
			this.label_InvoiceRecords.Text = "Invoice Records";
			// 
			// invoiceRecordDataGridView
			// 
			this.invoiceRecordDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.invoiceRecordDataGridView.AutoGenerateColumns = false;
			this.invoiceRecordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.invoiceRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.invoiceRecordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.invoiceRecordDataGridView.DataSource = this.invoiceRecordBindingSource;
			this.invoiceRecordDataGridView.Location = new System.Drawing.Point(2, 7);
			this.invoiceRecordDataGridView.Name = "invoiceRecordDataGridView";
			this.invoiceRecordDataGridView.ReadOnly = true;
			this.invoiceRecordDataGridView.Size = new System.Drawing.Size(704, 217);
			this.invoiceRecordDataGridView.TabIndex = 5;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "invoiceRecordId";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "discountGiven";
			this.dataGridViewTextBoxColumn2.HeaderText = "Discount";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "totalPrice";
			this.dataGridViewTextBoxColumn3.HeaderText = "Total Price";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "notes";
			this.dataGridViewTextBoxColumn4.HeaderText = "Notes";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "date";
			this.dataGridViewTextBoxColumn5.HeaderText = "Date";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "duedate";
			this.dataGridViewTextBoxColumn6.HeaderText = "Due date";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// invoiceRecordBindingSource
			// 
			this.invoiceRecordBindingSource.DataMember = "InvoiceRecord";
			this.invoiceRecordBindingSource.DataSource = this.invoiceDatabaseDataSet1;
			// 
			// invoiceDatabaseDataSet1
			// 
			this.invoiceDatabaseDataSet1.DataSetName = "InvoiceDatabaseDataSet1";
			this.invoiceDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// button_Back
			// 
			this.button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Back.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Back.Location = new System.Drawing.Point(12, 433);
			this.button_Back.Name = "button_Back";
			this.button_Back.Size = new System.Drawing.Size(103, 32);
			this.button_Back.TabIndex = 6;
			this.button_Back.Text = "Other Records";
			this.button_Back.UseVisualStyleBackColor = false;
			this.button_Back.Click += new System.EventHandler(this.Button_Back_Click);
			// 
			// label_Help
			// 
			this.label_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Help.AutoSize = true;
			this.label_Help.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_Help.Cursor = System.Windows.Forms.Cursors.Help;
			this.label_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Help.Location = new System.Drawing.Point(1060, 9);
			this.label_Help.Name = "label_Help";
			this.label_Help.Size = new System.Drawing.Size(48, 22);
			this.label_Help.TabIndex = 7;
			this.label_Help.Text = "Help";
			this.toolTip1.SetToolTip(this.label_Help, " To Navigate records\r\n1. Use the back and next buttons\r\n\r\nTo Search\r\n1. Click the" +
        " search box and type the invoice number\r\n \r\n\r\n\r\n");
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 10000;
			this.toolTip1.InitialDelay = 100;
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ReshowDelay = 100;
			this.toolTip1.ShowAlways = true;
			this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "How to use";
			// 
			// invoiceRecordIdTextBox
			// 
			this.invoiceRecordIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceRecordBindingSource, "invoiceRecordId", true));
			this.invoiceRecordIdTextBox.Enabled = false;
			this.invoiceRecordIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.invoiceRecordIdTextBox.Location = new System.Drawing.Point(124, 13);
			this.invoiceRecordIdTextBox.Name = "invoiceRecordIdTextBox";
			this.invoiceRecordIdTextBox.ReadOnly = true;
			this.invoiceRecordIdTextBox.Size = new System.Drawing.Size(200, 24);
			this.invoiceRecordIdTextBox.TabIndex = 8;
			// 
			// discountGivenTextBox
			// 
			this.discountGivenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceRecordBindingSource, "discountGiven", true));
			this.discountGivenTextBox.Enabled = false;
			this.discountGivenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.discountGivenTextBox.Location = new System.Drawing.Point(124, 47);
			this.discountGivenTextBox.Name = "discountGivenTextBox";
			this.discountGivenTextBox.Size = new System.Drawing.Size(76, 24);
			this.discountGivenTextBox.TabIndex = 10;
			// 
			// totalPriceTextBox
			// 
			this.totalPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceRecordBindingSource, "totalPrice", true));
			this.totalPriceTextBox.Enabled = false;
			this.totalPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalPriceTextBox.Location = new System.Drawing.Point(124, 80);
			this.totalPriceTextBox.Name = "totalPriceTextBox";
			this.totalPriceTextBox.Size = new System.Drawing.Size(163, 24);
			this.totalPriceTextBox.TabIndex = 12;
			// 
			// notesTextBox
			// 
			this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceRecordBindingSource, "notes", true));
			this.notesTextBox.Enabled = false;
			this.notesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.notesTextBox.Location = new System.Drawing.Point(124, 115);
			this.notesTextBox.Multiline = true;
			this.notesTextBox.Name = "notesTextBox";
			this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.notesTextBox.Size = new System.Drawing.Size(200, 65);
			this.notesTextBox.TabIndex = 14;
			// 
			// dateDateTimePicker
			// 
			this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceRecordBindingSource, "date", true));
			this.dateDateTimePicker.Enabled = false;
			this.dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateDateTimePicker.Location = new System.Drawing.Point(124, 186);
			this.dateDateTimePicker.Name = "dateDateTimePicker";
			this.dateDateTimePicker.Size = new System.Drawing.Size(163, 24);
			this.dateDateTimePicker.TabIndex = 16;
			// 
			// duedateDateTimePicker
			// 
			this.duedateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceRecordBindingSource, "duedate", true));
			this.duedateDateTimePicker.Enabled = false;
			this.duedateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.duedateDateTimePicker.Location = new System.Drawing.Point(124, 222);
			this.duedateDateTimePicker.Name = "duedateDateTimePicker";
			this.duedateDateTimePicker.Size = new System.Drawing.Size(163, 24);
			this.duedateDateTimePicker.TabIndex = 18;
			// 
			// button_backwithpoint
			// 
			this.button_backwithpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_backwithpoint.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.button_backwithpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_backwithpoint.Location = new System.Drawing.Point(1, 226);
			this.button_backwithpoint.Name = "button_backwithpoint";
			this.button_backwithpoint.Size = new System.Drawing.Size(92, 40);
			this.button_backwithpoint.TabIndex = 31;
			this.button_backwithpoint.Text = "<- Back";
			this.button_backwithpoint.UseVisualStyleBackColor = false;
			this.button_backwithpoint.Click += new System.EventHandler(this.Button_backwithpoint_Click);
			// 
			// button_Next
			// 
			this.button_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_Next.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.button_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Next.Location = new System.Drawing.Point(616, 226);
			this.button_Next.Name = "button_Next";
			this.button_Next.Size = new System.Drawing.Size(92, 40);
			this.button_Next.TabIndex = 30;
			this.button_Next.Text = "Next ->";
			this.button_Next.UseVisualStyleBackColor = false;
			this.button_Next.Click += new System.EventHandler(this.Button_Next_Click);
			// 
			// label_RecordsDetails
			// 
			this.label_RecordsDetails.AutoSize = true;
			this.label_RecordsDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_RecordsDetails.Location = new System.Drawing.Point(129, 58);
			this.label_RecordsDetails.Name = "label_RecordsDetails";
			this.label_RecordsDetails.Size = new System.Drawing.Size(145, 24);
			this.label_RecordsDetails.TabIndex = 36;
			this.label_RecordsDetails.Text = "Invoice Details";
			// 
			// textBox_search
			// 
			this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_search.Location = new System.Drawing.Point(932, 59);
			this.textBox_search.Name = "textBox_search";
			this.textBox_search.Size = new System.Drawing.Size(153, 24);
			this.textBox_search.TabIndex = 37;
			this.textBox_search.Text = "🔍 Search Invoice No";
			this.textBox_search.Click += new System.EventHandler(this.TextBox_search_Click);
			this.textBox_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_search_MouseClick);
			this.textBox_search.TextChanged += new System.EventHandler(this.TextBox_search_TextChanged);
			this.textBox_search.Leave += new System.EventHandler(this.TextBox_search_Leave);
			// 
			// invoiceRecordTableAdapter
			// 
			this.invoiceRecordTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CustomerTableAdapter = null;
			this.tableAdapterManager.InvoiceRecordTableAdapter = this.invoiceRecordTableAdapter;
			this.tableAdapterManager.Old_ServiceRecordTableAdapter = null;
			this.tableAdapterManager.PaymentDetailsTableAdapter = null;
			this.tableAdapterManager.ServiceTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.invoiceRecordIdTextBox);
			this.panel1.Controls.Add(this.duedateDateTimePicker);
			this.panel1.Controls.Add(duedateLabel);
			this.panel1.Controls.Add(this.dateDateTimePicker);
			this.panel1.Controls.Add(dateLabel);
			this.panel1.Controls.Add(invoiceRecordIdLabel);
			this.panel1.Controls.Add(this.notesTextBox);
			this.panel1.Controls.Add(notesLabel);
			this.panel1.Controls.Add(discountGivenLabel);
			this.panel1.Controls.Add(this.totalPriceTextBox);
			this.panel1.Controls.Add(this.discountGivenTextBox);
			this.panel1.Controls.Add(totalPriceLabel);
			this.panel1.Location = new System.Drawing.Point(29, 88);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(337, 271);
			this.panel1.TabIndex = 38;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel2.Controls.Add(this.invoiceRecordDataGridView);
			this.panel2.Controls.Add(this.button_backwithpoint);
			this.panel2.Controls.Add(this.button_Next);
			this.panel2.Location = new System.Drawing.Point(376, 88);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(709, 271);
			this.panel2.TabIndex = 39;
			// 
			// InvoiceRecords_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1120, 477);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox_search);
			this.Controls.Add(this.label_RecordsDetails);
			this.Controls.Add(this.label_Help);
			this.Controls.Add(this.button_Back);
			this.Controls.Add(this.label_InvoiceRecords);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1136, 516);
			this.Name = "InvoiceRecords_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Invoice Records";
			this.Load += new System.EventHandler(this.InvoiceRecords_Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.invoiceRecordDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceRecordBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_InvoiceRecords;
		private InvoiceDatabaseDataSet1 invoiceDatabaseDataSet1;
		private System.Windows.Forms.BindingSource invoiceRecordBindingSource;
		private InvoiceDatabaseDataSet1TableAdapters.InvoiceRecordTableAdapter invoiceRecordTableAdapter;
		private InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView invoiceRecordDataGridView;
		private System.Windows.Forms.Button button_Back;
		private System.Windows.Forms.Label label_Help;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.TextBox invoiceRecordIdTextBox;
		private System.Windows.Forms.TextBox discountGivenTextBox;
		private System.Windows.Forms.TextBox totalPriceTextBox;
		private System.Windows.Forms.TextBox notesTextBox;
		private System.Windows.Forms.DateTimePicker dateDateTimePicker;
		private System.Windows.Forms.DateTimePicker duedateDateTimePicker;
		private System.Windows.Forms.Button button_backwithpoint;
		private System.Windows.Forms.Button button_Next;
		private System.Windows.Forms.Label label_RecordsDetails;
		private System.Windows.Forms.TextBox textBox_search;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}