namespace Invoice_Application_Project
{
	partial class ServiceChosen_Form
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
			System.Windows.Forms.Label idLabel;
			System.Windows.Forms.Label service_NameLabel;
			System.Windows.Forms.Label customer_ID___NameLabel;
			System.Windows.Forms.Label invoice_IdLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceChosen_Form));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button_backwithpoint = new System.Windows.Forms.Button();
			this.button_Next = new System.Windows.Forms.Button();
			this.textBox_search = new System.Windows.Forms.TextBox();
			this.button_Back = new System.Windows.Forms.Button();
			this.label_Help = new System.Windows.Forms.Label();
			this.serviceChosenInnerJoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.serviceChosen_InnerJoinDataGridView = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerIDNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.invoiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serviceChosen_InnerJoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.invoiceDatabaseDataSet1 = new Invoice_Application_Project.InvoiceDatabaseDataSet1();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.service_NameTextBox = new System.Windows.Forms.TextBox();
			this.customer_ID___NameTextBox = new System.Windows.Forms.TextBox();
			this.invoice_IdTextBox = new System.Windows.Forms.TextBox();
			this.serviceChosen_InnerJoinTableAdapter = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.ServiceChosen_InnerJoinTableAdapter();
			this.tableAdapterManager = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager();
			idLabel = new System.Windows.Forms.Label();
			service_NameLabel = new System.Windows.Forms.Label();
			customer_ID___NameLabel = new System.Windows.Forms.Label();
			invoice_IdLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.serviceChosenInnerJoinBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceChosen_InnerJoinDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceChosen_InnerJoinBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// idLabel
			// 
			idLabel.AutoSize = true;
			idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			idLabel.Location = new System.Drawing.Point(36, 111);
			idLabel.Name = "idLabel";
			idLabel.Size = new System.Drawing.Size(23, 18);
			idLabel.TabIndex = 40;
			idLabel.Text = "Id:";
			// 
			// service_NameLabel
			// 
			service_NameLabel.AutoSize = true;
			service_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			service_NameLabel.Location = new System.Drawing.Point(36, 146);
			service_NameLabel.Name = "service_NameLabel";
			service_NameLabel.Size = new System.Drawing.Size(105, 18);
			service_NameLabel.TabIndex = 42;
			service_NameLabel.Text = "Service Name:";
			// 
			// customer_ID___NameLabel
			// 
			customer_ID___NameLabel.AutoSize = true;
			customer_ID___NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			customer_ID___NameLabel.Location = new System.Drawing.Point(36, 186);
			customer_ID___NameLabel.Name = "customer_ID___NameLabel";
			customer_ID___NameLabel.Size = new System.Drawing.Size(148, 18);
			customer_ID___NameLabel.TabIndex = 44;
			customer_ID___NameLabel.Text = "Customer ID / Name:";
			// 
			// invoice_IdLabel
			// 
			invoice_IdLabel.AutoSize = true;
			invoice_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			invoice_IdLabel.Location = new System.Drawing.Point(36, 255);
			invoice_IdLabel.Name = "invoice_IdLabel";
			invoice_IdLabel.Size = new System.Drawing.Size(73, 18);
			invoice_IdLabel.TabIndex = 46;
			invoice_IdLabel.Text = "Invoice Id:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(517, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(242, 24);
			this.label1.TabIndex = 10;
			this.label1.Text = "Service Chosen Records";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(122, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 11;
			this.label2.Text = "Details";
			// 
			// button_backwithpoint
			// 
			this.button_backwithpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_backwithpoint.Location = new System.Drawing.Point(340, 318);
			this.button_backwithpoint.Name = "button_backwithpoint";
			this.button_backwithpoint.Size = new System.Drawing.Size(92, 40);
			this.button_backwithpoint.TabIndex = 20;
			this.button_backwithpoint.Text = "<- Back";
			this.button_backwithpoint.UseVisualStyleBackColor = true;
			this.button_backwithpoint.Click += new System.EventHandler(this.Button_backwithpoint_Click);
			// 
			// button_Next
			// 
			this.button_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Next.Location = new System.Drawing.Point(840, 318);
			this.button_Next.Name = "button_Next";
			this.button_Next.Size = new System.Drawing.Size(92, 40);
			this.button_Next.TabIndex = 19;
			this.button_Next.Text = "Next ->";
			this.button_Next.UseVisualStyleBackColor = true;
			this.button_Next.Click += new System.EventHandler(this.Button_Next_Click);
			// 
			// textBox_search
			// 
			this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_search.Location = new System.Drawing.Point(782, 66);
			this.textBox_search.Name = "textBox_search";
			this.textBox_search.Size = new System.Drawing.Size(150, 24);
			this.textBox_search.TabIndex = 26;
			this.textBox_search.Text = "🔍 Search Customer";
			this.textBox_search.Click += new System.EventHandler(this.TextBox_search_Click);
			this.textBox_search.TextChanged += new System.EventHandler(this.TextBox_search_TextChanged);
			this.textBox_search.Leave += new System.EventHandler(this.TextBox_search_Leave);
			// 
			// button_Back
			// 
			this.button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Back.Location = new System.Drawing.Point(12, 415);
			this.button_Back.Name = "button_Back";
			this.button_Back.Size = new System.Drawing.Size(103, 32);
			this.button_Back.TabIndex = 39;
			this.button_Back.Text = "Other Records";
			this.button_Back.UseVisualStyleBackColor = true;
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
			this.label_Help.Location = new System.Drawing.Point(919, 9);
			this.label_Help.Name = "label_Help";
			this.label_Help.Size = new System.Drawing.Size(48, 22);
			this.label_Help.TabIndex = 40;
			this.label_Help.Text = "Help";
			// 
			// serviceChosen_InnerJoinDataGridView
			// 
			this.serviceChosen_InnerJoinDataGridView.AutoGenerateColumns = false;
			this.serviceChosen_InnerJoinDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.serviceChosen_InnerJoinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.serviceChosen_InnerJoinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn,
            this.customerIDNameDataGridViewTextBoxColumn,
            this.invoiceIdDataGridViewTextBoxColumn});
			this.serviceChosen_InnerJoinDataGridView.DataSource = this.serviceChosen_InnerJoinBindingSource;
			this.serviceChosen_InnerJoinDataGridView.Location = new System.Drawing.Point(340, 92);
			this.serviceChosen_InnerJoinDataGridView.Name = "serviceChosen_InnerJoinDataGridView";
			this.serviceChosen_InnerJoinDataGridView.ReadOnly = true;
			this.serviceChosen_InnerJoinDataGridView.Size = new System.Drawing.Size(592, 220);
			this.serviceChosen_InnerJoinDataGridView.TabIndex = 40;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// serviceNameDataGridViewTextBoxColumn
			// 
			this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "Service Name";
			this.serviceNameDataGridViewTextBoxColumn.HeaderText = "Service Name";
			this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
			this.serviceNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// customerIDNameDataGridViewTextBoxColumn
			// 
			this.customerIDNameDataGridViewTextBoxColumn.DataPropertyName = "Customer ID / Name";
			this.customerIDNameDataGridViewTextBoxColumn.HeaderText = "Customer ID / Name";
			this.customerIDNameDataGridViewTextBoxColumn.Name = "customerIDNameDataGridViewTextBoxColumn";
			this.customerIDNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// invoiceIdDataGridViewTextBoxColumn
			// 
			this.invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "Invoice Id";
			this.invoiceIdDataGridViewTextBoxColumn.HeaderText = "Invoice Id";
			this.invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
			this.invoiceIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// serviceChosen_InnerJoinBindingSource
			// 
			this.serviceChosen_InnerJoinBindingSource.DataMember = "ServiceChosen_InnerJoin";
			this.serviceChosen_InnerJoinBindingSource.DataSource = this.invoiceDatabaseDataSet1;
			// 
			// invoiceDatabaseDataSet1
			// 
			this.invoiceDatabaseDataSet1.DataSetName = "InvoiceDatabaseDataSet1";
			this.invoiceDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// idTextBox
			// 
			this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceChosen_InnerJoinBindingSource, "Id", true));
			this.idTextBox.Enabled = false;
			this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idTextBox.Location = new System.Drawing.Point(149, 108);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(161, 24);
			this.idTextBox.TabIndex = 41;
			// 
			// service_NameTextBox
			// 
			this.service_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceChosen_InnerJoinBindingSource, "Service Name", true));
			this.service_NameTextBox.Enabled = false;
			this.service_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.service_NameTextBox.Location = new System.Drawing.Point(149, 143);
			this.service_NameTextBox.Name = "service_NameTextBox";
			this.service_NameTextBox.Size = new System.Drawing.Size(161, 24);
			this.service_NameTextBox.TabIndex = 43;
			// 
			// customer_ID___NameTextBox
			// 
			this.customer_ID___NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceChosen_InnerJoinBindingSource, "Customer ID / Name", true));
			this.customer_ID___NameTextBox.Enabled = false;
			this.customer_ID___NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customer_ID___NameTextBox.Location = new System.Drawing.Point(190, 183);
			this.customer_ID___NameTextBox.Multiline = true;
			this.customer_ID___NameTextBox.Name = "customer_ID___NameTextBox";
			this.customer_ID___NameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.customer_ID___NameTextBox.Size = new System.Drawing.Size(120, 47);
			this.customer_ID___NameTextBox.TabIndex = 45;
			// 
			// invoice_IdTextBox
			// 
			this.invoice_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceChosen_InnerJoinBindingSource, "Invoice Id", true));
			this.invoice_IdTextBox.Enabled = false;
			this.invoice_IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.invoice_IdTextBox.Location = new System.Drawing.Point(149, 252);
			this.invoice_IdTextBox.Name = "invoice_IdTextBox";
			this.invoice_IdTextBox.Size = new System.Drawing.Size(161, 24);
			this.invoice_IdTextBox.TabIndex = 47;
			// 
			// serviceChosen_InnerJoinTableAdapter
			// 
			this.serviceChosen_InnerJoinTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.CustomerTableAdapter = null;
			this.tableAdapterManager.InvoiceRecordTableAdapter = null;
			this.tableAdapterManager.PaymentDetailsTableAdapter = null;
			this.tableAdapterManager.ServiceTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// ServiceChosen_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(979, 459);
			this.Controls.Add(idLabel);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(service_NameLabel);
			this.Controls.Add(this.service_NameTextBox);
			this.Controls.Add(customer_ID___NameLabel);
			this.Controls.Add(this.customer_ID___NameTextBox);
			this.Controls.Add(invoice_IdLabel);
			this.Controls.Add(this.invoice_IdTextBox);
			this.Controls.Add(this.serviceChosen_InnerJoinDataGridView);
			this.Controls.Add(this.label_Help);
			this.Controls.Add(this.button_Back);
			this.Controls.Add(this.textBox_search);
			this.Controls.Add(this.button_backwithpoint);
			this.Controls.Add(this.button_Next);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ServiceChosen_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Service Chosen";
			this.Load += new System.EventHandler(this.ServiceChosen_Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.serviceChosenInnerJoinBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceChosen_InnerJoinDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceChosen_InnerJoinBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button_backwithpoint;
		private System.Windows.Forms.Button button_Next;
		private System.Windows.Forms.TextBox textBox_search;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.Button button_Back;
		private System.Windows.Forms.Label label_Help;
		private System.Windows.Forms.BindingSource serviceChosenInnerJoinBindingSource;
		private InvoiceDatabaseDataSet1TableAdapters.ServiceChosen_InnerJoinTableAdapter serviceChosen_InnerJoinTableAdapter;
		private InvoiceDatabaseDataSet1 invoiceDatabaseDataSet1;
		private System.Windows.Forms.BindingSource serviceChosen_InnerJoinBindingSource;
		private InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView serviceChosen_InnerJoinDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerIDNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox service_NameTextBox;
		private System.Windows.Forms.TextBox customer_ID___NameTextBox;
		private System.Windows.Forms.TextBox invoice_IdTextBox;
	}
}