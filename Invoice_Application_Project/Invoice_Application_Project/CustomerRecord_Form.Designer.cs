﻿namespace Invoice_Application_Project
{
	partial class CustomerRecord_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRecord_Form));
			this.label_CustomerTitle = new System.Windows.Forms.Label();
			this.button_Back = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label_Help = new System.Windows.Forms.Label();
			this.invoiceDatabaseDataSet1 = new Invoice_Application_Project.InvoiceDatabaseDataSet1();
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customerTableAdapter = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.CustomerTableAdapter();
			this.tableAdapterManager = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager();
			this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.customerDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
			this.customerBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label_CustomerTitle
			// 
			this.label_CustomerTitle.AutoSize = true;
			this.label_CustomerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_CustomerTitle.Location = new System.Drawing.Point(292, 46);
			this.label_CustomerTitle.Name = "label_CustomerTitle";
			this.label_CustomerTitle.Size = new System.Drawing.Size(183, 24);
			this.label_CustomerTitle.TabIndex = 2;
			this.label_CustomerTitle.Text = "Customer Records";
			// 
			// button_Back
			// 
			this.button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Back.Location = new System.Drawing.Point(8, 365);
			this.button_Back.Name = "button_Back";
			this.button_Back.Size = new System.Drawing.Size(103, 32);
			this.button_Back.TabIndex = 3;
			this.button_Back.Text = "Back";
			this.toolTip1.SetToolTip(this.button_Back, "Back to Select Records");
			this.button_Back.UseVisualStyleBackColor = true;
			this.button_Back.Click += new System.EventHandler(this.Button1_Click);
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
			// label_Help
			// 
			this.label_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Help.AutoSize = true;
			this.label_Help.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_Help.Cursor = System.Windows.Forms.Cursors.Help;
			this.label_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Help.Location = new System.Drawing.Point(704, 9);
			this.label_Help.Name = "label_Help";
			this.label_Help.Size = new System.Drawing.Size(48, 22);
			this.label_Help.TabIndex = 5;
			this.label_Help.Text = "Help";
			this.toolTip1.SetToolTip(this.label_Help, resources.GetString("label_Help.ToolTip"));
			// 
			// invoiceDatabaseDataSet1
			// 
			this.invoiceDatabaseDataSet1.DataSetName = "InvoiceDatabaseDataSet1";
			this.invoiceDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// customerBindingSource
			// 
			this.customerBindingSource.DataMember = "Customer";
			this.customerBindingSource.DataSource = this.invoiceDatabaseDataSet1;
			// 
			// customerTableAdapter
			// 
			this.customerTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
			this.tableAdapterManager.InvoiceRecordTableAdapter = null;
			this.tableAdapterManager.PaymentDetailsTableAdapter = null;
			this.tableAdapterManager.ServiceChosenTableAdapter = null;
			this.tableAdapterManager.ServiceTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// customerBindingNavigator
			// 
			this.customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.customerBindingNavigator.BindingSource = this.customerBindingSource;
			this.customerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.customerBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
			this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customerBindingNavigatorSaveItem});
			this.customerBindingNavigator.Location = new System.Drawing.Point(230, 306);
			this.customerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.customerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.customerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.customerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.customerBindingNavigator.Name = "customerBindingNavigator";
			this.customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.customerBindingNavigator.Size = new System.Drawing.Size(278, 25);
			this.customerBindingNavigator.TabIndex = 6;
			this.customerBindingNavigator.Text = "bindingNavigator1";
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
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
			// customerBindingNavigatorSaveItem
			// 
			this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
			this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
			this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.customerBindingNavigatorSaveItem.Text = "Save Data";
			this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.CustomerBindingNavigatorSaveItem_Click_1);
			// 
			// customerDataGridView
			// 
			this.customerDataGridView.AutoGenerateColumns = false;
			this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.customerDataGridView.DataSource = this.customerBindingSource;
			this.customerDataGridView.Location = new System.Drawing.Point(27, 83);
			this.customerDataGridView.Name = "customerDataGridView";
			this.customerDataGridView.Size = new System.Drawing.Size(704, 220);
			this.customerDataGridView.TabIndex = 6;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "customerId";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "customerName";
			this.dataGridViewTextBoxColumn2.HeaderText = "Name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "email";
			this.dataGridViewTextBoxColumn3.HeaderText = "Email";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "address";
			this.dataGridViewTextBoxColumn4.HeaderText = "Address";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "postCode";
			this.dataGridViewTextBoxColumn5.HeaderText = "Post Code";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// CustomerRecord_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 402);
			this.Controls.Add(this.customerDataGridView);
			this.Controls.Add(this.customerBindingNavigator);
			this.Controls.Add(this.label_Help);
			this.Controls.Add(this.button_Back);
			this.Controls.Add(this.label_CustomerTitle);
			this.HelpButton = true;
			this.Name = "CustomerRecord_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer Record Form";
			this.Load += new System.EventHandler(this.CustomerRecord_Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
			this.customerBindingNavigator.ResumeLayout(false);
			this.customerBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label_CustomerTitle;
		private System.Windows.Forms.Button button_Back;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label_Help;
		private InvoiceDatabaseDataSet1 invoiceDatabaseDataSet1;
		private System.Windows.Forms.BindingSource customerBindingSource;
		private InvoiceDatabaseDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
		private InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator customerBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton customerBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView customerDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
	}
}