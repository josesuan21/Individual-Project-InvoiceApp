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
	public partial class ServiceRecords_Form : Form
	{
		public ServiceRecords_Form()
		{
			InitializeComponent();
		}

		private void ServiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.serviceBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.invoiceDatabaseDataSet1);

		}

		private void ServiceRecords_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'invoiceDatabaseDataSet1.Service' table. You can move, or remove it, as needed.
			this.serviceTableAdapter.Fill(this.invoiceDatabaseDataSet1.Service);

		}

		private void Button_Back_Click(object sender, EventArgs e)
		{
			ViewUpdate_Form viewUpdate_Form = new ViewUpdate_Form();
			viewUpdate_Form.Show();
			this.Close();
		}

		private void Button_backwithpoint_Click(object sender, EventArgs e)
		{
			this.serviceBindingSource.MovePrevious();
		}

		private void Button_Next_Click(object sender, EventArgs e)
		{
			this.serviceBindingSource.MoveNext();
		}

		private void Button_AddData_Click(object sender, EventArgs e)
		{
			//Create a new record
			this.serviceBindingSource.AddNew();
			serviceIdTextBox.Text = "###";
			//Focus name
			serviceNameTextBox.Focus();
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
			this.serviceBindingSource.RemoveCurrent();
			SaveData();
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
				serviceIdTextBox.Enabled = true;
				serviceNameTextBox.Enabled = true;
				priceTextBox.Enabled = true;
			}
			else
			{
				serviceIdTextBox.Enabled = false;
				serviceNameTextBox.Enabled = false;
				priceTextBox.Enabled = false;
			}

		}
		//Save method
		public void SaveData()
		{
			this.Validate();
			this.serviceBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.invoiceDatabaseDataSet1);
		}

		private void Button_Done_Click(object sender, EventArgs e)
		{
			this.serviceBindingSource.AddNew();
			this.serviceBindingSource.RemoveCurrent();
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
				this.serviceTableAdapter.SearchService(this.invoiceDatabaseDataSet1.Service, textBox_search.Text);
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
