using System;
using Examen_software_Llerena_Navarro.Interfaces;

namespace Examen_software_Llerena_Navarro.NotificationChannel
{
    public class LNWhatsappNotification : LNINotificationChannel
    {
        private string _recipient;
        public string LNWhatsAppNumber { get; set; }

        public string LNRecipient
        {
            get { return _recipient; }
            set { _recipient = value; }
        }

        public void LNSendNotification(string message)
        {
            Console.WriteLine($"Enviando mensaje de WhatsApp al número {LNWhatsAppNumber}");
            Console.WriteLine($"Destinatario: {LNRecipient}");
            Console.WriteLine($"Mensaje: {message}");
        }
    }
}
