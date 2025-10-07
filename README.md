# Sistema de Notificaciones

Este proyecto implementa un sistema de notificaciones usando principios SOLID en C#.

## Estructura del Proyecto

```
├── Interfaces/
│   └── LNINotificationChannel.cs    # Interfaz base para notificaciones
├── NotificationChannel/
│   ├── LNEmailNotification.cs       # Implementación de notificaciones por email
│   └── LNWhatsappNotification.cs    # Implementación de notificaciones por WhatsApp
└── PaymentProcessingSystem/
    └── LNHome.cs                    # Clase principal con ejemplos de uso
```

## Características

- Implementación de notificaciones usando el patrón de interfaz
- Soporte para múltiples canales de notificación (Email y WhatsApp)
- Diseño extensible para agregar nuevos canales de notificación

## Principios SOLID Aplicados

- **S (SRP)**: Cada clase de notificación tiene una única responsabilidad
- **I (ISP)**: Interfaz simple y específica para notificaciones
- **D (DIP)**: Dependencia en abstracciones, no en implementaciones concretas

## Uso

```csharp
// Crear notificación por email
LNINotificationChannel emailNotification = new LNEmailNotification();
emailNotification.LNSendNotification("Mensaje por email");

// Crear notificación por WhatsApp
LNINotificationChannel whatsappNotification = new LNWhatsappNotification();
whatsappNotification.LNSendNotification("Mensaje por WhatsApp");
```

## Autores
- Gabriel Llerena
- Maybelline Navarro