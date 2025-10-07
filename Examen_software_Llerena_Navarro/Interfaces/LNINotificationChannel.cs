using System;

namespace Examen_software_Llerena_Navarro.Interfaces
{
    // Interface que define el contrato para enviar notificaciones (ISP)
    public interface LNINotificationChannel
    {
        // Método que implementarán todas las notificaciones
        void LNSendNotification(string message);
    }
}
