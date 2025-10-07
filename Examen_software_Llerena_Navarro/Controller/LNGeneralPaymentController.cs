using Examen_software_Llerena_Navarro.Interfaces;
using Examen_software_Llerena_Navarro.Services;

namespace Examen_software_Llerena_Navarro.Controller
{
    public class LNGeneralPaymentController
    {
        // M�todo para ejecutar el pago con cualquier tipo de implementaci�n de LNIPaymentMethods
        public void ExecutePayment(LNIPaymentMethods paymentMethod)
        {
            // Llamamos al m�todo ProcessPayment() de la clase de pago, sin importar qu� implementaci�n sea
            paymentMethod.ProcessPayment();
        }
    }
}
