using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Invoice_Application_Project.Models;
using Invoice_Application_Project.Views;

namespace Invoice_Application_Project.Presenters
{
	public class InvoiceRecordPresenter
	{
		IinvoiceRecord iinvoiceRecordView;
		InvoiceRecord invoiceRecord = new InvoiceRecord();

		public InvoiceRecordPresenter(IinvoiceRecord view)
		{
			iinvoiceRecordView = view;
		}

		public void CreateInvoiceId() {

			//To get the date from UI form
			invoiceRecord.InvoiceDate = iinvoiceRecordView.InvoiceDate_Text;
			invoiceRecord.InvoiceDueDate = iinvoiceRecordView.InvoiceDueDate_Text;

			invoiceRecord.InvoiceNumber_Creator();

		}

		public int GetInvoiceId() {
			return invoiceRecord.InvoiceId;
		}

		public void AddNotes() {

			invoiceRecord.InvoiceId = iinvoiceRecordView.InvoiceId_Text; //Id is needed because you want to get the current id from the form
			invoiceRecord.InvoiceNotes = iinvoiceRecordView.InvoiceNote_Text;

			invoiceRecord.AddNotes();
		}

		public void SaveTotalPrice_Discount() {
			invoiceRecord.InvoiceId = iinvoiceRecordView.InvoiceId_Text;
			invoiceRecord.InvoiceTotalPrice = iinvoiceRecordView.InvoiceTotalPrice_Text;
			invoiceRecord.InvoiceDiscount = iinvoiceRecordView.InvoiceDiscount_Text;

			invoiceRecord.SaveTotalPrice_DisocuntVal();

		}


		public void RemoveDefaultAdded_InvoiceRecord()
		{
			invoiceRecord.RemoveDefaultAdded_InvoiceRecord();
		}

	}

}
