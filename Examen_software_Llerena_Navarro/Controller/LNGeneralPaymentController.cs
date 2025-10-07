using Examen_software_Llerena_Navarro.Controllers;
using Examen_software_Llerena_Navarro.Interfaces;
using Examen_software_Llerena_Navarro.Services;

namespace Examen_software_Llerena_Navarro.Controller
{
    public class LNGeneralPaymentController
    {
        // Método para ejecutar el pago con cualquier tipo de implementación de LNIPaymentMethods
        public void ExecutePayment(LNIPaymentMethods paymentMethod)
        {
            switch (paymentMethod)
            {
                case Examen_software_Llerena_Navarro.PaymentMethods.LNApplePay applePay:
                    var appleController = new LNApplePayController();
                    appleController.ExecutePayment(applePay);
                    break;
                case Examen_software_Llerena_Navarro.PaymentMethods.LNPayPal payPal:
                    var payPalController = new LNPayPalController();
                    payPalController.ExecutePayment(payPal);
                    break;
                // Agrega aquí otros métodos de pago y controladores si los tienes
                default:
                    paymentMethod.ProcessPayment();
                    break;
            }
        }
    }
}