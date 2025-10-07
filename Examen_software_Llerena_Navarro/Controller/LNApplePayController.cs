using System;
using Examen_software_Llerena_Navarro.PaymentMethods;
using Examen_software_Llerena_Navarro.Services;

namespace Examen_software_Llerena_Navarro.Controllers
{
    public class LNApplePayController
    {
        // Método para ejecutar el pago a través de la clase LNApplePay
        public void ExecutePayment(LNApplePay applePay)
        {
            string resultMessage;
            bool paymentSuccess = applePay.ProcessPayment(out resultMessage);

            ConsoleOutputService.DisplayMessage(resultMessage);

            if (!paymentSuccess)
            {
                ConsoleOutputService.DisplayError("El pago no fue procesado correctamente.");
            }
        }
    }
}
