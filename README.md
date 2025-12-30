# VocalApp
1. Descripción del Proyecto 

Este proyecto consiste en una aplicación desarrollada en .NET MAUI que facilita la comunicación mediante el uso de una interfaz natural de voz. La aplicación permite al usuario navegar entre dos pantallas: una de bienvenida y otra de dictado, donde el sistema traduce el texto introducido en voz alta de forma automática.





2. Tecnologías Usadas 


Framework: .NET MAUI.


Lenguajes: C# y XAML.


Arquitectura: Patrón MVVM para separar la lógica de los datos de la interfaz visual.


Plataforma de pruebas: Windows.


3. Requisitos Técnicos Implementados 

Para cumplir con los mínimos del proyecto, se han incluido los siguientes elementos:


Navegación: Uso de NavigationPage para gestionar el flujo entre la página principal y la de dictado.



Páginas: Dos páginas con un diseño cuidado utilizando controles modernos.


Controles Comunes: Se han utilizado controles como Entry, Button, Label, VerticalStackLayout y Border para estructurar la interfaz.


4. Interfaz Natural Implementada 



El elemento obligatorio de interfaz natural elegido es:


Síntesis de voz (Text-to-Speech): La aplicación utiliza la API nativa de MAUI para convertir el texto escrito por el usuario en audio hablado.



5. Instrucciones para Probar la App 


Para probar el funcionamiento del proyecto, sigue estos pasos:

Compilar y ejecutar la aplicación en Windows.



En la pantalla de inicio, pulsar el botón "ACCEDER AL DICTADO" para navegar a la siguiente página.



Escribir cualquier frase en el cuadro de texto (Entry).



Pulsar el botón "REPRODUCIR AHORA" para activar la síntesis de voz y escuchar el mensaje.
