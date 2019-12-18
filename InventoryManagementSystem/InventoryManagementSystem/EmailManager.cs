using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    class EmailManager
    {
        public static void sendEmailToBuyer(List<Dictionary<string,string>> data,string buyerEmail)
        {
            string recieptID = Constants.NULL_STRING;
            data.ElementAt(0).TryGetValue(Constants.CartID, out recieptID);

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(Constants.SMT_GMAIL_COM);
            
            mail.From = new MailAddress(Constants.MYEMAIL);
            mail.To.Add(buyerEmail);
            mail.Subject = Constants.SUBJECT;
            mail.Body = Constants.NULL_STRING;

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(Constants.FILEPATH + recieptID + Constants.PDFEXTENSION);
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(Constants.MYEMAIL, Constants.MYPASSWORD);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            MessageBox.Show(Constants.SNDMAILMESSAGE);
        }
    }
}
