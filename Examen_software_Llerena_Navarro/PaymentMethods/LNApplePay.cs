using System;
using Examen_software_Llerena_Navarro.Interfaces;
using Examen_software_Llerena_Navarro.Services;

namespace Examen_software_Llerena_Navarro.PaymentMethods
{
    public class LNApplePay : LNIPaymentMethods // Cambiado a public
    {
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }
        public string ApplePayAccount { get; set; }
        public string TransactionId { get; set; }

        // Constructor
        public LNApplePay(decimal amount, string paymentType, string applePayAccount, string transactionId)
        {
            Amount = amount;
            PaymentType = paymentType;
            ApplePayAccount = applePayAccount;
            TransactionId = transactionId;
        }

        // Implementación del método requerido por la interfaz
        public void ProcessPayment()
        {
            // Simulamos un proceso de pago
            try
            {
                // Validar los datos antes de proceder (como ejemplo)
                if (string.IsNullOrEmpty(ApplePayAccount))
                {
                    string resultMessage = "La cuenta de Apple Pay no está configurada.";
                    ConsoleOutputService.DisplayError(resultMessage);
                    return; // Pago fallido
                }

                // Si todo es válido, procesamos el pago
                string successMessage = $"Pago de {Amount} realizado con éxito usando Apple Pay. ID de transacción: {TransactionId}";
                ConsoleOutputService.DisplaySuccess(successMessage);
            }
            catch (Exception ex)
            {
                // Si hay algún error, mostramos el mensaje correspondiente
                string errorMessage = $"Error al procesar el pago: {ex.Message}";
                ConsoleOutputService.DisplayError(errorMessage);
            }
        }

        // Método adicional opcional para mantener compatibilidad con el diseño anterior
        public bool ProcessPayment(out string resultMessage)
        {
            try
            {
                if (string.IsNullOrEmpty(ApplePayAccount))
                {
                    resultMessage = "La cuenta de Apple Pay no está configurada.";
                    ConsoleOutputService.DisplayError(resultMessage);
                    return false;
                }
                resultMessage = $"Pago de {Amount} realizado con éxito usando Apple Pay. ID de transacción: {TransactionId}";
                ConsoleOutputService.DisplaySuccess(resultMessage);
                return true;
            }
            catch (Exception ex)
            {
                resultMessage = $"Error al procesar el pago: {ex.Message}";
                ConsoleOutputService.DisplayError(resultMessage);
                return false;
            }
        }
    }
}
