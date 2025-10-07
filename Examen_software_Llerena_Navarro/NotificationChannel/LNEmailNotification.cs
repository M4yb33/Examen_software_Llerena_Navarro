using System;
using Examen_software_Llerena_Navarro.Interfaces;

namespace Examen_software_Llerena_Navarro.NotificationChannel
{
    // Implementación para notificaciones por email (SRP)
    public class LNEmailNotification : LNINotificationChannel
    {
        public void LNSendNotification(string message)
        {
            Console.WriteLine($"Enviando correo electrónico: {message}");
        }
    }
}
