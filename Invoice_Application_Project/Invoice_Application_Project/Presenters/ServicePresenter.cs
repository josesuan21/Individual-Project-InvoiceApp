using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoice_Application_Project.Models;
using Invoice_Application_Project.Views;

namespace Invoice_Application_Project.Presenters
{
	public class ServicePresenter
	{
		IService serviceView;
		Service service = new Service();

		//Constructor
		public ServicePresenter(IService view) {

			serviceView = view;

		}


		//Methods
		public ArrayList ShowListServices() {

			return service.ShowListServices();
		}

		public ListViewItem AddService(ListViewItem item) {

			return service.AddService(item);
		}

		public void AddRecord_ServiceChosen(int currentCustomer, int currentInvoiceId, ListView items) {

			service.AddRecord_ServiceChosen(currentCustomer, currentInvoiceId, items);

		}

		public decimal CalculatePrice(ListView list) {

			return service.CalculatePrice(list);

		}

		public decimal CalculateDiscountPrice(string inputCurrentPrice, decimal discountVal) {

			return service.CalculateDiscountPrice(inputCurrentPrice, discountVal);

		}

		public void RemoveServiceItem(ListView.SelectedListViewItemCollection serviceInput, ListView listView_Services) {

			service.RemoveServiceItem(serviceInput,listView_Services);

		}

		public void RemoveChosenServiceRecord(ListView items) {
			service.RemoveChosenServiceRecord(items);

		}

		public void SaveNew_Service(string name, decimal price) {
			service.SaveService_Database(name, price);
		}

		public decimal CalculateVAT(string inputCurrentPrice, decimal vat_VAL) {
			return service.CalculateVAT(inputCurrentPrice, vat_VAL);
		}



	}

}
