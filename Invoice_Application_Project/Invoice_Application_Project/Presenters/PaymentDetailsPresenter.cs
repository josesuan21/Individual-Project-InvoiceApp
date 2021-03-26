using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Invoice_Application_Project.Models;
using Invoice_Application_Project.Views;
namespace Invoice_Application_Project.Presenters
{
	class PaymentDetailsPresenter
	{

		IPaymentDetails paymentView;
		PaymentDetails paymentDetails = new PaymentDetails();


		public PaymentDetailsPresenter(IPaymentDetails view) {

			paymentView = view;

		}

		//Methods
		public string GetDirectTransfer (){

			return paymentDetails.LoadPaymentDetails_1();

		}

		public string GetChequePayment() {

			return paymentDetails.LoadPaymentDetails_2();

		}



	}
}
