using System;
using Examen_software_Llerena_Navarro.NotificationChannel;
using Examen_software_Llerena_Navarro.Interfaces;

namespace Examen_software_Llerena_Navarro.PaymentProcessingSystem
{
    public class LNHome
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Notificaciones ===\n");

            // Prueba de notificación por Email
            Console.WriteLine("Notificación por Email:");
            LNINotificationChannel emailNotification = new LNEmailNotification();
            emailNotification.LNSendNotification("Mensaje por gmail para Gabriel Llerena");
            Console.WriteLine();

            // Prueba de notificación por WhatsApp
            Console.WriteLine("Notificación por WhatsApp:");
            LNINotificationChannel whatsappNotification = new LNWhatsappNotification();
            whatsappNotification.LNSendNotification("Mensaje por whatsapp para Maybelline Navarro");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
