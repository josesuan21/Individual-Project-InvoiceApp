Ticket 042 - Save old service price details in the archive storage
=======================
Once the old service price is changed, save a copy into a table where it acts as an archive. 

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
| 1  |   | 
