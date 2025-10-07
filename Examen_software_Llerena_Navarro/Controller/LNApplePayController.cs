using System;
using Examen_software_Llerena_Navarro.PaymentMethods;
using Examen_software_Llerena_Navarro.Services;

namespace Examen_software_Llerena_Navarro.Controllers
{
    public class LNApplePayController
    {
        // Método para ejecutar el pago a través de la clase LNApplePay
        public void ExecutePayment(decimal amount, string paymentType, string applePayAccount, string transactionId)
        {
            // Crear instancia de LNApplePay
            LNApplePay applePay = new LNApplePay(amount, paymentType, applePayAccount, transactionId);

            // Usar el método ProcessPayment() de LNApplePay para procesar el pago
            string resultMessage;
            bool paymentSuccess = applePay.ProcessPayment(out resultMessage);

            // Mostrar el resultado a través del servicio de consola
            ConsoleOutputService.DisplayMessage(resultMessage);

            // Si el pago no fue exitoso
            if (!paymentSuccess)
            {
                ConsoleOutputService.DisplayError("El pago no fue procesado correctamente.");
            }
        }
    }
}
