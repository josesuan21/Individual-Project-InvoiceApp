namespace Invoice_Application_Project
{
	partial class ViewUpdate_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUpdate_Form));
			this.label1 = new System.Windows.Forms.Label();
			this.button_Customer = new System.Windows.Forms.Button();
			this.button_Services = new System.Windows.Forms.Button();
			this.button_Invoice = new System.Windows.Forms.Button();
			this.button_Back = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(109, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select a record";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_Customer
			// 
			this.button_Customer.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button_Customer.Location = new System.Drawing.Point(127, 83);
			this.button_Customer.Name = "button_Customer";
			this.button_Customer.Size = new System.Drawing.Size(139, 51);
			this.button_Customer.TabIndex = 1;
			this.button_Customer.Text = "Customer";
			this.button_Customer.UseVisualStyleBackColor = false;
			this.button_Customer.Click += new System.EventHandler(this.Button_Customer_Click);
			// 
			// button_Services
			// 
			this.button_Services.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button_Services.Location = new System.Drawing.Point(127, 143);
			this.button_Services.Name = "button_Services";
			this.button_Services.Size = new System.Drawing.Size(139, 51);
			this.button_Services.TabIndex = 2;
			this.button_Services.Text = "Services";
			this.button_Services.UseVisualStyleBackColor = false;
			this.button_Services.Click += new System.EventHandler(this.Button_Services_Click);
			// 
			// button_Invoice
			// 
			this.button_Invoice.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button_Invoice.Location = new System.Drawing.Point(127, 203);
			this.button_Invoice.Name = "button_Invoice";
			this.button_Invoice.Size = new System.Drawing.Size(139, 51);
			this.button_Invoice.TabIndex = 3;
			this.button_Invoice.Text = "Invoice";
			this.button_Invoice.UseVisualStyleBackColor = false;
			this.button_Invoice.Click += new System.EventHandler(this.Button_Invoice_Click);
			// 
			// button_Back
			// 
			this.button_Back.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button_Back.Location = new System.Drawing.Point(12, 350);
			this.button_Back.Name = "button_Back";
			this.button_Back.Size = new System.Drawing.Size(93, 34);
			this.button_Back.TabIndex = 5;
			this.button_Back.Text = "Back to Menu";
			this.button_Back.UseVisualStyleBackColor = false;
			this.button_Back.Click += new System.EventHandler(this.Button_Back_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button1.Location = new System.Drawing.Point(127, 262);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(139, 52);
			this.button1.TabIndex = 6;
			this.button1.Text = "Service Chosen";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// ViewUpdate_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(408, 397);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button_Back);
			this.Controls.Add(this.button_Invoice);
			this.Controls.Add(this.button_Services);
			this.Controls.Add(this.button_Customer);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ViewUpdate_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "View Records";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewUpdate_Form_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_Customer;
		private System.Windows.Forms.Button button_Services;
		private System.Windows.Forms.Button button_Invoice;
		private System.Windows.Forms.Button button_Back;
		private System.Windows.Forms.Button button1;
	}
}