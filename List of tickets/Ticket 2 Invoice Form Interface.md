Ticket 2:  Invoice Form Interface
=======================

After the user has clicked the create button from the Main menu form, this form needs to be displayed and contains five sections with important controls that will guide the user for completing the form. 

Initially, this form only requires creating and showing the interface without any functions that accepts the data because other tickets will do those tasks. 

This ticket must be an easy to follow steps by completing the form for the user and easily to understand each sections purpose. 


Related Tickets
---------------
* Requierd depedencies
    * [001](./001.md) - Main Menu

Coditions of Success
--------------------
* The invoice form interface must be viewed by the user and must contain five sections.
* Each section must be group as a **container** *except for the header* so that users would be able to identify what details they are in the form. 
* The Following are the list of sections with the items; this must be followed in this order:
    * **Header** 
        * Company Logo 
            * A picture box control, located at upper left side of window form
        * Invoice number
            *  A textbox with label *Invoice number* located next line of the logo
        * Date
            * A date time picker control, located at the upper right side of window form.
    * **Recipient details** 
        * Customer Name 
            * A textbox with label *"Customer name"*
        * Address
            * A multi-textbox with label *"Address"*
        * Post code
            * A textbox with label *"Post code"*
        * Next button
            * A button with text *"Next"*
    * **Services details** 
        * List of services
            *  ComboBox with text "Choose service" and 5 default items:
             (Carpet cleaning, End of Tenancy, Oven cleaning, Communal cleaning, Other )
        * Add list button
            *  button with label text *"Add"*
        * A table of added services
            *  list view with *services* and *price* columns
        * Current price
            *  Textbox with label text *"Current price"*
            *  Read only property is set as "True"
        * Discount 
            * A Check box with text as *"Apply discount (%)"* and followed by a textbox to enter the discount value. 
            * Textbox visibility property is set as false.
            * Once the check box is tick, the textbox visibility property is set as true.
        * Total price 
            * Textbox with label text *"Total price"*
            * Read only property is set as "True"
        * Next button
            * A button with text *"Next"*
    * **Payment details**
        * Direct transfer details
        * Cheque payment details
            * A multi-textbox with blank text
        * Next button
            * A button with text *"Next"*
    * **Confirmation**
        * Save PDF button
            * A button with tex *"Save PDF"*


Techical Notes
--------------
* This is targeted as a graphical interface to match common MSWindows patterns.
*  The user should be able to operate this ticket with limited knowlege experince and easy to follow the form. 
*  The form must be displayed in the center screen and not sizable. The form must only show visible content and  Maximize Box property is set as false. 
* The form must contain the company's icon.
* The window form's property text must be: "Invoice Form".
* All controls and form properties must follow the standard naming convention: (**Control name_name**) e.g. "groupBox_ServiceDetails".
* All codes added in the form must have a comment above or on the right. 
* The Header and Recipient sections' visibility must be set as 'true' while the other sections are set as 'false'.
* Once a section's Next button is clicked, it sets the visibility of the next section to 'true' state.
* The invoice form interface property must changed it's size to grow when a new section is displayed.
* Use appropriate window controls for each section's items. (e.g. Customer is textbox)
* Each control (e.g. textbox) must come with a label text to let the user know the purpose of the control.


Size + Engerineg notes
----------------------
| Size | Engineering notes | 
| -------- | -------- |
| **1**    | The ticket's task is mostly User interface, only requires changing basic properties of each control and easy conditional statement for showing the visibility of the code. | 
