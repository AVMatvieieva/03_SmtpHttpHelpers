using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _03_SmtpHttpHelpers.Helpers.Notification
{
    internal class Telegram
    {
        public static string apiTelegram = "5105596246:AAFgGHeEP1agbL0QEJiDvF5ZsoWwaB3NXas";//key for telegram bot
        public static string user_id = "581817502";

        public static void SendMessege(string message= "Hello World")
        {
            string uri =
                "https://api.telegram.org/bot" + apiTelegram + // авторизация на сервисе
                "/sendMessage" + // команда
                                 // Параметрі команді
                "?chat_id=" + user_id +
                "&text=" + message;

            var request = WebRequest.Create(uri);
            request.Method = "GET";

            var response = request.GetResponse();

        }

    }
}
