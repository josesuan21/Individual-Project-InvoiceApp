using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_Application_Project.Views
{
	public interface ICustomer
	{
		//These will be used directly for the UI form to get the values from the controllers
		int CustomerId_Text { get; set;}
		string CustomerName_Text { get; set;}
		string CustomerEmail_Text { get; set;}
		string CustomerAddress_Text { get; set;}
		string CustomerPostcode_Text { get; set; }
	}

}
