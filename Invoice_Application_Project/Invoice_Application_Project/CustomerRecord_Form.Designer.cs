namespace Invoice_Application_Project
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
			System.Windows.Forms.Label customerIdLabel;
			System.Windows.Forms.Label customerNameLabel;
			System.Windows.Forms.Label emailLabel;
			System.Windows.Forms.Label addressLabel;
			System.Windows.Forms.Label postCodeLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRecord_Form));
			this.label_CustomerTitle = new System.Windows.Forms.Label();
			this.button_Back = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label_Help = new System.Windows.Forms.Label();
			this.invoiceDatabaseDataSet1 = new Invoice_Application_Project.InvoiceDatabaseDataSet1();
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customerTableAdapter = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.CustomerTableAdapter();
			this.tableAdapterManager = new Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager();
			this.customerDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerIdTextBox = new System.Windows.Forms.TextBox();
			this.customerNameTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.postCodeTextBox = new System.Windows.Forms.TextBox();
			this.button_Next = new System.Windows.Forms.Button();
			this.button_backwithpoint = new System.Windows.Forms.Button();
			this.button_AddData = new System.Windows.Forms.Button();
			this.button_Done = new System.Windows.Forms.Button();
			this.button_update = new System.Windows.Forms.Button();
			this.label_RecordsDetails = new System.Windows.Forms.Label();
			this.textBox_search = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			customerIdLabel = new System.Windows.Forms.Label();
			customerNameLabel = new System.Windows.Forms.Label();
			emailLabel = new System.Windows.Forms.Label();
			addressLabel = new System.Windows.Forms.Label();
			postCodeLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// customerIdLabel
			// 
			customerIdLabel.AutoSize = true;
			customerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			customerIdLabel.Location = new System.Drawing.Point(53, 14);
			customerIdLabel.Name = "customerIdLabel";
			customerIdLabel.Size = new System.Drawing.Size(26, 18);
			customerIdLabel.TabIndex = 6;
			customerIdLabel.Text = "ID:";
			// 
			// customerNameLabel
			// 
			customerNameLabel.AutoSize = true;
			customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			customerNameLabel.Location = new System.Drawing.Point(31, 54);
			customerNameLabel.Name = "customerNameLabel";
			customerNameLabel.Size = new System.Drawing.Size(48, 16);
			customerNameLabel.TabIndex = 8;
			customerNameLabel.Text = "Name:";
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			emailLabel.Location = new System.Drawing.Point(34, 88);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new System.Drawing.Size(45, 16);
			emailLabel.TabIndex = 10;
			emailLabel.Text = "Email:";
			// 
			// addressLabel
			// 
			addressLabel.AutoSize = true;
			addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			addressLabel.Location = new System.Drawing.Point(17, 128);
			addressLabel.Name = "addressLabel";
			addressLabel.Size = new System.Drawing.Size(62, 16);
			addressLabel.TabIndex = 12;
			addressLabel.Text = "Address:";
			// 
			// postCodeLabel
			// 
			postCodeLabel.AutoSize = true;
			postCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			postCodeLabel.Location = new System.Drawing.Point(10, 200);
			postCodeLabel.Name = "postCodeLabel";
			postCodeLabel.Size = new System.Drawing.Size(74, 16);
			postCodeLabel.TabIndex = 14;
			postCodeLabel.Text = "Post Code:";
			// 
			// label_CustomerTitle
			// 
			this.label_CustomerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_CustomerTitle.AutoSize = true;
			this.label_CustomerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_CustomerTitle.Location = new System.Drawing.Point(554, 70);
			this.label_CustomerTitle.Name = "label_CustomerTitle";
			this.label_CustomerTitle.Size = new System.Drawing.Size(183, 24);
			this.label_CustomerTitle.TabIndex = 2;
			this.label_CustomerTitle.Text = "Customer Records";
			// 
			// button_Back
			// 
			this.button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Back.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Back.Location = new System.Drawing.Point(8, 447);
			this.button_Back.Name = "button_Back";
			this.button_Back.Size = new System.Drawing.Size(103, 32);
			this.button_Back.TabIndex = 3;
			this.button_Back.Text = "Other Records";
			this.toolTip1.SetToolTip(this.button_Back, "Back to Select Records");
			this.button_Back.UseVisualStyleBackColor = false;
			this.button_Back.Click += new System.EventHandler(this.Button1_Click);
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
			// label_Help
			// 
			this.label_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Help.AutoSize = true;
			this.label_Help.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_Help.Cursor = System.Windows.Forms.Cursors.Help;
			this.label_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Help.Location = new System.Drawing.Point(937, 9);
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
			this.tableAdapterManager.Old_ServiceRecordTableAdapter = null;
			this.tableAdapterManager.PaymentDetailsTableAdapter = null;
			this.tableAdapterManager.ServiceTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Invoice_Application_Project.InvoiceDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// customerDataGridView
			// 
			this.customerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			this.customerDataGridView.Location = new System.Drawing.Point(16, 8);
			this.customerDataGridView.Name = "customerDataGridView";
			this.customerDataGridView.ReadOnly = true;
			this.customerDataGridView.Size = new System.Drawing.Size(643, 220);
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
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "email";
			this.dataGridViewTextBoxColumn3.HeaderText = "Email";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "address";
			this.dataGridViewTextBoxColumn4.HeaderText = "Address";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "postCode";
			this.dataGridViewTextBoxColumn5.HeaderText = "Post Code";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// customerIdTextBox
			// 
			this.customerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "customerId", true));
			this.customerIdTextBox.Enabled = false;
			this.customerIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerIdTextBox.Location = new System.Drawing.Point(94, 14);
			this.customerIdTextBox.Name = "customerIdTextBox";
			this.customerIdTextBox.ReadOnly = true;
			this.customerIdTextBox.Size = new System.Drawing.Size(100, 24);
			this.customerIdTextBox.TabIndex = 7;
			// 
			// customerNameTextBox
			// 
			this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "customerName", true));
			this.customerNameTextBox.Enabled = false;
			this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerNameTextBox.Location = new System.Drawing.Point(93, 54);
			this.customerNameTextBox.Name = "customerNameTextBox";
			this.customerNameTextBox.Size = new System.Drawing.Size(181, 24);
			this.customerNameTextBox.TabIndex = 9;
			// 
			// emailTextBox
			// 
			this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "email", true));
			this.emailTextBox.Enabled = false;
			this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailTextBox.Location = new System.Drawing.Point(94, 88);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(180, 24);
			this.emailTextBox.TabIndex = 11;
			// 
			// addressTextBox
			// 
			this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address", true));
			this.addressTextBox.Enabled = false;
			this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addressTextBox.Location = new System.Drawing.Point(94, 123);
			this.addressTextBox.Multiline = true;
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.addressTextBox.Size = new System.Drawing.Size(180, 62);
			this.addressTextBox.TabIndex = 13;
			// 
			// postCodeTextBox
			// 
			this.postCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "postCode", true));
			this.postCodeTextBox.Enabled = false;
			this.postCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.postCodeTextBox.Location = new System.Drawing.Point(93, 195);
			this.postCodeTextBox.Name = "postCodeTextBox";
			this.postCodeTextBox.Size = new System.Drawing.Size(100, 24);
			this.postCodeTextBox.TabIndex = 15;
			// 
			// button_Next
			// 
			this.button_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_Next.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.button_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Next.Location = new System.Drawing.Point(567, 228);
			this.button_Next.Name = "button_Next";
			this.button_Next.Size = new System.Drawing.Size(92, 40);
			this.button_Next.TabIndex = 16;
			this.button_Next.Text = "Next ->";
			this.button_Next.UseVisualStyleBackColor = false;
			this.button_Next.Click += new System.EventHandler(this.Button_Next_Click);
			// 
			// button_backwithpoint
			// 
			this.button_backwithpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_backwithpoint.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.button_backwithpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_backwithpoint.Location = new System.Drawing.Point(16, 228);
			this.button_backwithpoint.Name = "button_backwithpoint";
			this.button_backwithpoint.Size = new System.Drawing.Size(92, 40);
			this.button_backwithpoint.TabIndex = 17;
			this.button_backwithpoint.Text = "<- Back";
			this.button_backwithpoint.UseVisualStyleBackColor = false;
			this.button_backwithpoint.Click += new System.EventHandler(this.Button_backwithpoint_Click);
			// 
			// button_AddData
			// 
			this.button_AddData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button_AddData.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.button_AddData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_AddData.Location = new System.Drawing.Point(287, 228);
			this.button_AddData.Name = "button_AddData";
			this.button_AddData.Size = new System.Drawing.Size(105, 40);
			this.button_AddData.TabIndex = 18;
			this.button_AddData.Text = "Add ➕";
			this.button_AddData.UseVisualStyleBackColor = false;
			this.button_AddData.Click += new System.EventHandler(this.Button_AddData_Click);
			// 
			// button_Done
			// 
			this.button_Done.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.button_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Done.Location = new System.Drawing.Point(103, 232);
			this.button_Done.Name = "button_Done";
			this.button_Done.Size = new System.Drawing.Size(94, 30);
			this.button_Done.TabIndex = 22;
			this.button_Done.Text = "Save 💾";
			this.button_Done.UseVisualStyleBackColor = false;
			this.button_Done.Visible = false;
			this.button_Done.Click += new System.EventHandler(this.Button_Done_Click);
			// 
			// button_update
			// 
			this.button_update.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_update.Location = new System.Drawing.Point(104, 233);
			this.button_update.Name = "button_update";
			this.button_update.Size = new System.Drawing.Size(94, 30);
			this.button_update.TabIndex = 23;
			this.button_update.Text = "Update ✏️";
			this.button_update.UseVisualStyleBackColor = false;
			this.button_update.Click += new System.EventHandler(this.Button_update_Click);
			// 
			// label_RecordsDetails
			// 
			this.label_RecordsDetails.AutoSize = true;
			this.label_RecordsDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_RecordsDetails.Location = new System.Drawing.Point(96, 71);
			this.label_RecordsDetails.Name = "label_RecordsDetails";
			this.label_RecordsDetails.Size = new System.Drawing.Size(167, 24);
			this.label_RecordsDetails.TabIndex = 24;
			this.label_RecordsDetails.Text = "Customer Details";
			// 
			// textBox_search
			// 
			this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_search.Location = new System.Drawing.Point(838, 70);
			this.textBox_search.Name = "textBox_search";
			this.textBox_search.Size = new System.Drawing.Size(147, 24);
			this.textBox_search.TabIndex = 25;
			this.textBox_search.Text = "🔍 Search Customer";
			this.textBox_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_search_MouseClick);
			this.textBox_search.TextChanged += new System.EventHandler(this.TextBox_search_TextChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.customerIdTextBox);
			this.panel1.Controls.Add(this.postCodeTextBox);
			this.panel1.Controls.Add(postCodeLabel);
			this.panel1.Controls.Add(this.addressTextBox);
			this.panel1.Controls.Add(this.button_Done);
			this.panel1.Controls.Add(this.button_update);
			this.panel1.Controls.Add(addressLabel);
			this.panel1.Controls.Add(this.emailTextBox);
			this.panel1.Controls.Add(emailLabel);
			this.panel1.Controls.Add(this.customerNameTextBox);
			this.panel1.Controls.Add(customerNameLabel);
			this.panel1.Controls.Add(customerIdLabel);
			this.panel1.Location = new System.Drawing.Point(12, 99);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(284, 270);
			this.panel1.TabIndex = 26;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel2.Controls.Add(this.customerDataGridView);
			this.panel2.Controls.Add(this.button_backwithpoint);
			this.panel2.Controls.Add(this.button_AddData);
			this.panel2.Controls.Add(this.button_Next);
			this.panel2.Location = new System.Drawing.Point(312, 99);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(673, 270);
			this.panel2.TabIndex = 27;
			// 
			// CustomerRecord_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(997, 484);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label_Help);
			this.Controls.Add(this.textBox_search);
			this.Controls.Add(this.label_RecordsDetails);
			this.Controls.Add(this.button_Back);
			this.Controls.Add(this.label_CustomerTitle);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1013, 523);
			this.Name = "CustomerRecord_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer Record Form";
			this.Load += new System.EventHandler(this.CustomerRecord_Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.invoiceDatabaseDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
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
		private System.Windows.Forms.DataGridView customerDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.TextBox customerIdTextBox;
		private System.Windows.Forms.TextBox customerNameTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.TextBox postCodeTextBox;
		private System.Windows.Forms.Button button_Next;
		private System.Windows.Forms.Button button_backwithpoint;
		private System.Windows.Forms.Button button_AddData;
		private System.Windows.Forms.Button button_Done;
		private System.Windows.Forms.Button button_update;
		private System.Windows.Forms.Label label_RecordsDetails;
		private System.Windows.Forms.TextBox textBox_search;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}