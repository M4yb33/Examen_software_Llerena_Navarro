using System;
using Examen_software_Llerena_Navarro.Controllers;
using Examen_software_Llerena_Navarro.Services;

namespace Examen_software_Llerena_Navarro.PaymentProcessingSystem
{
    public class LNHome
    {
        public static void Main(string[] args)
        {
            // Usar el servicio de consola para mostrar el mensaje de inicio
            ConsoleOutputService.DisplayMessage("Iniciando el proceso de pago...");

            // Crear instancia del controlador
            LNApplePayController applePayController = new LNApplePayController();

            // Llamar al método para ejecutar el pago (por ejemplo, usando Apple Pay)
            applePayController.ExecutePayment(100.50m, "ApplePay", "applePayAccount123", "TXN123456");

            // Usar el servicio de consola para mostrar el mensaje de finalización
            ConsoleOutputService.DisplayMessage("Proceso de pago completado.");
        }
    }
}
