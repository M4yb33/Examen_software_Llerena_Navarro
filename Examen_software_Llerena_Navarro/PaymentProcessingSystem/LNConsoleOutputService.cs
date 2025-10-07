using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_software_Llerena_Navarro.Services
{
    public static class ConsoleOutputService
    {
        // Método para mostrar un mensaje de éxito
        public static void DisplaySuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"ÉXITO: {message}");
            Console.ResetColor();
        }

        // Método para mostrar un mensaje de error
        public static void DisplayError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERROR: {message}");
            Console.ResetColor();
        }

        // Método para mostrar un mensaje general
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
