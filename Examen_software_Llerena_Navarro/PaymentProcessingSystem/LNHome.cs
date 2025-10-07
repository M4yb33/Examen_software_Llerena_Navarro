using Examen_software_Llerena_Navarro.Controller;
using Examen_software_Llerena_Navarro.Controllers;
using Examen_software_Llerena_Navarro.Interfaces;
using Examen_software_Llerena_Navarro.NotificationChannel;
using Examen_software_Llerena_Navarro.PaymentMethods;
using Examen_software_Llerena_Navarro.Services;
using System;

namespace Examen_software_Llerena_Navarro.PaymentProcessingSystem
{
    public class LNHome
    {
        public static void Main(string[] args)
        {
            // Mostrar mensaje de inicio
            ConsoleOutputService.DisplayMessage("=== Sistema de Notificaciones ===\n");

            // Prueba de notificación por Email
            Console.WriteLine("Notificación por Email:");
            LNINotificationChannel emailNotification = new LNEmailNotification();
            emailNotification.LNSendNotification("Mensaje por Gmail para Gabriel Llerena");
            Console.WriteLine();

            // Prueba de notificación por WhatsApp
            Console.WriteLine("Notificación por WhatsApp:");
            LNINotificationChannel whatsappNotification = new LNWhatsappNotification();
            whatsappNotification.LNSendNotification("Mensaje por WhatsApp para Maybelline Navarro");
            Console.WriteLine();

            // Crear una instancia de LNApplePay o LNPayPal según se desee
            LNIPaymentMethods paymentMethodApple = new LNApplePay(100.50m, "ApplePay", "applePayAccount123", "TXN123456");
            LNIPaymentMethods paymentMethodPayPal = new LNPayPal(150.75m, "PayPal", "paypalAccount123", "TXN654321");

            // Crear instancia del controlador general
            var generalController = new LNGeneralPaymentController();

            // Ejecutar el pago usando el controlador general
            generalController.ExecutePayment(paymentMethodApple);
            generalController.ExecutePayment(paymentMethodPayPal);
            ConsoleOutputService.DisplayMessage("\n=== Sistema de Notificaciones y Pagos ===\n");

            // Sistema de Notificaciones
            ConsoleOutputService.DisplayMessage("\n--- Prueba de Notificaciones ---");
            
            try
            {
                // Crear y usar el controlador de Email
                ConsoleOutputService.DisplayMessage("\nProcesando notificación por Email:");
                var emailController = new LNEmailNotificationController();
                emailController.SendEmailNotification("Notificación exitosa para Gabriel Llerena");

                // Crear y usar el controlador de WhatsApp
                ConsoleOutputService.DisplayMessage("\nProcesando notificación por WhatsApp:");
                var whatsappController = new LNWhatsappNotificationController();
                whatsappController.SendWhatsappNotification("Notificación exitosa para Maybelline Navarro");
            }
            catch (Exception ex)
            {
                ConsoleOutputService.DisplayError($"Error en el sistema de notificaciones: {ex.Message}");
            }

            // Sistema de Pagos
            ConsoleOutputService.DisplayMessage("\n--- Prueba de Pagos ---");
            ConsoleOutputService.DisplayMessage("\nIniciando el proceso de pago...");


            ConsoleOutputService.DisplayMessage("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
