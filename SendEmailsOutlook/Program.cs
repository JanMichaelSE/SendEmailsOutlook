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
                    UserName = "janm.montalvo@gmail.com",
                    Password = "Hector504mail"
                }
            };

            MailAddress FromEmail = new MailAddress("janm.montalvo@gmail.com", "Michael Montalvo");
            MailAddress ToEmail = new MailAddress("ortiz_95537@students.pupr.edu", "Recepient");
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
