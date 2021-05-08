Ticket 039.1(1-4) - (Statistics) Statisc form and Graphs
=======================
Create a report graphs to show the status of the business based from the database. 

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
Simply show basic statistic report that will help the business

* UI to follow

![](https://i.imgur.com/bahpu68.png)



Techical Notes
--------------
* Try to create view and make it as a dataset to display on the chart where it simply counts the total

Ticket 39.1.1 - Show Loyal Customer Graph
---
* Loyal Customers
```sql=
SELECT CONCAT(c.customerName,'(',c.customerId,')') AS 'Customer Name(ID)', COUNT(sc.customerId) AS 'TotalServiceMade'

FROM Customer c

INNER JOIN ServiceChosen sc

ON sc.customerId = c.customerId

GROUP BY CONCAT(c.customerName,'(',c.customerId,')');
```
* Size = 1


Ticket 39.1.2 - Show popular areas Graph
---
* Popular Area 

```sql=
SELECT c.postCode, Count(c.customerId) as 'Total'

FROM ServiceChosen sc

INNER JOIN Customer c

ON c.customerId = sc.customerId

GROUP BY c.postCode;
```
* Size = 1

Ticket 39.1.3 - Show used services
---
* Used service (ServiceChosen)
```sql=
SELECT s.serviceId,s.serviceName, COUNT(sc.serviceId) AS 'Total service used'

FROM Service s

INNER JOIN ServiceChosen sc

ON s.serviceId = sc.serviceId

GROUP BY s.serviceId,s.serviceName;
```
* Size = 1


Ticket 39.1.4 - Show current year income
---
* Total income for this Year (Invoice Record)

```sql=
SELECT ir.date, SUM(ir.totalPrice) AS 'Total Income'

FROM InvoiceRecord ir

WHERE YEAR(ir.date) = YEAR(GETDATE())

GROUP BY ir.date;
```
* Size = 1


Size + Engineering notes
----------------------
| Size | Engineering notes | 
| -------- | -------- |
| 2  | | 
