using System;
using Examen_software_Llerena_Navarro.Controller;
using Examen_software_Llerena_Navarro.PaymentMethods;
using Examen_software_Llerena_Navarro.Interfaces;

namespace Examen_software_Llerena_Navarro.PaymentProcessingSystem
{
    public class LNHome
    {
        public static void Main(string[] args)
        {
            // Crear una instancia de LNApplePay o LNPayPal según se desee
            LNIPaymentMethods paymentMethodApple = new LNApplePay(100.50m, "ApplePay", "applePayAccount123", "TXN123456");
            LNIPaymentMethods paymentMethodPayPal = new LNPayPal(150.75m, "PayPal", "paypalAccount123", "TXN654321");
            // LNIPaymentMethods paymentMethod = new LNPayPal(150.75m, "PayPal", "paypalAccount123", "TXN654321");

            // Crear instancia del controlador general
            var generalController = new LNGeneralPaymentController();

            // Ejecutar el pago usando el controlador general
            generalController.ExecutePayment(paymentMethodApple);
            generalController.ExecutePayment(paymentMethodPayPal);
        }
    }
}
