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
			System.Windows.Forms.Label serviceChosenIdLabel;
			System.Windows.Forms.Label invoiceRecordIdLabel;
			System.Windows.Forms.Label serviceIdLabel;
			System.Windows.Forms.Label customerIdLabel;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label4;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceChosen_Form));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button_backwithpoint = new System.Windows.Forms.Button();
			this.button_Next = new System.Windows.Forms.Button();
			this.textBox_search = new System.Windows.Forms.TextBox();
			this.invoiceDatabaseDataSet1 = new Invoice_Application_Project.InvoiceDatabaseDataSet1();
			this.serviceChosenBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.serviceChosenTableAdapter = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.ServiceChosenTableAdapter();
			this.tableAdapterManager = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager();
			this.serviceChosenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.serviceChosenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.serviceChosenDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serviceChosenIdTextBox = new System.Windows.Forms.TextBox();
			this.invoiceRecordIdTextBox = new System.Windows.Forms.TextBox();
			this.serviceIdTextBox = new System.Windows.Forms.TextBox();
			this.customerIdTextBox = new System.Windows.Forms.TextBox();
			this.textBox_ServiceName = new System.Windows.Forms.TextBox();
			this.button_Back = new System.Windows.Forms.Button();
			this.textBox_CustomerName = new System.Windows.Forms.TextBox();
			this.label_Help = new System.Windows.Forms.Label();
			serviceChosenIdLabel = new System.Windows.Forms.Label();
			invoiceRecordIdLabel = new System.Windows.Forms.Label();
			serviceIdLabel = new System.Windows.Forms.Label();
			customerIdLabel = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceChosenBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceChosenBindingNavigator)).BeginInit();
			this.serviceChosenBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.serviceChosenDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// serviceChosenIdLabel
			// 
			serviceChosenIdLabel.AutoSize = true;
			serviceChosenIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			serviceChosenIdLabel.Location = new System.Drawing.Point(30, 106);
			serviceChosenIdLabel.Name = "serviceChosenIdLabel";
			serviceChosenIdLabel.Size = new System.Drawing.Size(132, 18);
			serviceChosenIdLabel.TabIndex = 27;
			serviceChosenIdLabel.Text = "Service Chosen Id:";
			// 
			// invoiceRecordIdLabel
			// 
			invoiceRecordIdLabel.AutoSize = true;
			invoiceRecordIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			invoiceRecordIdLabel.Location = new System.Drawing.Point(30, 138);
			invoiceRecordIdLabel.Name = "invoiceRecordIdLabel";
			invoiceRecordIdLabel.Size = new System.Drawing.Size(73, 18);
			invoiceRecordIdLabel.TabIndex = 29;
			invoiceRecordIdLabel.Text = "Invoice Id:";
			// 
			// serviceIdLabel
			// 
			serviceIdLabel.AutoSize = true;
			serviceIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			serviceIdLabel.Location = new System.Drawing.Point(30, 272);
			serviceIdLabel.Name = "serviceIdLabel";
			serviceIdLabel.Size = new System.Drawing.Size(76, 18);
			serviceIdLabel.TabIndex = 31;
			serviceIdLabel.Text = "Service Id:";
			// 
			// customerIdLabel
			// 
			customerIdLabel.AutoSize = true;
			customerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			customerIdLabel.Location = new System.Drawing.Point(30, 184);
			customerIdLabel.Name = "customerIdLabel";
			customerIdLabel.Size = new System.Drawing.Size(93, 18);
			customerIdLabel.TabIndex = 33;
			customerIdLabel.Text = "Customer Id:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label3.Location = new System.Drawing.Point(30, 212);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(118, 18);
			label3.TabIndex = 35;
			label3.Text = "Customer Name";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label4.Location = new System.Drawing.Point(30, 297);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(105, 18);
			label4.TabIndex = 37;
			label4.Text = "Service Name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(506, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(242, 24);
			this.label1.TabIndex = 10;
			this.label1.Text = "Service Chosen Records";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(31, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 11;
			this.label2.Text = "Details";
			// 
			// button_backwithpoint
			// 
			this.button_backwithpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_backwithpoint.Location = new System.Drawing.Point(330, 347);
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
			this.button_Next.Location = new System.Drawing.Point(840, 349);
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
			// invoiceDatabaseDataSet1
			// 
			this.invoiceDatabaseDataSet1.DataSetName = "InvoiceDatabaseDataSet1";
			this.invoiceDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// serviceChosenBindingSource
			// 
			this.serviceChosenBindingSource.DataMember = "ServiceChosen";
			this.serviceChosenBindingSource.DataSource = this.invoiceDatabaseDataSet1;
			// 
			// serviceChosenTableAdapter
			// 
			this.serviceChosenTableAdapter.ClearBeforeFill = true;
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
			// serviceChosenBindingNavigator
			// 
			this.serviceChosenBindingNavigator.AddNewItem = null;
			this.serviceChosenBindingNavigator.BindingSource = this.serviceChosenBindingSource;
			this.serviceChosenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.serviceChosenBindingNavigator.DeleteItem = null;
			this.serviceChosenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.serviceChosenBindingNavigatorSaveItem});
			this.serviceChosenBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.serviceChosenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.serviceChosenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.serviceChosenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.serviceChosenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.serviceChosenBindingNavigator.Name = "serviceChosenBindingNavigator";
			this.serviceChosenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.serviceChosenBindingNavigator.Size = new System.Drawing.Size(955, 25);
			this.serviceChosenBindingNavigator.TabIndex = 27;
			this.serviceChosenBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// serviceChosenBindingNavigatorSaveItem
			// 
			this.serviceChosenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.serviceChosenBindingNavigatorSaveItem.Enabled = false;
			this.serviceChosenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceChosenBindingNavigatorSaveItem.Image")));
			this.serviceChosenBindingNavigatorSaveItem.Name = "serviceChosenBindingNavigatorSaveItem";
			this.serviceChosenBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.serviceChosenBindingNavigatorSaveItem.Text = "Save Data";
			// 
			// serviceChosenDataGridView
			// 
			this.serviceChosenDataGridView.AutoGenerateColumns = false;
			this.serviceChosenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.serviceChosenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.serviceChosenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
			this.serviceChosenDataGridView.DataSource = this.serviceChosenBindingSource;
			this.serviceChosenDataGridView.Location = new System.Drawing.Point(330, 98);
			this.serviceChosenDataGridView.Name = "serviceChosenDataGridView";
			this.serviceChosenDataGridView.ReadOnly = true;
			this.serviceChosenDataGridView.Size = new System.Drawing.Size(602, 243);
			this.serviceChosenDataGridView.TabIndex = 27;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "serviceChosenId";
			this.dataGridViewTextBoxColumn1.HeaderText = "Service Chosen Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "customerId";
			this.dataGridViewTextBoxColumn6.HeaderText = "Customer Id";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "serviceId";
			this.dataGridViewTextBoxColumn5.HeaderText = "Service Id";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "invoiceRecordId";
			this.dataGridViewTextBoxColumn4.HeaderText = "Invoice Record Id";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// serviceChosenIdTextBox
			// 
			this.serviceChosenIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceChosenBindingSource, "serviceChosenId", true));
			this.serviceChosenIdTextBox.Enabled = false;
			this.serviceChosenIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.serviceChosenIdTextBox.Location = new System.Drawing.Point(170, 105);
			this.serviceChosenIdTextBox.Name = "serviceChosenIdTextBox";
			this.serviceChosenIdTextBox.ReadOnly = true;
			this.serviceChosenIdTextBox.Size = new System.Drawing.Size(100, 24);
			this.serviceChosenIdTextBox.TabIndex = 28;
			// 
			// invoiceRecordIdTextBox
			// 
			this.invoiceRecordIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceChosenBindingSource, "invoiceRecordId", true));
			this.invoiceRecordIdTextBox.Enabled = false;
			this.invoiceRecordIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.invoiceRecordIdTextBox.Location = new System.Drawing.Point(170, 138);
			this.invoiceRecordIdTextBox.Name = "invoiceRecordIdTextBox";
			this.invoiceRecordIdTextBox.ReadOnly = true;
			this.invoiceRecordIdTextBox.Size = new System.Drawing.Size(100, 24);
			this.invoiceRecordIdTextBox.TabIndex = 30;
			// 
			// serviceIdTextBox
			// 
			this.serviceIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceChosenBindingSource, "serviceId", true));
			this.serviceIdTextBox.Enabled = false;
			this.serviceIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.serviceIdTextBox.Location = new System.Drawing.Point(170, 269);
			this.serviceIdTextBox.Name = "serviceIdTextBox";
			this.serviceIdTextBox.ReadOnly = true;
			this.serviceIdTextBox.Size = new System.Drawing.Size(141, 24);
			this.serviceIdTextBox.TabIndex = 32;
			this.serviceIdTextBox.TextChanged += new System.EventHandler(this.ServiceIdTextBox_TextChanged);
			// 
			// customerIdTextBox
			// 
			this.customerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceChosenBindingSource, "customerId", true));
			this.customerIdTextBox.Enabled = false;
			this.customerIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerIdTextBox.Location = new System.Drawing.Point(170, 181);
			this.customerIdTextBox.Name = "customerIdTextBox";
			this.customerIdTextBox.ReadOnly = true;
			this.customerIdTextBox.Size = new System.Drawing.Size(141, 24);
			this.customerIdTextBox.TabIndex = 34;
			this.customerIdTextBox.TextChanged += new System.EventHandler(this.CustomerIdTextBox_TextChanged);
			// 
			// textBox_ServiceName
			// 
			this.textBox_ServiceName.Enabled = false;
			this.textBox_ServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_ServiceName.Location = new System.Drawing.Point(170, 297);
			this.textBox_ServiceName.Multiline = true;
			this.textBox_ServiceName.Name = "textBox_ServiceName";
			this.textBox_ServiceName.ReadOnly = true;
			this.textBox_ServiceName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_ServiceName.Size = new System.Drawing.Size(141, 44);
			this.textBox_ServiceName.TabIndex = 38;
			// 
			// button_Back
			// 
			this.button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Back.Location = new System.Drawing.Point(12, 410);
			this.button_Back.Name = "button_Back";
			this.button_Back.Size = new System.Drawing.Size(103, 32);
			this.button_Back.TabIndex = 39;
			this.button_Back.Text = "Other Records";
			this.button_Back.UseVisualStyleBackColor = true;
			this.button_Back.Click += new System.EventHandler(this.Button_Back_Click);
			// 
			// textBox_CustomerName
			// 
			this.textBox_CustomerName.Enabled = false;
			this.textBox_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_CustomerName.Location = new System.Drawing.Point(170, 209);
			this.textBox_CustomerName.Multiline = true;
			this.textBox_CustomerName.Name = "textBox_CustomerName";
			this.textBox_CustomerName.ReadOnly = true;
			this.textBox_CustomerName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_CustomerName.Size = new System.Drawing.Size(141, 44);
			this.textBox_CustomerName.TabIndex = 36;
			// 
			// label_Help
			// 
			this.label_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Help.AutoSize = true;
			this.label_Help.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_Help.Cursor = System.Windows.Forms.Cursors.Help;
			this.label_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Help.Location = new System.Drawing.Point(895, 9);
			this.label_Help.Name = "label_Help";
			this.label_Help.Size = new System.Drawing.Size(48, 22);
			this.label_Help.TabIndex = 40;
			this.label_Help.Text = "Help";
			// 
			// ServiceChosen_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(955, 454);
			this.Controls.Add(this.label_Help);
			this.Controls.Add(this.button_Back);
			this.Controls.Add(this.textBox_ServiceName);
			this.Controls.Add(label4);
			this.Controls.Add(this.textBox_CustomerName);
			this.Controls.Add(label3);
			this.Controls.Add(serviceChosenIdLabel);
			this.Controls.Add(this.serviceChosenIdTextBox);
			this.Controls.Add(invoiceRecordIdLabel);
			this.Controls.Add(this.invoiceRecordIdTextBox);
			this.Controls.Add(serviceIdLabel);
			this.Controls.Add(this.serviceIdTextBox);
			this.Controls.Add(customerIdLabel);
			this.Controls.Add(this.customerIdTextBox);
			this.Controls.Add(this.serviceChosenDataGridView);
			this.Controls.Add(this.serviceChosenBindingNavigator);
			this.Controls.Add(this.textBox_search);
			this.Controls.Add(this.button_backwithpoint);
			this.Controls.Add(this.button_Next);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ServiceChosen_Form";
			this.Text = "Service Chosen";
			this.Load += new System.EventHandler(this.ServiceChosen_Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceChosenBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceChosenBindingNavigator)).EndInit();
			this.serviceChosenBindingNavigator.ResumeLayout(false);
			this.serviceChosenBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.serviceChosenDataGridView)).EndInit();
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
		private InvoiceDatabaseDataSet1 invoiceDatabaseDataSet1;
		private System.Windows.Forms.BindingSource serviceChosenBindingSource;
		private InvoiceDatabaseDataSet1TableAdapters.ServiceChosenTableAdapter serviceChosenTableAdapter;
		private InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator serviceChosenBindingNavigator;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton serviceChosenBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView serviceChosenDataGridView;
		private System.Windows.Forms.TextBox serviceChosenIdTextBox;
		private System.Windows.Forms.TextBox invoiceRecordIdTextBox;
		private System.Windows.Forms.TextBox serviceIdTextBox;
		private System.Windows.Forms.TextBox customerIdTextBox;
		private System.Windows.Forms.TextBox textBox_ServiceName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.Button button_Back;
		private System.Windows.Forms.TextBox textBox_CustomerName;
		private System.Windows.Forms.Label label_Help;
	}
}