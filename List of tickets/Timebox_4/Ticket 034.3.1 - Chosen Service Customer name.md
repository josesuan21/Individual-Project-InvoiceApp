Ticket 034.3.1 - Chosen Service Customer name
=======================
Show in chosen customer service name the name of the customer inside the datagridview so that the data is readable and be able to know whos customer chosen a specific service.

Related Tickets
---------------

* Requierd depedencies
    * **Timebox 1**
        * All
    * **Timebox 2**
        * All
    * **Timebox 3**
        * All
    * **Timebox 4**
        * Ticket 34.1, 34, BUG 006

Coditions of Success
---------------------
Ensure that the id of the customer is not displayed but the name instead.


Techical Notes
--------------
* Query for making columns readable

```sql=
SELECT serviceChosenId as 'Id', s.serviceName as 'Service Name' ,CONCAT(C.customerId,' --- ',c.customerName) as 'Customer ID / Name', invoiceRecordId as 'Invoice Id' 

FROM dbo.ServiceChosen

INNER JOIN dbo.Customer c

ON dbo.ServiceChosen.customerId = c.customerId

INNER JOIN dbo.Service s

ON dbo.ServiceChosen.serviceId = s.serviceId;
```


* C# code

```c#

			//Loading data from ChosenService
			SqlConnection connection;
			string connectionString = ConfigurationManager.ConnectionStrings["Invoice_Application_Project.Properties.Settings.InvoiceDatabaseConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);
			connection.Open();
			//Query
			string sqlServiceChosen_CustomQuery = "SELECT serviceChosenId as 'Id', s.serviceName as 'Service Name' ,CONCAT(C.customerId,' --- ',c.customerName) as 'Customer ID / Name', invoiceRecordId as 'Invoice Id' ";
			sqlServiceChosen_CustomQuery += "FROM dbo.ServiceChosen INNER JOIN dbo.Customer c ON dbo.ServiceChosen.customerId = c.customerId INNER JOIN dbo.Service s ON dbo.ServiceChosen.serviceId = s.serviceId";


			SqlCommand cmd = new SqlCommand(sqlServiceChosen_CustomQuery,connection);

			SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

			DataTable dataTable = new DataTable();

			sqlData.Fill(dataTable);

			dataGridView_ServiceChosen.DataSource = dataTable;

			connection.Close();


```



Size + Engineering notes
----------------------
| Size | Engineering notes | 
| -------- | -------- |
| 1  | Only requires to do inner join selection | 
