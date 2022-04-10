using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace _03_SmtpHttpHelpers.Helpers.Notification
{
    internal class Email
    {
        public static string userLogin = "avmatvieieva@ukr.net";
        public static string userPassword = "mWXJ5GKZpyxRi8jY";

        /// <summary>
        /// Metod of sending post
        /// </summary>
        /// <param name="toEmail">to what adress should send message</param>
        /// <param name="toName">name of getter</param>
        /// <param name="subject">subject of letter</param>
        /// <param name="message">message in the text</param>
        public static async void SendEmail(
            string toEmail = "avmatvieieva@gmail.com",
            string toName = "Anna Matvieieva",
            string subject = "Test Mail",
            string message = "Test Mail")
        {
            var emailMassage = new MimeMessage();

            emailMassage.From.Add(new MailboxAddress("Anna Matvieieva", userLogin));
            emailMassage.To.Add(new MailboxAddress(toName,toEmail));
            emailMassage.To.Add(new MailboxAddress("Petya", toEmail));
            emailMassage.Subject = subject;
           

            var builder = new BodyBuilder();

            builder.TextBody = message + "\nВи отримали це повідомлення, тому що залишили заявку.\nВідправляю вам смайлик для гарного настрою!";

            builder.Attachments.Add(@"C:\Users\avmat\Downloads\download.jpg");

            emailMassage.Body = builder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.ukr.net", 465, true);
                await client.AuthenticateAsync(userLogin, userPassword);
                await client.SendAsync(emailMassage);
                await client.DisconnectAsync(true);
            }
        }
    }

}
