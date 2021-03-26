using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Invoice_Application_Project.Models;
using Invoice_Application_Project.Views;

namespace Invoice_Application_Project.Presenters
{
	class PdfPresenter
	{
		IPdf pdfView;
		Pdf pdf = new Pdf();

		public PdfPresenter(IPdf view) {
			pdfView = view;

		}

		public bool SavePDF(ListView item) {

			bool flagSuccessSave = false;

			//Get all values from UI form to pdf class fields
			pdf.InvoiceId = pdfView.PDFinvoiceId_Text;
			pdf.InvoiceDate = pdfView.PDFdate_Text;
			pdf.InvoiceDueDate = pdfView.PDFduedate_Text;
			pdf.InvoiceCustomerName = pdfView.PDFcustomerName_Text;
			pdf.InvoiceEmail = pdfView.PDFemail_Text;
			pdf.InvoiceAddress = pdfView.PDFaddress_Text;
			pdf.InvoicePostcode = pdfView.PDFpostCode_Text;
			pdf.InvoiceNotes = pdfView.PDFnotes_Text;
			pdf.InvoicePaymentDetails_1 = pdfView.PDFnotes_PaymentTransfer;
			pdf.InvoicePaymentDetails_2 = pdfView.PDFnotes_PaymentCheque;
			pdf.InvoiceDiscountGiven = pdfView.PDFdiscountGiven_Text;
			pdf.InvoiceTotalPrice = pdfView.PDFtotalPrice_Text;


			flagSuccessSave =  pdf.SaveInvoiceToPDF(item);

			return flagSuccessSave;

		}



	}

}
