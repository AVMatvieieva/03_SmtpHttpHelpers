using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace _03_SmtpHttpHelpers.Helpers.Notification
{
    internal class EmailControler
    {
        public static string userLogin = "avmatvieieva@ukr.net";
        public static string userPassword = "mWXJ5GKZpyxRi8jY";
        
        public static async void SendEmail(string Email, string Name, string subj, string msg, string att)
        {
            var emailMessege = new MimeMessage();
            emailMessege.From.Add(new MailboxAddress("Anna Matvieieva", userLogin));
            emailMessege.To.Add(new MailboxAddress(Name, Email));
            emailMessege.Subject = subj;

            var builder = new BodyBuilder();

            builder.TextBody = msg + "\nВи отримали це повідомлення, тому що залишили заявку."; ;

            if (att !="")
            {
                builder.Attachments.Add(att);
            }
            

            emailMessege.Body = builder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.ukr.net", 465, true);
                await client.AuthenticateAsync(EmailControler.userLogin, EmailControler.userPassword);
                await client.SendAsync(emailMessege);
                await client.DisconnectAsync(true);
            }


        }

    }  

}
