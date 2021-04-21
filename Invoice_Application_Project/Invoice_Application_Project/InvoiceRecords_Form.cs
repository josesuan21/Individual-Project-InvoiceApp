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
	public partial class InvoiceRecords_Form : Form
	{
		public InvoiceRecords_Form()
		{
			InitializeComponent();
		}

		private void InvoiceRecordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.invoiceRecordBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.invoiceDatabaseDataSet1);

		}

		private void InvoiceRecords_Form_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'invoiceDatabaseDataSet1.InvoiceRecord' table. You can move, or remove it, as needed.
			this.invoiceRecordTableAdapter.Fill(this.invoiceDatabaseDataSet1.InvoiceRecord);

		}

		private void Button_Back_Click(object sender, EventArgs e)
		{
			ViewUpdate_Form viewUpdate_Form = new ViewUpdate_Form();
			viewUpdate_Form.Show();
			this.Close();
		}

		//Disable major buttons
		public void EnableState_Buttons(bool result)
		{

			if (result)
			{
				button_Next.Enabled = true;
				button_backwithpoint.Enabled = true;
			}
			else
			{
				button_Next.Enabled = false;
				button_backwithpoint.Enabled = false;
			}
		}
		//Disable Textfields 
		public void EnableState_TextFields(bool result)
		{

			if (result)
			{
				invoiceRecordIdTextBox.Enabled = true;
				discountGivenTextBox.Enabled = true;
				totalPriceTextBox.Enabled = true;
				notesTextBox.Enabled = true;
				dateDateTimePicker.Enabled = true;
				duedateDateTimePicker.Enabled = true;
			}
			else
			{
				invoiceRecordIdTextBox.Enabled = false;
				discountGivenTextBox.Enabled = false;
				totalPriceTextBox.Enabled = false;
				notesTextBox.Enabled = false;
				dateDateTimePicker.Enabled = false;
				duedateDateTimePicker.Enabled = false; 
			}

		}
		//Save method
		public void SaveData()
		{
			this.Validate();
			this.invoiceRecordBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.invoiceDatabaseDataSet1);
		}

		private void Button_Next_Click(object sender, EventArgs e)
		{
			this.invoiceRecordBindingSource.MoveNext();
		}



		private void Button_backwithpoint_Click(object sender, EventArgs e)
		{
			this.invoiceRecordBindingSource.MovePrevious();
		}


		private void TextBox_search_TextChanged(object sender, EventArgs e)
		{
			//Checks whether the textbox is a number
			int parsedValue;
			if (int.TryParse(textBox_search.Text, out parsedValue)) {
				try
				{
					this.invoiceRecordTableAdapter.SearchInvoiceId(this.invoiceDatabaseDataSet1.InvoiceRecord, ((int)(System.Convert.ChangeType(textBox_search.Text, typeof(int)))));
				}
				catch (System.Exception ex)
				{
					System.Windows.Forms.MessageBox.Show(ex.Message);
				}
			}
		}

		private void TextBox_search_MouseClick(object sender, MouseEventArgs e)
		{
			textBox_search.Clear();
		}

		private void TextBox_search_Click(object sender, EventArgs e)
		{
			textBox_search.Text = "";
		}

		private void TextBox_search_Leave(object sender, EventArgs e)
		{
			textBox_search.Text = "🔍 Search Invoice No";
			this.invoiceRecordTableAdapter.Fill(this.invoiceDatabaseDataSet1.InvoiceRecord);
		}
	}
}
