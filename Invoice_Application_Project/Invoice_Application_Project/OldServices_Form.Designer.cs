namespace Invoice_Application_Project
{
	partial class OldServices_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldServices_Form));
			this.invoiceDatabaseDataSet1 = new Invoice_Application_Project.InvoiceDatabaseDataSet1();
			this.old_ServiceRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.old_ServiceRecordTableAdapter = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.Old_ServiceRecordTableAdapter();
			this.tableAdapterManager = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager();
			this.old_ServiceRecordBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.old_ServiceRecordDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.old_ServiceRecordBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.old_ServiceRecordBindingNavigator)).BeginInit();
			this.old_ServiceRecordBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.old_ServiceRecordDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// invoiceDatabaseDataSet1
			// 
			this.invoiceDatabaseDataSet1.DataSetName = "InvoiceDatabaseDataSet1";
			this.invoiceDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// old_ServiceRecordBindingSource
			// 
			this.old_ServiceRecordBindingSource.DataMember = "Old_ServiceRecord";
			this.old_ServiceRecordBindingSource.DataSource = this.invoiceDatabaseDataSet1;
			// 
			// old_ServiceRecordTableAdapter
			// 
			this.old_ServiceRecordTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CustomerTableAdapter = null;
			this.tableAdapterManager.InvoiceRecordTableAdapter = null;
			this.tableAdapterManager.Old_ServiceRecordTableAdapter = this.old_ServiceRecordTableAdapter;
			this.tableAdapterManager.PaymentDetailsTableAdapter = null;
			this.tableAdapterManager.ServiceTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// old_ServiceRecordBindingNavigator
			// 
			this.old_ServiceRecordBindingNavigator.AddNewItem = null;
			this.old_ServiceRecordBindingNavigator.BindingSource = this.old_ServiceRecordBindingSource;
			this.old_ServiceRecordBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.old_ServiceRecordBindingNavigator.DeleteItem = null;
			this.old_ServiceRecordBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
			this.old_ServiceRecordBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.old_ServiceRecordBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.old_ServiceRecordBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.old_ServiceRecordBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.old_ServiceRecordBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.old_ServiceRecordBindingNavigator.Name = "old_ServiceRecordBindingNavigator";
			this.old_ServiceRecordBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.old_ServiceRecordBindingNavigator.Size = new System.Drawing.Size(800, 25);
			this.old_ServiceRecordBindingNavigator.TabIndex = 0;
			this.old_ServiceRecordBindingNavigator.Text = "bindingNavigator1";
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
			// old_ServiceRecordDataGridView
			// 
			this.old_ServiceRecordDataGridView.AutoGenerateColumns = false;
			this.old_ServiceRecordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.old_ServiceRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.old_ServiceRecordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.old_ServiceRecordDataGridView.DataSource = this.old_ServiceRecordBindingSource;
			this.old_ServiceRecordDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.old_ServiceRecordDataGridView.Location = new System.Drawing.Point(0, 25);
			this.old_ServiceRecordDataGridView.Name = "old_ServiceRecordDataGridView";
			this.old_ServiceRecordDataGridView.ReadOnly = true;
			this.old_ServiceRecordDataGridView.Size = new System.Drawing.Size(800, 425);
			this.old_ServiceRecordDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "previousId";
			this.dataGridViewTextBoxColumn2.HeaderText = "Previous Id";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "serviceName";
			this.dataGridViewTextBoxColumn3.HeaderText = "Service Name";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "servicePrice";
			this.dataGridViewTextBoxColumn4.HeaderText = "Service Price";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "dateAdded";
			this.dataGridViewTextBoxColumn5.HeaderText = "Date Added";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// OldServices_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.old_ServiceRecordDataGridView);
			this.Controls.Add(this.old_ServiceRecordBindingNavigator);
			this.Name = "OldServices_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Old Services";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.OldServices_Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.old_ServiceRecordBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.old_ServiceRecordBindingNavigator)).EndInit();
			this.old_ServiceRecordBindingNavigator.ResumeLayout(false);
			this.old_ServiceRecordBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.old_ServiceRecordDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private InvoiceDatabaseDataSet1 invoiceDatabaseDataSet1;
		private System.Windows.Forms.BindingSource old_ServiceRecordBindingSource;
		private InvoiceDatabaseDataSet1TableAdapters.Old_ServiceRecordTableAdapter old_ServiceRecordTableAdapter;
		private InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator old_ServiceRecordBindingNavigator;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.DataGridView old_ServiceRecordDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
	}
}