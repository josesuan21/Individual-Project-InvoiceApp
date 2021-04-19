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
				button_AddData.Enabled = true;
				button_RemoveData.Enabled = true;
				button_Next.Enabled = true;
				button_backwithpoint.Enabled = true;
			}
			else
			{
				button_AddData.Enabled = false;
				button_RemoveData.Enabled = false;
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

		private void Button_AddData_Click(object sender, EventArgs e)
		{
			//Create a new record
			this.invoiceRecordBindingSource.AddNew();
			invoiceRecordIdTextBox.Text = "###";
			//Focus name
			discountGivenTextBox.Focus();
			//Done button true
			button_Done.Visible = true;
			//Buttons to false
			EnableState_Buttons(false);
			//Update button to false
			button_update.Visible = false;
			//textfields to true
			EnableState_TextFields(true);
		}

		private void Button_RemoveData_Click(object sender, EventArgs e)
		{
			this.invoiceRecordBindingSource.RemoveCurrent();
			SaveData();
		}

		private void Button_backwithpoint_Click(object sender, EventArgs e)
		{
			this.invoiceRecordBindingSource.MovePrevious();
		}

		private void Button_Done_Click(object sender, EventArgs e)
		{
			this.invoiceRecordBindingSource.AddNew();
			this.invoiceRecordBindingSource.RemoveCurrent();
			button_Done.Visible = false;
			button_update.Visible = true;
			EnableState_Buttons(true);
			EnableState_TextFields(false);
			SaveData();
		}

		private void Button_update_Click(object sender, EventArgs e)
		{
			EnableState_TextFields(true);
			button_update.Visible = false;
			button_Done.Visible = true;
			EnableState_Buttons(false);
		}

		private void TextBox_search_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.invoiceRecordTableAdapter.SearchInvoiceId(this.invoiceDatabaseDataSet1.InvoiceRecord, ((int)(System.Convert.ChangeType(textBox_search.Text, typeof(int)))));
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}

		private void TextBox_search_MouseClick(object sender, MouseEventArgs e)
		{
			textBox_search.Clear();
		}
	}
}
