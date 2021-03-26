using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;

namespace Invoice_Application_Project.Models
{
	public class Pdf
	{
		//Fields
		private string invoiceId;
		private DateTime date;
		private DateTime duedate;
		private string customerName;
		private string email;
		private string address;
		private string postCode;
		private string notes;
		private string paymentDetails_1;
		private string paymentDetails_2;
		private string discountGiven;
		private string totalPrice;

		//Properties
		public string InvoiceId
		{
			get { return invoiceId; }
			set { invoiceId = value; }
		}
		public DateTime InvoiceDate
		{
			get { return date; }
			set { date = value; }
		}
		public DateTime InvoiceDueDate
		{
			get { return duedate; }
			set { duedate = value; }
		}
		public string InvoiceCustomerName
		{
			get { return customerName; }
			set { customerName = value; }
		}
		public string InvoiceEmail
		{
			get { return email; }
			set { email = value; }
		}
		public string InvoiceAddress
		{
			get { return address; }
			set { address = value; }
		}
		public string InvoicePostcode
		{
			get { return postCode; }
			set { postCode = value; }
		}
		public string InvoiceNotes
		{
			get { return notes; }
			set { notes = value; }
		}

		public string InvoicePaymentDetails_1
		{
			get { return paymentDetails_1; }
			set { paymentDetails_1 = value; }
		}

		public string InvoicePaymentDetails_2
		{
			get { return paymentDetails_2; }
			set { paymentDetails_2 = value; }
		}

		public string InvoiceDiscountGiven
		{
			get { return discountGiven; }
			set { discountGiven = value; }
		}
		public string InvoiceTotalPrice
		{
			get { return totalPrice; }
			set { totalPrice = value; }
		}

		//Method

		/// <summary>
		/// Save all contents of invoice form to PDF - Ticket 13
		/// </summary>
		public bool SaveInvoiceToPDF(ListView item) {

			//BUG 002
			bool successSave = false;

			//Save PDF with chosen directory and file name - 027
			using (SaveFileDialog sfd= new SaveFileDialog() { Filter="PDF file|*.pdf",ValidateNames = true })
			{
				//default file name
				sfd.FileName = InvoiceId +" "+InvoiceAddress;

				//If the save button is clicked
				if (sfd.ShowDialog()==DialogResult.OK)
				{

					PdfWriter writer = new PdfWriter(sfd.FileName);

					using (var pdf = new PdfDocument(writer)) {


						var document = new Document(pdf);

						//*****Header******
						Paragraph text;

						//Logo Image
						string imageFile = "../../Resources/smIcon(Transparent).png";
						ImageData imagedata = ImageDataFactory.Create(imageFile);
						Image image = new Image(imagedata).SetHeight(100).SetWidth(200);
						document.Add(image);

						//Date
						text = new Paragraph("Date: "+ InvoiceDate.Day+"/" + InvoiceDate.Month+"/"+ InvoiceDate.Year).SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT).SetFontSize(14);
						document.Add(text);
						//Title
						text = new Paragraph(" Invoice").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetFontSize(30);
						document.Add(text);
						//Line Separator
						LineSeparator line = new LineSeparator(new SolidLine());
						document.Add(line);

						//Invoice Number
						text = new Paragraph("Invoice number: "+ InvoiceId).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetFontSize(18);
						document.Add(text);

						//Line Separator
						line = new LineSeparator(new SolidLine());
						document.Add(line);

						//*****Customer Details*****
						text = new Paragraph("Customer Details").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetFontSize(14).SetBold();
						document.Add(text);
						document.Add(new Paragraph("Customer Name: " + InvoiceCustomerName));
						document.Add(new Paragraph("Email: " + InvoiceEmail));
						document.Add(new Paragraph("Address: " + InvoiceAddress));
						document.Add(new Paragraph("Post code: " + InvoicePostcode));

						//Line Separator
						line = new LineSeparator(new SolidLine());
						document.Add(line);

						//*****Services*****
						text = new Paragraph("Services").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetFontSize(14).SetBold();
						document.Add(text);

						//Table 
						Table table = new Table(2);

						table.AddCell(new Paragraph("Services").SetWidth(350));
						table.AddCell(new Paragraph("Price (£)").SetWidth(150));

						for (int i = 0; i < item.Items.Count; i++)
						{
							table.AddCell(new Paragraph(item.Items[i].SubItems[0].Text));
							table.AddCell(new Paragraph(item.Items[i].SubItems[1].Text));
						}
						document.Add(table);

						//Discount Given
						text = new Paragraph("Discount Given: "+ InvoiceDiscountGiven+"%").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetFontSize(14);
						document.Add(text);

						//Total price
						text = new Paragraph("Total Price: £"+ InvoiceTotalPrice).SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT).SetFontSize(14);
						document.Add(text);


						//****Notes*****
						text = new Paragraph("Notes").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetFontSize(14).SetBold();
						document.Add(text);
						text = new Paragraph(InvoiceNotes).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetFontSize(12);
						document.Add(text);

						//Line Separator
						line = new LineSeparator(new SolidLine());
						document.Add(line);


						//*****Payment Details*****
						text = new Paragraph("Payment Details").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetFontSize(14).SetBold();
						document.Add(text);

						//Direct Transfer
						text = new Paragraph("---Direct Transfer---").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetFontSize(14);
						document.Add(text);
						text = new Paragraph(InvoicePaymentDetails_1).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetFontSize(12);
						document.Add(text);
						//Cheque Payment
						text = new Paragraph("---Cheque Payment---").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetFontSize(14);
						document.Add(text);
						text = new Paragraph(InvoicePaymentDetails_2).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetFontSize(12);
						document.Add(text);

						//Line Separator
						line = new LineSeparator(new SolidLine());
						document.Add(line);

						text = new Paragraph("THANK YOU FOR CHOOSING SHINE MASTER.").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetFontSize(12);
						document.Add(text);
						text = new Paragraph("PAYMENT SHOULD BE MADE UPON THE COMPLETION OF SERVICE.").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetFontSize(12);
						document.Add(text);


						document.Close();

						successSave = true;
					}
			

				}
				//If it didnt saved
				else
				{
					successSave = false;
					MessageBox.Show("Saving unfinished!");
				}



			}

			//Return boolean value
			return successSave;


			//BUG 003 
			/*/Closing invoice Form
			foreach (Form form in System.Windows.Forms.Application.OpenForms)
			{

				if (form is Invoice_Form)
				{
					form.Close();
					break;
				}
			}

			Form_Menu openHome = new Form_Menu();

			openHome.Show();*/

			

		}



	}

}
