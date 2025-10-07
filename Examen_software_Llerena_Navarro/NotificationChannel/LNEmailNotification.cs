using System;
using Examen_software_Llerena_Navarro.Interfaces;

namespace Examen_software_Llerena_Navarro.NotificationChannel
{
    public class LNEmailNotification : LNINotificationChannel
    {
        private string _recipient;
        public string LNEmailAddress { get; set; }

        public string LNRecipient
        {
            get { return _recipient; }
            set { _recipient = value; }
        }

        public void LNSendNotification(string message)
        {
            Console.WriteLine($"Enviando correo electrónico a {LNEmailAddress}");
            Console.WriteLine($"Destinatario: {LNRecipient}");
            Console.WriteLine($"Mensaje: {message}");
        }
    }
}
