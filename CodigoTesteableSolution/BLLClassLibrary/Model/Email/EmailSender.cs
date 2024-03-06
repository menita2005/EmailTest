using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLLClassLibrary.Model.Email
{
    public class EmailSender : IDisposable
    {
        private SmtpClient smtpClient;

        public EmailSender(SmtpClient @object)
        {
            smtpClient = new SmtpClient("yourSMTPServer");

        }
        public void Enviar(string email, string documento)
        {
            var mailMessage = new MailMessage("your@email.com", email, "Subject", documento);
            smtpClient.Send(mailMessage);
        } 
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                smtpClient.Dispose();
            }
        }
        ~EmailSender() 
        {
            Dispose(false);
        }
    }
}
