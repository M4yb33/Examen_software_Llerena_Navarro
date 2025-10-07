using System;
using Examen_software_Llerena_Navarro.PaymentMethods;
using Examen_software_Llerena_Navarro.Services;

namespace Examen_software_Llerena_Navarro.Controller
{
    internal class LNPayPalController
    {
        // Método para ejecutar el pago a través de la clase LNPayPal
        public void ExecutePayment(decimal amount, string paymentType, string payPalAccount, string transactionId)
        {
            // Crear instancia de LNPayPal
            LNPayPal payPal = new LNPayPal(amount, paymentType, payPalAccount, transactionId);

            // Usar el método ProcessPayment() de LNPayPal para procesar el pago
            string resultMessage;
            bool paymentSuccess = payPal.ProcessPayment(out resultMessage);

            // Mostrar el resultado a través del servicio de consola
            ConsoleOutputService.DisplayMessage(resultMessage);

            // Si el pago no fue exitoso, también podríamos hacer algún manejo adicional aquí
            if (!paymentSuccess)
            {
                ConsoleOutputService.DisplayError("El pago no fue procesado correctamente.");
            }
        }
    }
}
