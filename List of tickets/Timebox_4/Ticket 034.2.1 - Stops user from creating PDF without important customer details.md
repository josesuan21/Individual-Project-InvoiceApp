Ticket 034.2.1 - Stops user from creating PDF without important customer details
=======================

Stops user to create a PDF invoice if the fields for Customer is not filled. 


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

Coditions of Success
--------------------
* If the fields for customer details, the user must stop to continue saving an invoice.  
    * Name
    * Address
    * Post code 

* Once the user clicks the PDF button, it should show a tool tip what are the missing fields and must stop the user to create a PDF. 
    * (OR Red text is good)


Techical Notes
--------------
* Ensure the function does not let create customer or invoice in the database. 


Size + Engineering notes
----------------------
| Size | Engineering notes | 
| -------- | -------- |
| 1  | | 
