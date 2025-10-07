using System;
using Examen_software_Llerena_Navarro.NotificationChannel;
using Examen_software_Llerena_Navarro.Services;

namespace Examen_software_Llerena_Navarro.Controller
{
    // Controlador específico para notificaciones por WhatsApp
    public class LNWhatsappNotificationController
    {
        private readonly LNWhatsappNotification _whatsappNotification;

        public LNWhatsappNotificationController()
        {
            _whatsappNotification = new LNWhatsappNotification();
        }

        public void SendWhatsappNotification(string message)
        {
            try
            {
                _whatsappNotification.LNSendNotification(message);
                ConsoleOutputService.DisplaySuccess("Mensaje de WhatsApp enviado correctamente");
            }
            catch (Exception ex)
            {
                ConsoleOutputService.DisplayError($"Error al enviar mensaje de WhatsApp: {ex.Message}");
            }
        }
    }
}