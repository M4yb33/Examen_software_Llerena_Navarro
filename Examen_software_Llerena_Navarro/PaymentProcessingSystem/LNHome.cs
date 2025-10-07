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

            try
            {
                // Crear instancia del controlador de pago
                var applePayController = new LNApplePayController();

                // Ejecutar el pago
                applePayController.ExecutePayment(100.50m, "ApplePay", "applePayAccount123", "TXN123456");
                ConsoleOutputService.DisplaySuccess("Proceso de pago completado correctamente");
            }
            catch (Exception ex)
            {
                ConsoleOutputService.DisplayError($"Error en el proceso de pago: {ex.Message}");
            }

            ConsoleOutputService.DisplayMessage("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
            
        }
    }
}
