using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_Application_Project.Views
{
	public interface IService
	{
		int ServiceId_Text { get; set; }
		string ServiceName_Text { get; set; }
		decimal ServicePrice_Text { get; set; }

	}

}
