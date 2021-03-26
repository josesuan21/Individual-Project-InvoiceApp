using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_Application_Project.Views
{
	public interface IinvoiceRecord
	{
		int InvoiceId_Text { get; set; } //Atm this one does not needed to get or set any of the UI form... Think of it useful for other features
		decimal InvoiceDiscount_Text { get; set; }
		decimal InvoiceTotalPrice_Text { get; set; }
		string InvoiceNote_Text { get; set; }
		DateTime InvoiceDate_Text { get; set; }
		DateTime InvoiceDueDate_Text { get; set; }
	}

}
