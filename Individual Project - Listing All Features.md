# Individual Project - Invoice Application

## Description of the project
This project is to create a simple invoice application that will help my father's business and potentially for other small businesses. The business struggles to create invoices as he uses traditional hand-written style with formatted template document. This consumes time and creates risk of writing wrong details in the invoice which decreases the business' performance. 


### The plan
Date: starting at **21/01/2020**

1. To start creating the project, all keys/features of the application will be listed down and each will have a description of why a key is needed for the application in regards for business and programmers side.

2. After writing all the keys, condition of success will be implement to find out which of the keys will be seuccesful with reasons. Lastly, is writing down some technical notes for keys that have technical requirements. 

Date: starting at **29/01/2020**

3. Sizing; to identify each key with unique number based on its complexity. 

4. Product backlogs will be placed on a task board which Github or trello will be used.

5. Pending..



## List of Keys


### 1st Sprint
* ### Business side
| ID  | Keys | Purpose |
|-----|------|---------|
|  1  | Display main menu |To display the title and to select create invoice  |
|  2  | Display invoice form  | To view and write forms  | |
|  3  | Invoice number and date | To auto fill the new invoice number and current date | 
|  4  | Recipient details | To add the name and address of the recipient in the invoice form| 
|  5  | Services details | To select, add or remove services | 
|  6  | Total price | To calculate total price once selecting a service | 
|  7  | Payment details | To add payment details (Direct transfer / Cheque details)  |
|  8  | Export invoice as PDF | To export all details as a PDF document |

* ### Programmers side
| ID  | Keys | Purpose |
|-----|------|---------|
|  9  | Database for invoice details |To save each invoice info in the database |

### 2nd Sprint
| ID  | Keys | Purpose |
|-----|------|---------|
|  10 |  Update invoice details option | To have another menu option for the user to update the invoice details (Recipient, Services and Payments)|
|  11 |   Update invoice details   |  To add, remove or edit the chosen invoice details|
|  12 | Show existing recipient details | To show suggested details that are existing in the recipient database|
|  13 |  Show existing service details | To show suggested details that are existing in the services database  |
|  14 |  Editable payment details | To update payment details in the invoice form  |
|  15 |  Saved invoice PDF| To save the invoice PDF on a specific location |

* ### Programmers side
| ID  | Keys | Purpose |
|-----|------|---------|
| 16  | Database for Client |To save new added client details in the invoice |
| 17  | Database for Services | To save new added service details in the invoice |

### 3rd Sprint
| ID  | Keys | Purpose |
|-----|------|---------|
| 18  | Auto add new invoice details | To update details in the database if it does not exist in the database |
| 19  | Open PDF file after saving  | To open the current invoice quickly  |
| 20  | Preview invoice   | Checks how it would look like in Invoice view   |
| 21  | Validate forms | To check whether wrong data or blank field is not added |
| 22  | Create report for analysis | To have an option to produce report for analysing the list of invoice.|
| 23  | Send PDF to an email | An option to quickly send the PDF as an email. |


## Condition of success
* ### Business side
| Key ID| Condition of Satisfaction  | Done(Y)/Not(N) |
|-------|------|----------- |
|  1    |   When the user starts the application, the main menu view must be displayed with button to create an invoce. |   Y   |
|  2    | The user must be able to view the form and be able to write the fields. Forms for recipient, services and payment details must be shown.     |  Y |
|  3   |   When the user opens the invoice form the date and invoice number must automatically filled. Date must be editable and current in the format of (dd/mm/yyyy) and invoice number must be unique and increment when a new invoice is created.  | Y |
|   4   |User must add the three details (Name, Address and Post code)  in the invoice form with labels and headers to guide them. | Y |
|   5   | User must choose the type of service used and displayed the details on a table with service and price columns. When the user picks the service, it must be from a list of dropdown box with the existing services an "other" select option must be listed to add new services. |Y|
|  6    |   Total cost must be calculated every each service is added. Must be read only and able to add discounts by checking the box to add the percentage value and instantly display the total.    |  Y  |
|  7    |The user must be able to view the details clearly in the invoice form. | Y|
|  8    | The details that the user has added in the invoice form must be in PDF and the file must be saved anywhere now. |  Y  |
| 10 |It must have a button that when its selected directs to the update invoice window with three option to select to update (Recipient, Services, Payment).| Y|
| 11 | Each of the three options must have a form and view to show all saved records. | Y | 
| 12 | Once the user has entered a character, suggested names will come up as long there is a match. If the user has selected one of the recommended options, other forms such as Address and Post code will be then filled automatically. Then, Saves automatically in the list of client details once the details are new.| Y |
| 13 | If the user has added a new service on the update invoice details, it must be displayed in the service list when creating the invoice.  | Y | 
| 14 | The payment details must have a link that once the user clicks it, it will direct him to update payment details and returns again to invoice form once the user clicks save and exit. | Y |
| 15 | The PDF file must be saved on a folder which is named as Invoice *Current year* and the folder is saved on the desktop. A new folder will create if the current year is different. | Y |
| 18 | Once the user has finished creating the invoice, the system must save the new details if it does not exist in the saved list. | Y |
| 19 | After saving, a prompt must ask to open the file if the user wishes to and views the PDF | Y|
| 20 | User must be able to preview the invoice by clicking the button in the Invoice form.  | Y |
| 21 | Must have an option in the main menu to view a report to show total list of invoices, most used services, less used services, popular areas, and more.  | |
| 22 | After the user filled all the forms and saved the invoice as PDF, it must have the option to send as an email with a text message. | |



* ### Programmers side - Technical notes
| Key ID | Requirements  |
|-----   |------|
|  9, 16, 17  |My sql, csv file, or simple text file|


## UML Diagram
