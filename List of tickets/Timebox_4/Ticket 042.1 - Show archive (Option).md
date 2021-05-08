Ticket 042.1 - Show archive (Option)
=======================
Create a new form that shows the list of all updated service records. So that the user would be able to check the history of the things that have been changed so it would not be lost based on the records of the other invoices.

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
        * N/A 

Coditions of Success
---------------------
* Create a table called Old_ServiceRecord

Techical Notes
--------------

CREATE TABLE [dbo].[Old_ServiceRecord]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [previousId] INT NOT NULL, 
    [serviceName] VARCHAR(35) NOT NULL, 
    [servicePrice] SMALLMONEY NOT NULL, 
    [dateAdded] DATE NOT NULL DEFAULT GETDATE()
)




Size + Engineering notes
----------------------
| Size | Engineering notes | 
| -------- | -------- |
| 1  |  1 | 
