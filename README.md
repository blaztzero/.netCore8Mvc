# Aplicación Web MVC y API

Esta es una aplicación web construida con **ASP.NET Core** que combina una interfaz de usuario tradicional basada en el patrón **MVC (Model-View-Controller)** con una **API RESTful** para gestionar datos.  
La aplicación permite manejar registros de **pacientes, usuarios y bonos médicos**, exponiendo algunas funcionalidades como servicios de API.

---

## 🚀 Tecnologías Clave

- **ASP.NET Core**: Framework principal para construir la aplicación web y la API.  
- **Entity Framework Core**: ORM (Object-Relational Mapper) que facilita la interacción con la base de datos mediante objetos C# en lugar de sentencias SQL.  
- **SQL Server**: Sistema de gestión de bases de datos relacionales para el almacenamiento persistente de la información.  

---

## 📂 Controladores y Endpoints

A continuación se detalla la funcionalidad de cada controlador principal de la aplicación.

---

### 🌐 Controladores MVC

Estos controladores gestionan las vistas y las interacciones del usuario a través de páginas web.

---

#### 1. Bonos Fonasa (`BonosFonasasController`)

Este controlador se encarga de la gestión completa de los bonos médicos, permitiendo operaciones CRUD (Crear, Leer, Actualizar, Borrar) a través de vistas.

| Ruta (URL)                  | Acción            | Descripción                                   |
|------------------------------|------------------|-----------------------------------------------|
| **GET** /BonosFonasas       | Index            | Muestra una lista de todos los bonos Fonasa. |
| **GET** /BonosFonasas/Details/{id} | Details | Muestra los detalles de un bono específico.   |
| **GET** /BonosFonasas/Create | Create          | Muestra el formulario para crear un nuevo bono. |
| **POST** /BonosFonasas/Create | Create         | Procesa el formulario para guardar un nuevo bono. |
| **GET** /BonosFonasas/Edit/{id} | Edit         | Muestra el formulario para editar un bono.   |
| **POST** /BonosFonasas/Edit/{id} | Edit        | Procesa la actualización de un bono.         |
| **GET** /BonosFonasas/Delete/{id} | Delete     | Muestra la confirmación para eliminar un bono. |
| **POST** /BonosFonasas/Delete/{id} | DeleteConfirmed | Procesa la eliminación de un bono. |

---

#### 2. Pacientes (`PacientesController`)

Este controlador gestiona los registros de los pacientes del sistema.

| Ruta (URL)                   | Acción           | Descripción                                    |
|-------------------------------|-----------------|------------------------------------------------|
| **GET** /Pacientes           | Index           | Muestra una lista de todos los pacientes.     |
| **GET** /Pacientes/Details/{rut} | Details     | Muestra los detalles de un paciente por su RUT. |
| **GET** /Pacientes/Create    | Create          | Muestra el formulario para registrar un nuevo paciente. |
| **POST** /Pacientes/Create   | Create          | Procesa el formulario para guardar un nuevo paciente. |
| **GET** /Pacientes/Edit/{rut} | Edit           | Muestra el formulario para editar un paciente. |
| **POST** /Pacientes/Edit/{rut} | Edit          | Procesa la actualización de los datos de un paciente. |
| **GET** /Pacientes/Delete/{rut} | Delete       | Muestra la confirmación para eliminar un paciente. |
| **POST** /Pacientes/Delete/{rut} | DeleteConfirmed | Procesa la eliminación de un paciente. |

---

#### 3. Usuarios (`UsuariosController`)

Este controlador se encarga de la gestión de las cuentas de usuario.

| Ruta (URL)                   | Acción           | Descripción                                    |
|-------------------------------|-----------------|------------------------------------------------|
| **GET** /Usuarios            | Index           | Muestra una lista de todos los usuarios.      |
| **GET** /Usuarios/Details/{id} | Details        | Muestra los detalles de un usuario por su ID. |
| **GET** /Usuarios/Create     | Create          | Muestra el formulario para crear una nueva cuenta. |
| **POST** /Usuarios/Create    | Create          | Procesa la creación de una nueva cuenta.      |
| **GET** /Usuarios/Edit/{id}  | Edit            | Muestra el formulario para editar una cuenta. |
| **POST** /Usuarios/Edit/{id} | Edit            | Procesa la actualización de una cuenta.       |
| **GET** /Usuarios/Delete/{id} | Delete         | Muestra la confirmación para eliminar una cuenta. |
| **POST** /Usuarios/Delete/{id} | DeleteConfirmed | Procesa la eliminación de una cuenta. |

---

### 📡 Controladores de la API RESTful

Este controlador expone endpoints de API que devuelven datos en formato **JSON** y están diseñados para ser consumidos por otras aplicaciones.

---

#### 1. Visitas de Enfermería (`api/VisitasEnfermeriums`)

Este controlador expone una API para la gestión de las visitas de enfermería.

| Método HTTP | Endpoint                        | Descripción                                     | Cuerpo de la Solicitud (Body) | Respuesta                                   |
|-------------|---------------------------------|-------------------------------------------------|--------------------------------|---------------------------------------------|
| **GET**     | /api/VisitasEnfermeriums        | Obtiene una lista de todas las visitas de enfermería. | No requiere                     | Un array de objetos **VisitasEnfermerium**. |
| **GET**     | /api/VisitasEnfermeriums/{id}   | Obtiene una visita específica por su ID.        | No requiere                     | Un objeto **VisitasEnfermerium** o **404 Not Found**. |
| **POST**    | /api/VisitasEnfermeriums        | Crea una nueva visita.                          | Un objeto **VisitasEnfermerium** con los datos a guardar. | **201 Created** con la visita creada.       |
| **PUT**     | /api/VisitasEnfermeriums/{id}   | Actualiza una visita existente.                 | Un objeto **VisitasEnfermerium** con los datos a actualizar. | **204 No Content** en caso de éxito.       |
| **DELETE**  | /api/VisitasEnfermeriums/{id}   | Elimina una visita por su ID.                   | No requiere                     | **204 No Content** en caso de éxito.       |

---
