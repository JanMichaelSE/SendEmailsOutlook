using System;
using System.Net;
using System.Net.Mail;

namespace SendEmailsOutlook
{
    class Program
    {
        static void Main(string[] args)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "<YOUR_EMAIL>",
                    Password = "<YOUR_PASSWORD>"
                }
            };

            MailAddress FromEmail = new MailAddress("<SENDER_EMAIL", "Michael Montalvo");
            MailAddress ToEmail = new MailAddress("<RECEIVER_EMAIL>", "Recepient");
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "C# Es lo mejor del Mundo ATT: Mike",
                Body = "Si es C# lo se podra pupi"
            };
            Message.To.Add(ToEmail);

            try
            {
                Console.WriteLine("Sending Email...");
                client.Send(Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateMessageWithAttachment(): {0}", ex.ToString());
            }
        }
    }
}
