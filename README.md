# Tarea Programada: Sistema de Gestión de Productos

## Información académica

- **Nombre de la tarea:** Sistema de Gestión de Productos.
- **Curso:** Programación II.
- **Estudiante:** Josué Monge.
- **Año:** 2026.

## 1. Descripción del sistema

Sistema de escritorio desarrollado en C# con Windows Forms y SQL Server, orientado a la administración de productos y categorías de una pequeña tienda de tecnología y accesorios.

El sistema permite registrar, consultar, modificar y eliminar categorías y productos, realizar búsquedas por nombre y calcular automáticamente el valor del inventario.

## 2. Tecnologías utilizadas

- C#
- Windows Forms
- .NET 10
- SQL Server Express
- SQL Server Management Studio (SSMS)
- Microsoft.Data.SqlClient
- Visual Studio 2026

## 3. Requisitos para ejecutar el programa

- Windows.
- Visual Studio compatible con .NET 10.
- .NET 10 SDK.
- SQL Server Express.
- SQL Server Management Studio (SSMS).
- Paquete NuGet Microsoft.Data.SqlClient.

## 4. Funcionalidades principales

### Gestión de categorías

- Registrar categorías.
- Consultar categorías.
- Actualizar categorías.
- Eliminar categorías.
- Validar los datos ingresados.

### Gestión de productos

- Registrar productos.
- Consultar productos.
- Actualizar productos.
- Eliminar productos.
- Buscar productos por nombre.
- Seleccionar categorías existentes.
- Calcular el valor del inventario mediante el precio y el stock.

## 5. Base de datos

La base de datos se denomina `SistemaGestionProductos` y contiene dos tablas:

- **Categorias:** almacena los nombres y descripciones de las categorías.
- **Productos:** almacena los productos, precios, existencias, fechas de registro y categorías asociadas.

Ambas tablas están relacionadas mediante una llave foránea denominada `FK_Productos_Categorias`.

El script de creación se encuentra en:

`SQL/CrearBaseDatos.sql`

## 6. Instrucciones de instalación y ejecución

1. Descargar o clonar el repositorio de GitHub.
2. Instalar los requisitos indicados anteriormente.
3. Abrir SQL Server Management Studio.
4. Conectarse a una instancia de SQL Server.
5. Abrir y ejecutar el archivo `SQL/CrearBaseDatos.sql`.
6. Abrir la solución del proyecto en Visual Studio.
7. Abrir el archivo `Datos/Conexion.cs`.
8. Modificar el nombre del servidor en la cadena de conexión según la instancia de SQL Server instalada.
9. Compilar la solución.
10. Ejecutar la aplicación desde Visual Studio.

## 7. Información de conexión a SQL Server

La conexión utiliza autenticación de Windows mediante la siguiente configuración:

- **Servidor:** instancia local de SQL Server Express.
- **Base de datos:** SistemaGestionProductos.
- **Autenticación:** Windows.
- **Proveedor:** Microsoft.Data.SqlClient.

La cadena de conexión se encuentra en `Datos/Conexion.cs` y debe ajustarse al nombre de la instancia instalada en cada computadora.

## 8. Validaciones

El sistema contempla las siguientes validaciones:

- Campos obligatorios.
- Precio numérico y mayor que cero.
- Stock numérico y mayor o igual que cero.
- Selección obligatoria de una categoría.
- Límites de caracteres para nombres y descripciones.
- Protección de la relación entre categorías y productos al intentar eliminar registros relacionados.

## 9. Estructura del proyecto

```text
SistemaGestionProductos_JosueMonge
│
├── Datos
│   ├── Conexion.cs
│   ├── CategoriaDatos.cs
│   └── ProductoDatos.cs
│
├── Logica
│   ├── CategoriaLogica.cs
│   └── ProductoLogica.cs
│
├── Modelos
│   ├── Categoria.cs
│   └── Producto.cs
│
├── SQL
│   └── CrearBaseDatos.sql
│
├── Form1.cs
└── Program.cs
```

## 10. Declaración del uso de inteligencia artificial

Durante el desarrollo de esta tarea programada se utilizó **ChatGPT (OpenAI)** como herramienta de apoyo.

Su utilización tuvo los siguientes propósitos:

- Consultar dudas sobre programación en C# y Windows Forms.
- Comprender el funcionamiento de clases, métodos y programación por capas.
- Obtener ejemplos de código para operaciones CRUD y validaciones.
- Apoyar la identificación y corrección de errores.
- Recibir orientación sobre la conexión entre C# y SQL Server.
- Apoyar la elaboración y organización de la documentación y del script SQL.

**Partes de la tarea en las que se utilizó como apoyo:**

- Clases y métodos de las capas de datos y lógica.
- Eventos y funcionalidades del formulario principal.
- Validaciones de categorías y productos.
- Consultas y operaciones con SQL Server.
- Elaboración del README y del script de creación de la base de datos.

El estudiante integró los códigos y las recomendaciones en el entorno de desarrollo, realizó pruebas de funcionamiento y verificó las operaciones con la base de datos. Es responsable de comprender y poder explicar el funcionamiento de todo el código presentado.

## 11. Autor

**Josué Monge**

Tarea Programada de Programación II – 2026.