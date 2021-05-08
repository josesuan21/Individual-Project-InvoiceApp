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
			this.button_Statistic = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ComapanyLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// label_Welcome
			// 
			this.label_Welcome.AutoSize = true;
			this.label_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Welcome.ForeColor = System.Drawing.Color.Black;
			this.label_Welcome.Location = new System.Drawing.Point(159, 161);
			this.label_Welcome.Name = "label_Welcome";
			this.label_Welcome.Size = new System.Drawing.Size(98, 24);
			this.label_Welcome.TabIndex = 0;
			this.label_Welcome.Text = "Welcome";
			// 
			// label_to
			// 
			this.label_to.AutoSize = true;
			this.label_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_to.ForeColor = System.Drawing.Color.Black;
			this.label_to.Location = new System.Drawing.Point(193, 185);
			this.label_to.Name = "label_to";
			this.label_to.Size = new System.Drawing.Size(27, 24);
			this.label_to.TabIndex = 1;
			this.label_to.Text = "to";
			// 
			// label_ShineMaster
			// 
			this.label_ShineMaster.AutoSize = true;
			this.label_ShineMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_ShineMaster.ForeColor = System.Drawing.Color.Black;
			this.label_ShineMaster.Location = new System.Drawing.Point(84, 205);
			this.label_ShineMaster.Name = "label_ShineMaster";
			this.label_ShineMaster.Size = new System.Drawing.Size(249, 24);
			this.label_ShineMaster.TabIndex = 2;
			this.label_ShineMaster.Text = "Shine Master Invoice App";
			// 
			// button_CreateInvoice
			// 
			this.button_CreateInvoice.BackColor = System.Drawing.SystemColors.Control;
			this.button_CreateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CreateInvoice.ForeColor = System.Drawing.Color.Black;
			this.button_CreateInvoice.Location = new System.Drawing.Point(138, 253);
			this.button_CreateInvoice.Name = "button_CreateInvoice";
			this.button_CreateInvoice.Size = new System.Drawing.Size(139, 51);
			this.button_CreateInvoice.TabIndex = 3;
			this.button_CreateInvoice.Text = "Create Invoice";
			this.button_CreateInvoice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button_CreateInvoice.UseVisualStyleBackColor = false;
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
			this.button_UpdateRecord.BackColor = System.Drawing.SystemColors.Control;
			this.button_UpdateRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_UpdateRecord.ForeColor = System.Drawing.Color.Black;
			this.button_UpdateRecord.Location = new System.Drawing.Point(138, 315);
			this.button_UpdateRecord.Name = "button_UpdateRecord";
			this.button_UpdateRecord.Size = new System.Drawing.Size(139, 51);
			this.button_UpdateRecord.TabIndex = 5;
			this.button_UpdateRecord.Text = "View Records\r\n";
			this.button_UpdateRecord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button_UpdateRecord.UseVisualStyleBackColor = false;
			this.button_UpdateRecord.Click += new System.EventHandler(this.Button_UpdateRecord_Click);
			// 
			// button_Statistic
			// 
			this.button_Statistic.BackColor = System.Drawing.SystemColors.Control;
			this.button_Statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Statistic.ForeColor = System.Drawing.Color.Black;
			this.button_Statistic.Location = new System.Drawing.Point(138, 376);
			this.button_Statistic.Name = "button_Statistic";
			this.button_Statistic.Size = new System.Drawing.Size(139, 51);
			this.button_Statistic.TabIndex = 6;
			this.button_Statistic.Text = "Statistic Report";
			this.button_Statistic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button_Statistic.UseVisualStyleBackColor = false;
			this.button_Statistic.Click += new System.EventHandler(this.Button_Statistic_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(191, 399);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 25);
			this.label3.TabIndex = 9;
			this.label3.Text = "📈";
			this.label3.Click += new System.EventHandler(this.Label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(191, 338);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 25);
			this.label2.TabIndex = 8;
			this.label2.Text = "📂";
			this.label2.Click += new System.EventHandler(this.Label2_Click);
			// 
			// label1
			// 
			this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(192, 276);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "🧾";
			this.label1.Click += new System.EventHandler(this.Label1_Click);
			// 
			// Form_Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(416, 452);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_Statistic);
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
		private System.Windows.Forms.Button button_Statistic;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

