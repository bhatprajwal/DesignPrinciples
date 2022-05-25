using System.Net;
using System.Net.Mail;

namespace SRP.Service
{
    public class Email
    {
        public string? FromAddress { get; set; }
        public string? Password { get; set; }
        public string? ToAddress { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public bool IsBodyHtml { get; set; }
        public string? Host { get; set; }
        public int Port { get; set; }
        public bool EnableSsl { get; set; }
        public bool UseDefaultCredentials { get; set; }

        public bool Send()
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress(this.FromAddress);
            message.To.Add(new MailAddress(this.ToAddress));
            message.Subject = this.Subject;
            message.IsBodyHtml = this.IsBodyHtml; //to make message body as html  
            message.Body = this.Body;
            smtp.Port = this.Port;
            smtp.Host = this.Host; //for gmail host  
            smtp.EnableSsl = this.EnableSsl;
            smtp.UseDefaultCredentials = this.UseDefaultCredentials;
            smtp.Credentials = new NetworkCredential(this.FromAddress, this.Password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);

            return true;
        }
    }
}