Se desarrolló una API REST en C# .NET Core 6 para administrar personas. El proyecto se basa en la implementación de funciones esenciales, incluyendo 3 funciones GET, 1 función DELETE y 1 función POST.

El desarrollo se centró en seguir el patrón de diseño de IoC (Inversión de Control) y DI (Inyección de Dependencias), utilizando la abstracción de la interfaz en el controlador a través del patrón de repositorio. Posteriormente, se registró y especificó la referencia en el contenedor de dependencias de .NET.

Además, se utilizó Entity Framework para gestionar la conexión con la base de datos, las migraciones y el mapeo de las tablas a los modelos correspondientes.

Como funcionalidad adicional, se implementó un método POST con validaciones a nivel de base de datos y modelo, lo que garantiza que solo se puedan ingresar caracteres válidos al ejecutar la operación POST.

