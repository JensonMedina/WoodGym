# Sistema de gestión Wood Adicction Gym
Wood Adicction Gym es un sistema de gestión para un gimnasio que permite administrar clientes, membresías, movimientos de caja y cierre de caja.
## Arquitectura
La aplicación Wood Adicction Gym fue desarrollada utilizando la metodología de tres capas, que incluye una capa de presentación, una capa de negocio y una capa de datos. Esta arquitectura proporciona una estructura modular y escalable que facilita la administración y el mantenimiento del código.
## Guía de instalación
Esta guía proporciona instrucciones detalladas sobre cómo instalar y configurar el Wood Adicction Gym en su sistema.
### Requisitos del Sistema
Antes de comenzar la instalación, asegúrese de que su sistema cumpla con los siguientes requisitos:

Sistema Operativo: Windows 7/8/10
.NET Framework 4.5 o superior
SQL Server (versión 16.0.1000.6)
### Instalación de SQL Server(Express)
1. Descargue el instalador de SQL Server desde el sitio web oficial de Microsoft: [Descargar Sql Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads "Descargar Sql Server")

3. Ejecute el archivo de instalación descargado y siga las instrucciones del asistente de instalación.

5. Durante la instalación, seleccione las características que desee instalar y configure la instancia de SQL Server según sus preferencias.

7. Una vez completada la instalación, asegúrese de que el servicio de SQL Server esté en ejecución y que pueda acceder a él.
### Creación de la Base de Datos
1. Abra SQL Server Management Studio (SSMS) y conéctese a su instancia de SQL Server.

3. Abra el archivo de script proporcionado.

5. Ejecute el script en SSMS para crear la base de datos y las tablas necesarias.

7. Asegúrese de que la base de datos se haya creado correctamente y de que tenga acceso a ella desde la aplicación.
### Instalación de Wood Adicction Gym
1. Descargue el paquete de instalación del Wood Adicction Gym desde [ubicación de descarga].

3. Ejecute el archivo de instalación y siga las instrucciones del asistente de instalación.

5. Durante la instalación, especifique la ubicación de instalación y cualquier configuración adicional requerida.

7. Una vez completada la instalación, inicie la aplicación desde el acceso directo en el escritorio o desde el menú de inicio.
## Características
### Inicio
Esta es la pantalla de inicio, desde ella puedes acceder a los dintintos modulos de la aplicación.
![](https://scontent-mad1-1.xx.fbcdn.net/v/t39.30808-6/432127756_1505766587035928_2455899362526240918_n.jpg?stp=dst-jpg_p180x540&_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=5y7etcKcm94AX-YXh27&_nc_ht=scontent-mad1-1.xx&oh=00_AfC5rdtw18L6KS0wLvQdceW9GFs_AhqwS6s-w9vx4aJcfA&oe=6606F5B8)
### Accesos
Esta pantalla es la interfaz que utilizan los clientes al ingresar al gimnasio.
- El sistema verifica si el cliente tiene permitido el acceso al gimnasio basándose en su número de documento.

-  La pantalla muestra al cliente si tiene saldo a favor, si debe alguna cuota pendiente, o si no tiene deudas.
![](https://scontent-mad2-1.xx.fbcdn.net/v/t39.30808-6/432106966_1505766590369261_6134835900933055504_n.jpg?stp=dst-jpg_p180x540&_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=9Od8wcBIEhcAX-iz8qE&_nc_ht=scontent-mad2-1.xx&oh=00_AfDH2xkBpii2NdnfGHZPYFFn21uSgjfPRaFG2_xatZj6AA&oe=6607947C)
### Socios
La pantalla de socios es una interfaz que permite a los usuarios gestionar la información de los clientes del gimnasio. Esta pantalla muestra una grilla que lista a todos los clientes registrados en el sistema, junto con sus detalles como nombre, número de documento, membresía, saldo pendiente, etc.
Además cuenta con un filtro rapido y un filtro avanzado.
![](https://scontent-mad1-1.xx.fbcdn.net/v/t39.30808-6/432102100_1505766583702595_374745419281946723_n.jpg?stp=dst-jpg_p180x540&_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_ohc=XWJ8zGX8MaMAX-RCmU7&_nc_ht=scontent-mad1-1.xx&oh=00_AfAS9xoxx9SDoNV6rAXlY1PW18IbgZn8SgLFPsirunKaDQ&oe=660856D3)
### Membresias
La pantalla de membresías es una interfaz que permite a los usuarios gestionar las diferentes membresías ofrecidas por el gimnasio. En esta pantalla, los usuarios pueden ver una lista de todas las membresías disponibles y realizar diversas acciones como agregar nuevas membresías, modificar las existentes o eliminarlas.
![](https://scontent-mad2-1.xx.fbcdn.net/v/t39.30808-6/432115832_1505766580369262_6677799342885423086_n.jpg?stp=dst-jpg_p180x540&_nc_cat=111&ccb=1-7&_nc_sid=5f2048&_nc_ohc=fVfR09Gaj2cAX-k1MZp&_nc_ht=scontent-mad2-1.xx&oh=00_AfBa-H7VLa5TDT3rBl1tQtiMaxJqUGBvtY-jSFXJ9Vsacg&oe=6607C51A)
### Caja
La pantalla de caja es una interfaz que permite a los usuarios registrar los ingresos y gastos del gimnasio. En esta pantalla, los usuarios pueden llevar un registro detallado de todas las transacciones financieras, incluyendo los ingresos por pagos de clientes, los gastos por pagos a profesores, etc.
![](https://scontent-mad2-1.xx.fbcdn.net/v/t39.30808-6/432120712_1505766593702594_6186501440621019320_n.jpg?stp=dst-jpg_p180x540&_nc_cat=109&ccb=1-7&_nc_sid=5f2048&_nc_ohc=vchI4YlYoiYAX9LaET2&_nc_ht=scontent-mad2-1.xx&oh=00_AfAP_vCYYM3qSsR1SgtM97wh_6krQuUbZrohnqrBbFNwfw&oe=6607AC8E)
### Cierre de caja
La pantalla de cierre de caja es una interfaz que permite a los usuarios realizar el cierre de caja diario o semanal. Esta pantalla muestra detalladamente los ingresos y gastos registrados durante el período seleccionado, ya sea en efectivo o por transferencia bancaria.
![](https://scontent-mad1-1.xx.fbcdn.net/v/t39.30808-6/432139715_1505766573702596_9117337561148879516_n.jpg?stp=dst-jpg_p180x540&_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=b-BOC5ZMQWMAX_1j-Hy&_nc_ht=scontent-mad1-1.xx&oh=00_AfDuouWlPAlAEoBi3H8alj4CJD51kLM46_z1EF8vMhsvxg&oe=66088059)
## Soporte
Si necesitas ayuda o tienes algún problema con Wood Adicction Gym, te puedes contactar conmigo mediante este correo: medinajenson74@gmail.com
## Contribuciones
Se aceptan pull requests. Para cambios mayores, por favor abra una incidencia primero para discutir lo que le gustaría cambiar.
Asegúrese de actualizar las pruebas según corresponda.
## Estado del Proyecto
El sistema de gestión de Wood Adicction Gym actualmente se encuentra en su versión inicial, diseñada para satisfacer las necesidades de gestión básicas del gimnasio. 
Aunque la versión actual proporciona una base sólida para la gestión del gimnasio, reconozco que siempre hay margen para mejoras y expansiones futuras. Estoy abiertos a sugerencias y comentarios de nuevos usuarios para seguir mejorando el sistema y adaptarlo a sus necesidades en constante evolución.

