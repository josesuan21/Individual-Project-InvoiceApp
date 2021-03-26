using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_Application_Project.Views
{
	public interface IPdf
	{
		string PDFinvoiceId_Text { get; set; }
		DateTime PDFdate_Text { get; set; }
		DateTime PDFduedate_Text { get; set; }
		string PDFcustomerName_Text { get; set; }
		string PDFemail_Text { get; set; }
		string PDFaddress_Text { get; set; }
		string PDFpostCode_Text { get; set; }
		string PDFnotes_Text { get; set; }
		string PDFnotes_PaymentTransfer { get; set; }
		string PDFnotes_PaymentCheque { get; set; }
		string PDFdiscountGiven_Text { get; set; }
		string PDFtotalPrice_Text { get; set; }


	}

}
