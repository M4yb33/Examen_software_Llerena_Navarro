using System;
using Examen_software_Llerena_Navarro.PaymentMethods;
using Examen_software_Llerena_Navarro.Services;

namespace Examen_software_Llerena_Navarro.Controller
{
    public class LNPayPalController
    {
        // Método para ejecutar el pago a través de la clase LNPayPal
        public void ExecutePayment(LNPayPal payPal)
        {
            string resultMessage;
            bool paymentSuccess = payPal.ProcessPayment(out resultMessage);

            ConsoleOutputService.DisplayMessage(resultMessage);

            if (!paymentSuccess)
            {
                ConsoleOutputService.DisplayError("El pago no fue procesado correctamente.");
            }
        }
    }
}
