using System;
using Examen_software_Llerena_Navarro.NotificationChannel;
using Examen_software_Llerena_Navarro.Services;

namespace Examen_software_Llerena_Navarro.Controllers
{
    // Controlador específico para notificaciones por email
    public class LNEmailNotificationController
    {
        private readonly LNEmailNotification _emailNotification;

        public LNEmailNotificationController()
        {
            _emailNotification = new LNEmailNotification();
        }

        public void SendEmailNotification(string message)
        {
            try
            {
                _emailNotification.LNSendNotification(message);
                ConsoleOutputService.DisplaySuccess("Email enviado correctamente");
            }
            catch (Exception ex)
            {
                ConsoleOutputService.DisplayError($"Error al enviar email: {ex.Message}");
            }
        }
    }
}