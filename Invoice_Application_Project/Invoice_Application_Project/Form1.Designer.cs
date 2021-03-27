namespace Invoice_Application_Project
{
	partial class Form_Menu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
			this.label_Welcome = new System.Windows.Forms.Label();
			this.label_to = new System.Windows.Forms.Label();
			this.label_ShineMaster = new System.Windows.Forms.Label();
			this.button_CreateInvoice = new System.Windows.Forms.Button();
			this.pictureBox_ComapanyLogo = new System.Windows.Forms.PictureBox();
			this.button_UpdateRecord = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ComapanyLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// label_Welcome
			// 
			this.label_Welcome.AutoSize = true;
			this.label_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Welcome.Location = new System.Drawing.Point(163, 165);
			this.label_Welcome.Name = "label_Welcome";
			this.label_Welcome.Size = new System.Drawing.Size(82, 20);
			this.label_Welcome.TabIndex = 0;
			this.label_Welcome.Text = "Welcome";
			// 
			// label_to
			// 
			this.label_to.AutoSize = true;
			this.label_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_to.Location = new System.Drawing.Point(194, 185);
			this.label_to.Name = "label_to";
			this.label_to.Size = new System.Drawing.Size(25, 20);
			this.label_to.TabIndex = 1;
			this.label_to.Text = "to";
			// 
			// label_ShineMaster
			// 
			this.label_ShineMaster.AutoSize = true;
			this.label_ShineMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_ShineMaster.Location = new System.Drawing.Point(103, 205);
			this.label_ShineMaster.Name = "label_ShineMaster";
			this.label_ShineMaster.Size = new System.Drawing.Size(214, 20);
			this.label_ShineMaster.TabIndex = 2;
			this.label_ShineMaster.Text = "Shine Master Invoice App";
			// 
			// button_CreateInvoice
			// 
			this.button_CreateInvoice.Location = new System.Drawing.Point(138, 250);
			this.button_CreateInvoice.Name = "button_CreateInvoice";
			this.button_CreateInvoice.Size = new System.Drawing.Size(139, 51);
			this.button_CreateInvoice.TabIndex = 3;
			this.button_CreateInvoice.Text = "Create Invoice";
			this.button_CreateInvoice.UseVisualStyleBackColor = true;
			this.button_CreateInvoice.Click += new System.EventHandler(this.Button1_Click);
			// 
			// pictureBox_ComapanyLogo
			// 
			this.pictureBox_ComapanyLogo.Image = global::Invoice_Application_Project.Properties.Resources.smIcon_Transparent_;
			this.pictureBox_ComapanyLogo.Location = new System.Drawing.Point(72, 12);
			this.pictureBox_ComapanyLogo.Name = "pictureBox_ComapanyLogo";
			this.pictureBox_ComapanyLogo.Size = new System.Drawing.Size(276, 138);
			this.pictureBox_ComapanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_ComapanyLogo.TabIndex = 4;
			this.pictureBox_ComapanyLogo.TabStop = false;
			// 
			// button_UpdateRecord
			// 
			this.button_UpdateRecord.Location = new System.Drawing.Point(138, 324);
			this.button_UpdateRecord.Name = "button_UpdateRecord";
			this.button_UpdateRecord.Size = new System.Drawing.Size(139, 51);
			this.button_UpdateRecord.TabIndex = 5;
			this.button_UpdateRecord.Text = "View and Update Records";
			this.button_UpdateRecord.UseVisualStyleBackColor = true;
			this.button_UpdateRecord.Click += new System.EventHandler(this.Button_UpdateRecord_Click);
			// 
			// Form_Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 436);
			this.Controls.Add(this.button_UpdateRecord);
			this.Controls.Add(this.pictureBox_ComapanyLogo);
			this.Controls.Add(this.button_CreateInvoice);
			this.Controls.Add(this.label_ShineMaster);
			this.Controls.Add(this.label_to);
			this.Controls.Add(this.label_Welcome);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_Menu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " Main Menu ";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ComapanyLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_Welcome;
		private System.Windows.Forms.Label label_to;
		private System.Windows.Forms.Label label_ShineMaster;
		private System.Windows.Forms.Button button_CreateInvoice;
		private System.Windows.Forms.PictureBox pictureBox_ComapanyLogo;
		private System.Windows.Forms.Button button_UpdateRecord;
	}
}

