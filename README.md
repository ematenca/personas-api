Desarrollo de API REST en C# .Net Core 6 para administrar personas

En el proyecto actual se implemento lo necesario para administrar una api rest basica con 3 funciones get, 1 delete y 1 post adicional.

Se desarrollo usando y siguiendo el concepto de IoC (Inversión de control) y DI (Inyección de dependecias), utilizando la abstraccion de la interfaz en el controlador y luego registrando y especificando la referencia de la misma en el contenedor de dependecias de .NET

Ademas se utilizo Entity Framework para gestionar la conexion, las migraciones y el mapeo de las tablas a los modelos.

Como funcionalidad extra se implemento un metodo post con una validacion a nivel de la base de datos y del modelo para que solo se puedan escribir caracteres al momento de ejecutar el post.
