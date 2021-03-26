using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_Application_Project.Views
{
	public interface IPaymentDetails
	{
		int PaymentId_Text { get; set; }
		string PaymentDetails_Text { get; set; }

	}
}
