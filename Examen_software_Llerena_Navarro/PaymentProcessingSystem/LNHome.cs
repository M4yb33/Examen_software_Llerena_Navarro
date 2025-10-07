using System;
using Examen_software_Llerena_Navarro.NotificationChannel;
using Examen_software_Llerena_Navarro.Interfaces;
using Examen_software_Llerena_Navarro.Controllers;
using Examen_software_Llerena_Navarro.Services;

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

            // Usar el servicio de consola para mostrar el mensaje de inicio
            ConsoleOutputService.DisplayMessage("Iniciando el proceso de pago...");

            // Crear instancia del controlador
            LNApplePayController applePayController = new LNApplePayController();

            // Llamar al método para ejecutar el pago (por ejemplo, usando Apple Pay)
            applePayController.ExecutePayment(100.50m, "ApplePay", "applePayAccount123", "TXN123456");

            // Usar el servicio de consola para mostrar el mensaje de finalización
            ConsoleOutputService.DisplayMessage("Proceso de pago completado.");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
            
        }
    }
}
