using System;
using Examen_software_Llerena_Navarro.Interfaces;

namespace Examen_software_Llerena_Navarro.NotificationChannel
{
    // Implementación para notificaciones por WhatsApp (SRP)
    public class LNWhatsappNotification : LNINotificationChannel
    {
        public void LNSendNotification(string message)
        {
            Console.WriteLine($"Enviando mensaje de WhatsApp: {message}");
        }
    }
}
