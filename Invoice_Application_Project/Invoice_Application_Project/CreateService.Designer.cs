namespace Invoice_Application_Project
{
	partial class CreateService
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateService));
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkBox_SaveService = new System.Windows.Forms.CheckBox();
			this.numericUpDown_Price = new System.Windows.Forms.NumericUpDown();
			this.textBox_Name = new System.Windows.Forms.TextBox();
			this.label_ServicePrice = new System.Windows.Forms.Label();
			this.label_ServiceName = new System.Windows.Forms.Label();
			this.button_CreateServiceAdd = new System.Windows.Forms.Button();
			this.label_CreateServiceTitle = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox_SaveService);
			this.panel1.Controls.Add(this.numericUpDown_Price);
			this.panel1.Controls.Add(this.textBox_Name);
			this.panel1.Controls.Add(this.label_ServicePrice);
			this.panel1.Controls.Add(this.label_ServiceName);
			this.panel1.Controls.Add(this.button_CreateServiceAdd);
			this.panel1.Controls.Add(this.label_CreateServiceTitle);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(315, 302);
			this.panel1.TabIndex = 0;
			// 
			// checkBox_SaveService
			// 
			this.checkBox_SaveService.AutoSize = true;
			this.checkBox_SaveService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_SaveService.Location = new System.Drawing.Point(76, 190);
			this.checkBox_SaveService.Name = "checkBox_SaveService";
			this.checkBox_SaveService.Size = new System.Drawing.Size(113, 20);
			this.checkBox_SaveService.TabIndex = 7;
			this.checkBox_SaveService.Text = "Save service?";
			this.checkBox_SaveService.UseVisualStyleBackColor = true;
			// 
			// numericUpDown_Price
			// 
			this.numericUpDown_Price.DecimalPlaces = 2;
			this.numericUpDown_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown_Price.Location = new System.Drawing.Point(76, 147);
			this.numericUpDown_Price.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown_Price.Name = "numericUpDown_Price";
			this.numericUpDown_Price.Size = new System.Drawing.Size(126, 26);
			this.numericUpDown_Price.TabIndex = 6;
			// 
			// textBox_Name
			// 
			this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Name.Location = new System.Drawing.Point(76, 99);
			this.textBox_Name.MaxLength = 500;
			this.textBox_Name.Name = "textBox_Name";
			this.textBox_Name.Size = new System.Drawing.Size(205, 26);
			this.textBox_Name.TabIndex = 4;
			// 
			// label_ServicePrice
			// 
			this.label_ServicePrice.AutoSize = true;
			this.label_ServicePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_ServicePrice.Location = new System.Drawing.Point(22, 147);
			this.label_ServicePrice.Name = "label_ServicePrice";
			this.label_ServicePrice.Size = new System.Drawing.Size(44, 20);
			this.label_ServicePrice.TabIndex = 3;
			this.label_ServicePrice.Text = "Price";
			// 
			// label_ServiceName
			// 
			this.label_ServiceName.AutoSize = true;
			this.label_ServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_ServiceName.Location = new System.Drawing.Point(19, 97);
			this.label_ServiceName.Name = "label_ServiceName";
			this.label_ServiceName.Size = new System.Drawing.Size(51, 20);
			this.label_ServiceName.TabIndex = 2;
			this.label_ServiceName.Text = "Name";
			// 
			// button_CreateServiceAdd
			// 
			this.button_CreateServiceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CreateServiceAdd.Location = new System.Drawing.Point(107, 231);
			this.button_CreateServiceAdd.Name = "button_CreateServiceAdd";
			this.button_CreateServiceAdd.Size = new System.Drawing.Size(95, 36);
			this.button_CreateServiceAdd.TabIndex = 1;
			this.button_CreateServiceAdd.Text = "Add";
			this.button_CreateServiceAdd.UseVisualStyleBackColor = true;
			this.button_CreateServiceAdd.Click += new System.EventHandler(this.Button_CreateServiceAdd_Click);
			// 
			// label_CreateServiceTitle
			// 
			this.label_CreateServiceTitle.AutoSize = true;
			this.label_CreateServiceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_CreateServiceTitle.Location = new System.Drawing.Point(84, 33);
			this.label_CreateServiceTitle.Name = "label_CreateServiceTitle";
			this.label_CreateServiceTitle.Size = new System.Drawing.Size(147, 24);
			this.label_CreateServiceTitle.TabIndex = 0;
			this.label_CreateServiceTitle.Text = "Create Service";
			// 
			// CreateService
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 326);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateService";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create Service";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox_Name;
		private System.Windows.Forms.Label label_ServicePrice;
		private System.Windows.Forms.Label label_ServiceName;
		private System.Windows.Forms.Button button_CreateServiceAdd;
		private System.Windows.Forms.Label label_CreateServiceTitle;
		private System.Windows.Forms.NumericUpDown numericUpDown_Price;
		private System.Windows.Forms.CheckBox checkBox_SaveService;
	}
}