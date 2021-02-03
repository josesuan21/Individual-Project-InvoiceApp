using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Application_Project
{
	public partial class Invoice_Form : Form
	{
		public Invoice_Form()
		{
			InitializeComponent();
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			//Show services details section
			groupBox_ServicesDetails.Visible = true;
			//Position the form to extend the top
			this.StartPosition = FormStartPosition.Manual;
			this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			//Show payment details section
			groupBox_PaymentDetails.Visible = true;

			//Position the form to extend the top
			this.StartPosition = FormStartPosition.Manual;
			this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			//Show Confirmation section
			groupBox_Confirmation.Visible = true;

			//Position the form to extend the top
			this.StartPosition = FormStartPosition.Manual;
			this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
		}

		private void CheckBox_ApplyDiscount_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_ApplyDiscount.Checked) {
				textBox_Discount.Visible = true;
			}
			else
			{
				textBox_Discount.Visible = false;
			}
		}
	}
}
