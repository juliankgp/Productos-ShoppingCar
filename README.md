# Productos-ShoppingCar
API productos se encarga de crear y traer todos los productos que sean necesarios 

## Versión
API Backend en .net core version netcoreapp3.1


## Porque?


El API *Productos-ShoppingCar* es un backend para un proyecto de carrito de compras, el cual tiene como finalidad mostrar los conocimientos adquiridos en las tecnologías necesarias para el rol.


Esta API se encarga de gestionar todo el catalogo de productos del carrito de mercado, recibe peticiones del [**Orq-ShoppingCar**](https://github.com/juliankgp/Orq-ShoppingCar), y crea o devuelve los productos solicitados. 


## ¿Cómo funciona?
Lo primero que se debe hacer es descargar el repositorio en una máquina local, al hacer esto se descarga un proyecto de tipo API Web.NetCore para poder ejecutarlo puede usar Visual studio, o si quiere ejecutarlo en algún otro editor de código como VSC puede leer el siguiente artículo [**Visual Studio Code: cómo preparar un entorno de trabajo para .NET**](https://www.campusmvp.es/recursos/post/visual-studio-code-como-preparar-un-entorno-de-trabajo-para-net-core.aspx). Debe tener en cuenta que antes de iniciar Angular se deben iniciar SQL server managment studio y las tres APIS que conforman la prueba (en primer lugar [**Logistica-ShoppingCar**](https://github.com/juliankgp/Logistica-ShoppingCar), es muy importante que sé la primera que se ejecute, ya que esta API creara la base de datos donde se harán todas las consultas, luego de esta podemos continuar con [**Orq-ShoppingCar**](https://github.com/juliankgp/Orq-ShoppingCar)). Una vez completados este paso ya podrá arrancar la API que lo redirige directamente al swagger donde se muestra toda la documentación de esta. 



## Librerías


- *Microsoft.EntityFrameworkCore.SqlServer:* esta librería se usa para la conexion con la base de datos.
- *Microsoft.VisualStudio.Azure.Containers.Tools.Targets:* esta librería se instala por defecto cuando se configura el campo de Docker al crear la API.
- *Serilog*: Esta librería se usa para el manejo de loggers dentro del API
- *Swashbuckle.AspNetCore:* Esta librería se utiliza para poder  configurar el swagger.





## Instalación

Descargue el proyecto en una ruta en su PC, y abra la carpeta con su editor de código de preferencia, si usa Visual Studio, solo deberá ejecutar el proyecto **Api.Productos.WebApi** y el **IIS Express**


## Pruebas unitarias 
### XUnit
No pude implentar pruebas para esta API 


## Repositorios relacionados

La aplicación consta de cuatro repositorios incluido este  para funcionar:

[**Front-ShoppingCar**](https://github.com/juliankgp/Front-ShoppingCar) : Este repositorio es el front de la aplicación, se encarga de mostrar la interfaz gráfica de nuestra aplicación.

[**Orq-ShoppingCar**](https://github.com/juliankgp/Orq-ShoppingCar): Este repositorio es un API que se encarga de gestionar todas las peticiones del Frontend, dependiendo de lo que necesite hace un llamado a otras apis, o devuelve la información pertinente. 

[**Logistica-ShoppingCar**](https://github.com/juliankgp/Logistica-ShoppingCar) : Este repositorio es el principal del backend, se encarga de generar la estructura de la base de datos y de gestionar todo lo referente a los pedidos enviados desde la API [**Orq-ShoppingCar**](https://github.com/juliankgp/Orq-ShoppingCar).

## Métodos



[*Api Productos*](https://github.com/juliankgp/Productos-ShoppingCar)

| Nombre | Path | Método |
| ------ | ------ |-------|
| CrearProducto  | [*api/Productos/CrearProducto*](https://github.com/juliankgp/Productos-ShoppingCar)| POST |
| GetProductos |[*api/Productos/GetProductos*](https://github.com/juliankgp/Productos-ShoppingCar) |GET|
| GetProductoById | [*api/Productos/GetProductoById*](https://github.com/juliankgp/Productos-ShoppingCar) |GET|
