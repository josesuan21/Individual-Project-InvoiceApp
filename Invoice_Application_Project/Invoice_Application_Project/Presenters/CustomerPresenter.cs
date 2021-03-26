﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Invoice_Application_Project.Models;
using Invoice_Application_Project.Views;

namespace Invoice_Application_Project.Presenters
{
	public class CustomerPresenter
	{

		ICustomer customerView;

		Customer customer = new Customer();

		//constructor

		public CustomerPresenter(ICustomer view) {

			customerView = view;

		}


		//Methods

		public void CreateCustomerId() {
			//Execute customer method to create Id
			customer.createCustomerId();
		}

		public void SaveCustomerDetails() {
			//Assigning values from Views to model fields
			customer.CustomerId = customerView.CustomerId_Text;
			customer.CustomerName = customerView.CustomerName_Text;
			customer.CustomerEmail = customerView.CustomerEmail_Text;
			customer.CustomerAddress = customerView.CustomerAddress_Text;
			customer.CustomerPostcode = customerView.CustomerPostcode_Text;

			//Execute  the save customer details
			customer.saveCustomerDetails();
		}

		public int GetCustomerId() {

			return customer.CustomerId;
		}

		public void RemoveDefaultAdded_CustomerRecord(){

			customer.RemoveDefaultAdded_CustomerRecord();

		}


	}

}