﻿namespace Invoice_Application_Project
{
	partial class ServiceRecords_Form
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
			System.Windows.Forms.Label serviceIdLabel;
			System.Windows.Forms.Label serviceNameLabel;
			System.Windows.Forms.Label priceLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRecords_Form));
			this.label_ServiceRecords = new System.Windows.Forms.Label();
			this.invoiceDatabaseDataSet1 = new Invoice_Application_Project.InvoiceDatabaseDataSet1();
			this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.serviceTableAdapter = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.ServiceTableAdapter();
			this.tableAdapterManager = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager();
			this.serviceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.serviceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.serviceDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button_Back = new System.Windows.Forms.Button();
			this.label_Help = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.serviceIdTextBox = new System.Windows.Forms.TextBox();
			this.serviceNameTextBox = new System.Windows.Forms.TextBox();
			this.priceTextBox = new System.Windows.Forms.TextBox();
			this.button_RemoveData = new System.Windows.Forms.Button();
			this.button_AddData = new System.Windows.Forms.Button();
			this.button_backwithpoint = new System.Windows.Forms.Button();
			this.button_Next = new System.Windows.Forms.Button();
			this.button_update = new System.Windows.Forms.Button();
			this.button_Done = new System.Windows.Forms.Button();
			this.label_RecordsDetails = new System.Windows.Forms.Label();
			this.textBox_search = new System.Windows.Forms.TextBox();
			serviceIdLabel = new System.Windows.Forms.Label();
			serviceNameLabel = new System.Windows.Forms.Label();
			priceLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceBindingNavigator)).BeginInit();
			this.serviceBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// serviceIdLabel
			// 
			serviceIdLabel.AutoSize = true;
			serviceIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			serviceIdLabel.Location = new System.Drawing.Point(87, 115);
			serviceIdLabel.Name = "serviceIdLabel";
			serviceIdLabel.Size = new System.Drawing.Size(26, 18);
			serviceIdLabel.TabIndex = 8;
			serviceIdLabel.Text = "ID:";
			// 
			// serviceNameLabel
			// 
			serviceNameLabel.AutoSize = true;
			serviceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			serviceNameLabel.Location = new System.Drawing.Point(12, 148);
			serviceNameLabel.Name = "serviceNameLabel";
			serviceNameLabel.Size = new System.Drawing.Size(105, 18);
			serviceNameLabel.TabIndex = 10;
			serviceNameLabel.Text = "Service Name:";
			// 
			// priceLabel
			// 
			priceLabel.AutoSize = true;
			priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			priceLabel.Location = new System.Drawing.Point(67, 203);
			priceLabel.Name = "priceLabel";
			priceLabel.Size = new System.Drawing.Size(46, 18);
			priceLabel.TabIndex = 12;
			priceLabel.Text = "Price:";
			// 
			// label_ServiceRecords
			// 
			this.label_ServiceRecords.AutoSize = true;
			this.label_ServiceRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_ServiceRecords.Location = new System.Drawing.Point(474, 56);
			this.label_ServiceRecords.Name = "label_ServiceRecords";
			this.label_ServiceRecords.Size = new System.Drawing.Size(164, 24);
			this.label_ServiceRecords.TabIndex = 3;
			this.label_ServiceRecords.Text = "Service Records";
			// 
			// invoiceDatabaseDataSet1
			// 
			this.invoiceDatabaseDataSet1.DataSetName = "InvoiceDatabaseDataSet1";
			this.invoiceDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// serviceBindingSource
			// 
			this.serviceBindingSource.DataMember = "Service";
			this.serviceBindingSource.DataSource = this.invoiceDatabaseDataSet1;
			// 
			// serviceTableAdapter
			// 
			this.serviceTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CustomerTableAdapter = null;
			this.tableAdapterManager.InvoiceRecordTableAdapter = null;
			this.tableAdapterManager.PaymentDetailsTableAdapter = null;
			this.tableAdapterManager.ServiceChosenTableAdapter = null;
			this.tableAdapterManager.ServiceTableAdapter = this.serviceTableAdapter;
			this.tableAdapterManager.UpdateOrder = Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// serviceBindingNavigator
			// 
			this.serviceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.serviceBindingNavigator.BindingSource = this.serviceBindingSource;
			this.serviceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.serviceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.serviceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.serviceBindingNavigatorSaveItem});
			this.serviceBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.serviceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.serviceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.serviceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.serviceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.serviceBindingNavigator.Name = "serviceBindingNavigator";
			this.serviceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.serviceBindingNavigator.Size = new System.Drawing.Size(854, 25);
			this.serviceBindingNavigator.TabIndex = 4;
			this.serviceBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
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
			// serviceBindingNavigatorSaveItem
			// 
			this.serviceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.serviceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceBindingNavigatorSaveItem.Image")));
			this.serviceBindingNavigatorSaveItem.Name = "serviceBindingNavigatorSaveItem";
			this.serviceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.serviceBindingNavigatorSaveItem.Text = "Save Data";
			this.serviceBindingNavigatorSaveItem.Click += new System.EventHandler(this.ServiceBindingNavigatorSaveItem_Click);
			// 
			// serviceDataGridView
			// 
			this.serviceDataGridView.AutoGenerateColumns = false;
			this.serviceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.serviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.serviceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.serviceDataGridView.DataSource = this.serviceBindingSource;
			this.serviceDataGridView.Location = new System.Drawing.Point(311, 92);
			this.serviceDataGridView.Name = "serviceDataGridView";
			this.serviceDataGridView.Size = new System.Drawing.Size(489, 229);
			this.serviceDataGridView.TabIndex = 4;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "serviceName";
			this.dataGridViewTextBoxColumn2.HeaderText = "Service Name";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 300;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 300;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "price";
			this.dataGridViewTextBoxColumn3.HeaderText = "Price";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// button_Back
			// 
			this.button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Back.Location = new System.Drawing.Point(12, 417);
			this.button_Back.Name = "button_Back";
			this.button_Back.Size = new System.Drawing.Size(103, 32);
			this.button_Back.TabIndex = 5;
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
			this.label_Help.Location = new System.Drawing.Point(799, 5);
			this.label_Help.Name = "label_Help";
			this.label_Help.Size = new System.Drawing.Size(48, 22);
			this.label_Help.TabIndex = 8;
			this.label_Help.Text = "Help";
			this.toolTip1.SetToolTip(this.label_Help, resources.GetString("label_Help.ToolTip"));
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 10000;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.ReshowDelay = 100;
			this.toolTip1.ShowAlways = true;
			this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "How to use";
			// 
			// serviceIdTextBox
			// 
			this.serviceIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "serviceId", true));
			this.serviceIdTextBox.Enabled = false;
			this.serviceIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.serviceIdTextBox.Location = new System.Drawing.Point(119, 114);
			this.serviceIdTextBox.Name = "serviceIdTextBox";
			this.serviceIdTextBox.Size = new System.Drawing.Size(100, 24);
			this.serviceIdTextBox.TabIndex = 9;
			// 
			// serviceNameTextBox
			// 
			this.serviceNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "serviceName", true));
			this.serviceNameTextBox.Enabled = false;
			this.serviceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.serviceNameTextBox.Location = new System.Drawing.Point(119, 149);
			this.serviceNameTextBox.Multiline = true;
			this.serviceNameTextBox.Name = "serviceNameTextBox";
			this.serviceNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.serviceNameTextBox.Size = new System.Drawing.Size(158, 48);
			this.serviceNameTextBox.TabIndex = 11;
			// 
			// priceTextBox
			// 
			this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "price", true));
			this.priceTextBox.Enabled = false;
			this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.priceTextBox.Location = new System.Drawing.Point(119, 203);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(100, 24);
			this.priceTextBox.TabIndex = 13;
			// 
			// button_RemoveData
			// 
			this.button_RemoveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_RemoveData.Location = new System.Drawing.Point(457, 329);
			this.button_RemoveData.Name = "button_RemoveData";
			this.button_RemoveData.Size = new System.Drawing.Size(105, 40);
			this.button_RemoveData.TabIndex = 25;
			this.button_RemoveData.Text = "➖ Remove";
			this.button_RemoveData.UseVisualStyleBackColor = true;
			this.button_RemoveData.Click += new System.EventHandler(this.Button_RemoveData_Click);
			// 
			// button_AddData
			// 
			this.button_AddData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_AddData.Location = new System.Drawing.Point(566, 329);
			this.button_AddData.Name = "button_AddData";
			this.button_AddData.Size = new System.Drawing.Size(105, 40);
			this.button_AddData.TabIndex = 24;
			this.button_AddData.Text = "Add ➕";
			this.button_AddData.UseVisualStyleBackColor = true;
			this.button_AddData.Click += new System.EventHandler(this.Button_AddData_Click);
			// 
			// button_backwithpoint
			// 
			this.button_backwithpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_backwithpoint.Location = new System.Drawing.Point(312, 329);
			this.button_backwithpoint.Name = "button_backwithpoint";
			this.button_backwithpoint.Size = new System.Drawing.Size(92, 40);
			this.button_backwithpoint.TabIndex = 23;
			this.button_backwithpoint.Text = "<- Back";
			this.button_backwithpoint.UseVisualStyleBackColor = true;
			this.button_backwithpoint.Click += new System.EventHandler(this.Button_backwithpoint_Click);
			// 
			// button_Next
			// 
			this.button_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Next.Location = new System.Drawing.Point(709, 329);
			this.button_Next.Name = "button_Next";
			this.button_Next.Size = new System.Drawing.Size(92, 40);
			this.button_Next.TabIndex = 22;
			this.button_Next.Text = "Next ->";
			this.button_Next.UseVisualStyleBackColor = true;
			this.button_Next.Click += new System.EventHandler(this.Button_Next_Click);
			// 
			// button_update
			// 
			this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_update.Location = new System.Drawing.Point(125, 249);
			this.button_update.Name = "button_update";
			this.button_update.Size = new System.Drawing.Size(94, 30);
			this.button_update.TabIndex = 29;
			this.button_update.Text = "Update ✏️";
			this.button_update.UseVisualStyleBackColor = true;
			this.button_update.Click += new System.EventHandler(this.Button_update_Click);
			// 
			// button_Done
			// 
			this.button_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Done.Location = new System.Drawing.Point(125, 249);
			this.button_Done.Name = "button_Done";
			this.button_Done.Size = new System.Drawing.Size(94, 30);
			this.button_Done.TabIndex = 28;
			this.button_Done.Text = "Save 💾";
			this.button_Done.UseVisualStyleBackColor = true;
			this.button_Done.Visible = false;
			this.button_Done.Click += new System.EventHandler(this.Button_Done_Click);
			// 
			// label_RecordsDetails
			// 
			this.label_RecordsDetails.AutoSize = true;
			this.label_RecordsDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_RecordsDetails.Location = new System.Drawing.Point(86, 56);
			this.label_RecordsDetails.Name = "label_RecordsDetails";
			this.label_RecordsDetails.Size = new System.Drawing.Size(148, 24);
			this.label_RecordsDetails.TabIndex = 30;
			this.label_RecordsDetails.Text = "Service Details";
			// 
			// textBox_search
			// 
			this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_search.Location = new System.Drawing.Point(676, 57);
			this.textBox_search.Name = "textBox_search";
			this.textBox_search.Size = new System.Drawing.Size(124, 24);
			this.textBox_search.TabIndex = 31;
			this.textBox_search.Text = "🔍 Search";
			this.textBox_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_search_MouseClick);
			this.textBox_search.TextChanged += new System.EventHandler(this.TextBox_search_TextChanged);
			// 
			// ServiceRecords_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 461);
			this.Controls.Add(this.textBox_search);
			this.Controls.Add(this.label_RecordsDetails);
			this.Controls.Add(this.button_update);
			this.Controls.Add(this.button_Done);
			this.Controls.Add(this.button_RemoveData);
			this.Controls.Add(this.button_AddData);
			this.Controls.Add(this.button_backwithpoint);
			this.Controls.Add(this.button_Next);
			this.Controls.Add(serviceIdLabel);
			this.Controls.Add(this.serviceIdTextBox);
			this.Controls.Add(serviceNameLabel);
			this.Controls.Add(this.serviceNameTextBox);
			this.Controls.Add(priceLabel);
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(this.label_Help);
			this.Controls.Add(this.button_Back);
			this.Controls.Add(this.serviceDataGridView);
			this.Controls.Add(this.serviceBindingNavigator);
			this.Controls.Add(this.label_ServiceRecords);
			this.Name = "ServiceRecords_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Service Records";
			this.Load += new System.EventHandler(this.ServiceRecords_Load);
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceBindingNavigator)).EndInit();
			this.serviceBindingNavigator.ResumeLayout(false);
			this.serviceBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_ServiceRecords;
		private InvoiceDatabaseDataSet1 invoiceDatabaseDataSet1;
		private System.Windows.Forms.BindingSource serviceBindingSource;
		private InvoiceDatabaseDataSet1TableAdapters.ServiceTableAdapter serviceTableAdapter;
		private InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator serviceBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton serviceBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView serviceDataGridView;
		private System.Windows.Forms.Button button_Back;
		private System.Windows.Forms.Label label_Help;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TextBox serviceIdTextBox;
		private System.Windows.Forms.TextBox serviceNameTextBox;
		private System.Windows.Forms.TextBox priceTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.Button button_RemoveData;
		private System.Windows.Forms.Button button_AddData;
		private System.Windows.Forms.Button button_backwithpoint;
		private System.Windows.Forms.Button button_Next;
		private System.Windows.Forms.Button button_update;
		private System.Windows.Forms.Button button_Done;
		private System.Windows.Forms.Label label_RecordsDetails;
		private System.Windows.Forms.TextBox textBox_search;
	}
}