using System;
using Examen_software_Llerena_Navarro.Interfaces;
using Examen_software_Llerena_Navarro.Services;

namespace Examen_software_Llerena_Navarro.Controller
{
    // Controlador general para manejar todas las notificaciones
    public class LNNotificationController
    {
        private readonly LNINotificationChannel _notificationChannel;

        // Inyección de dependencias a través del constructor
        public LNNotificationController(LNINotificationChannel notificationChannel)
        {
            _notificationChannel = notificationChannel;
        }

        // Método general para procesar notificaciones
        public void ProcessNotification(string message)
        {
            try
            {
                _notificationChannel.LNSendNotification(message);
                ConsoleOutputService.DisplaySuccess("Notificación procesada correctamente");
            }
            catch (Exception ex)
            {
                ConsoleOutputService.DisplayError($"Error al procesar la notificación: {ex.Message}");
            }
        }
    }
}