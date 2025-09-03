# API de Gestión de Usuarios y Productos

Esta es una API RESTful construida con ASP.NET Core que se encarga de gestionar información de usuarios y la asignación de productos a los mismos. La API está dividida en dos controladores principales: uno para la gestión general de usuarios y otro para la relación entre usuarios y productos.

### Endpoints de la API

La API expone los siguientes endpoints para interactuar con los datos.

#### 1. Controlador de Usuarios (`api/usuarios`)

Este controlador permite realizar operaciones CRUD (Crear, Leer, Actualizar, Borrar) sobre los usuarios, además de la funcionalidad de autenticación.

| Método HTTP | Endpoint | Descripción | Cuerpo de la Solicitud (Body) | Respuesta | 
| ----- | ----- | ----- | ----- | ----- | 
| `GET` | `/api/usuarios` | Obtiene una lista de todos los usuarios registrados. | No requiere | Un array de objetos `Usuario`. | 
| `GET` | `/api/usuarios/{id}` | Obtiene un usuario específico por su ID. | No requiere | Un objeto `Usuario` si se encuentra, o un error `404 Not Found`. | 
| `POST` | `/api/usuarios` | Crea un nuevo usuario. | Un objeto `Usuario` con los datos del nuevo usuario. | Un objeto `Usuario` con el ID asignado. | 
| `PUT` | `/api/usuarios/{id}` | Actualiza un usuario existente. | Un objeto `Usuario` con los datos actualizados. | `204` No` Content` en caso de éxito. | 
| `DELETE` | `/api/usuarios/{id}` | Elimina un usuario por su ID. | No requiere | `204 No Content` en caso de éxito. | 
| `POST` | `/api/usuarios/login` | Autentica un usuario con sus credenciales. | `{ "User_Name": "string", "Pass": "string" }` | `200 OK` con un objeto `Usuario` si las credenciales son válidas, o `401 Unauthorized` si no lo son. | 

#### 2. Controlador de Productos de Usuario (`api/usuarioproducto`)

Este controlador gestiona la relación de productos asignados a un usuario, validando las credenciales del usuario en cada solicitud.

| Método HTTP | Endpoint | Descripción | Cuerpo de la Solicitud (Body) | Respuesta | 
| ----- | ----- | ----- | ----- | ----- | 
| `POST` | `/api/usuarioproducto/listar` | Lista todos los productos asignados a un usuario. | `{ "User_Name": "string", "Pass": "string" }` | Un array de productos o un error `401 Unauthorized` si las credenciales son inválidas. | 
| `POST` | `/api/usuarioproducto/asignar` | Asigna un producto a un usuario específico. | `{ "User_Name": "string", "Pass": "string", "IdProducto": 0 }` | `200` OK con un mensaje de éxito. `401 Unauthorized` si las credenciales son inválidas. | 
| `POST` | `/api/usuarioproducto/quitar` | Elimina la asignación de un producto a un usuario. | \`{ "User_Name": "string", "Pass": "string |  | 


![image](https://github.com/blaztzero/.netCore8Mvc/assets/37011968/a6b65caa-e641-408f-8f56-7ae031c93e27)

![image](https://github.com/blaztzero/.netCore8Mvc/assets/37011968/de9cd4c6-8df2-4657-9061-26b2a0475489)

![image](https://github.com/blaztzero/.netCore8Mvc/assets/37011968/fd8f2c2b-af68-423f-82cc-ceb494428ed5)

![image](https://github.com/blaztzero/.netCore8Mvc/assets/37011968/f4eaf6ba-6feb-4cfa-90e9-64d658e7a9c7)

