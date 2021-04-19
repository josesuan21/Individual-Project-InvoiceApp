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
	public partial class CustomerRecord_Form : Form
	{
		public CustomerRecord_Form()
		{
			InitializeComponent();
		}

		private void CustomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.customerBindingSource.EndEdit();


		}

		private void CustomerRecord_Form_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'invoiceDatabaseDataSet1.Customer' table. You can move, or remove it, as needed.
			this.customerTableAdapter.Fill(this.invoiceDatabaseDataSet1.Customer);

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			ViewUpdate_Form viewUpdate_Form = new ViewUpdate_Form();
			viewUpdate_Form.Show();
			this.Close();
		}

		private void CustomerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
		{
			SaveData();

		}

		private void Button_Next_Click(object sender, EventArgs e)
		{
			this.customerBindingSource.MoveNext();
		}

		private void Button_backwithpoint_Click(object sender, EventArgs e)
		{
			this.customerBindingSource.MovePrevious();
		}

		//To add new data
		private void Button_AddData_Click(object sender, EventArgs e)
		{	
			//Create a new record
			this.customerBindingSource.AddNew();
			customerIdTextBox.Text = "###";
			//Focus name
			customerNameTextBox.Focus();
			//Done button true
			button_Done.Visible = true;
			//Buttons to false
			EnableState_Buttons(false);
			//Update button to false
			button_update.Visible = false;
			//textfields to true
			EnableState_TextFields(true);

		}

		//To remove data
		private void Button_RemoveData_Click(object sender, EventArgs e)
		{
			this.customerBindingSource.RemoveCurrent();
			SaveData();
		}

		//Done 
		private void Button_Done_Click(object sender, EventArgs e)
		{
			this.customerBindingSource.AddNew();
			this.customerBindingSource.RemoveCurrent();
			button_Done.Visible = false;
			button_update.Visible = true;
			EnableState_Buttons(true);
			EnableState_TextFields(false);
			SaveData();

		}

		//Save method
		public void SaveData() {
			this.Validate();
			this.customerBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.invoiceDatabaseDataSet1);
		}

		//Disable major buttons
		public void EnableState_Buttons(bool result) {

			if (result) {
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
		public void EnableState_TextFields(bool result) {

			if (result) {
				customerNameTextBox.Enabled = true;
				emailTextBox.Enabled = true;
				addressTextBox.Enabled = true;
				postCodeTextBox.Enabled = true;
			}
			else
			{
				customerNameTextBox.Enabled = false;
				emailTextBox.Enabled = false;
				addressTextBox.Enabled = false;
				postCodeTextBox.Enabled = false;
			}

		}

		//To update
		private void Button_update_Click(object sender, EventArgs e)
		{
			EnableState_TextFields(true);
			button_update.Visible = false;
			button_Done.Visible = true;
			EnableState_Buttons(false);
		}

		private void TextBox_search_MouseClick(object sender, MouseEventArgs e)
		{
			textBox_search.Clear();
		}

		private void TextBox_search_TextChanged(object sender, EventArgs e)
		{
			//Filter
			try
			{
				this.customerTableAdapter.SearchName(this.invoiceDatabaseDataSet1.Customer, textBox_search.Text);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}


	}
}
