:clock230: **Actualizaciones:**

| Fecha  | Proyecto  |
| ------------ | ------------ |
| 27/2/2026  |  5 (Creación API) |
|  6/3/2026 |  6 (Integración de autenticación) |
|  13/3/2026 | 7 (Code First) |

**Instrucciones:**

1. Debe de ejecutar el console application P5_U5_CSHARPINTERMEDIO_IDLRH para poder acceder a la API.
2. Debe de dar clic a la ventana del navegador que te llevará al **Swagger**.

> [!NOTE]
>Para poder hacer el login, debes de tener un usuario ya guardado en la base de datos.
3. Debe de ejecutar el endpoint /api/Auth/login para autenticar al usuario y devolver un token JWT.
4. Debe de hacer las consultas especificadas: CRUD.
> [!NOTE]
>Si quieres renovar el token JWT antes de que expire, puedes ejecutar el endpoint /api/Auth/refresh

**¿Como ejecutar las rutas?**

> **AUTH**

1. POST[/api/Auth/login]:

<img width="1860" height="1026" alt="Image" src="https://github.com/user-attachments/assets/70f1d812-dbc4-45c5-b074-33f34ac95f1b" />
<img width="1859" height="1025" alt="Image" src="https://github.com/user-attachments/assets/e15bc060-30d7-45e7-8d17-33d5fa0e910e" />
<img width="1860" height="1027" alt="Image" src="https://github.com/user-attachments/assets/5d1d108b-1f01-431b-b6d5-d53ca94510f8" />
<img width="1860" height="1027" alt="Image" src="https://github.com/user-attachments/assets/25d07b8e-f67b-4776-add7-1ef901185bd2" />

**Resultado:** [200 OK]

<img width="1859" height="1026" alt="Image" src="https://github.com/user-attachments/assets/1d41db88-7488-4639-b3d5-f45fde8f827e" />

2. POST[/api/Auth/refresh]:

<img width="1857" height="1025" alt="Image" src="https://github.com/user-attachments/assets/1de45dd1-11b3-4bda-b04e-bef9dd21d03d" />
<img width="1859" height="1024" alt="Image" src="https://github.com/user-attachments/assets/eefb740f-d52e-4abe-9075-8b9180881c0f" />
<img width="1860" height="1026" alt="Image" src="https://github.com/user-attachments/assets/7be84808-1b60-4c0a-8b2b-edad50ffcfed" />
<img width="1860" height="1026" alt="Image" src="https://github.com/user-attachments/assets/b05b4c8e-3172-459e-b01a-3cfeaa744c4a" />

**Resultado:** [200 OK]

<img width="1855" height="1028" alt="Image" src="https://github.com/user-attachments/assets/058fddc0-9b41-41a2-95dc-f2dd3127e147" />

------------

> **Usuarios**

1. GET [/api/usuarios]: 

<img width="1856" height="1025" alt="Image" src="https://github.com/user-attachments/assets/001842c9-1f96-459a-9eed-858806f0a0c4" />
<img width="1858" height="1027" alt="Image" src="https://github.com/user-attachments/assets/6168402c-08f0-4f53-9f5e-8084d9aa8d71" />
<img width="1860" height="1026" alt="Image" src="https://github.com/user-attachments/assets/806c110a-7f70-4f2d-898b-4ae4c722a949" />

**Resultado:** [200 OK]

<img width="1858" height="1026" alt="Image" src="https://github.com/user-attachments/assets/0653ca64-4fc8-45bc-9fcc-29c6a7026805" />

**Resultado:** [401 Unauthorized]

<img width="1854" height="1028" alt="Image" src="https://github.com/user-attachments/assets/7707bbdd-67c5-4bd6-b066-b5344774ee80" />

2. GET/Id [/api/usuarios/{Id}]:

<img width="1861" height="1027" alt="Image" src="https://github.com/user-attachments/assets/2d281530-9594-4f4b-a350-a6a0dd2befd7" />
<img width="1859" height="1027" alt="Image" src="https://github.com/user-attachments/assets/d8b283db-23e7-478b-803b-5ed76dd5c929" />
<img width="1859" height="1026" alt="Image" src="https://github.com/user-attachments/assets/b738d213-5dff-4a40-a31c-e545aef9c961" />
<img width="1859" height="1026" alt="Image" src="https://github.com/user-attachments/assets/022ffed5-f41e-41da-94ee-ae972eaf3813" />

**Resultado:** [200 OK]

<img width="1857" height="1024" alt="Image" src="https://github.com/user-attachments/assets/cf0a6e3c-6c85-47db-8c95-fb8b009eeb61" />

**Resultado:** [401 Unauthorized]

<img width="1423" height="446" alt="image" src="https://github.com/user-attachments/assets/4bbb3aaa-d897-4c8d-8d37-88f1494f1f9c" />

3. POST [/api/usuarios]:

<img width="1861" height="1026" alt="Image" src="https://github.com/user-attachments/assets/223b02f7-5ac2-4b63-8c4a-f2f9c7a5ab8f" />
<img width="1853" height="1027" alt="Image" src="https://github.com/user-attachments/assets/813351b5-b0f3-40d9-b8a9-500b38a813a6" />

> [!NOTE]
>Ya que tenemos el campo Id como un campo auto incrementable, se elimina.
<img width="1858" height="1025" alt="Image" src="https://github.com/user-attachments/assets/7567202c-fc00-4455-bde0-5257e478eca2" />
<img width="1860" height="1024" alt="Image" src="https://github.com/user-attachments/assets/217b9802-c9b7-417c-8591-58709bbc7557" />

**Resultado:** [201 Created]

<img width="1859" height="1027" alt="Image" src="https://github.com/user-attachments/assets/1393af1c-85b0-4156-b216-6af4013b0fd9" />

**Resultado:** [400 Bad Request]

> [!IMPORTANT]
>Este resultado es a la hora de postear un usuario nuevo con un correo que ya existe en la base de datos.
<img width="1858" height="1025" alt="Image" src="https://github.com/user-attachments/assets/db1f1a98-7a2f-43e2-b9d7-119fab0c99d8" />
<img width="1858" height="1025" alt="Image" src="https://github.com/user-attachments/assets/9d6b6aad-37e6-4cc5-9147-df7a81d2588e" />
<img width="1860" height="1026" alt="Image" src="https://github.com/user-attachments/assets/a653ffb1-5f08-46c6-a6c0-20899da72fa7" />

**Resultado:** [401 Unauthorized]

<img width="1418" height="547" alt="image" src="https://github.com/user-attachments/assets/c3c7fdaf-3b3d-4ba4-9fc3-068ee1ea9136" />

4. PUT/id[/api/Usuarios/{id}]:

<img width="1859" height="1027" alt="Image" src="https://github.com/user-attachments/assets/b9a64b98-533a-4c0a-aec5-b62ad83d40aa" />
<img width="1860" height="1029" alt="Image" src="https://github.com/user-attachments/assets/799d5335-d09c-4e07-9228-dd90a38d58f5" />
<img width="1858" height="1024" alt="Image" src="https://github.com/user-attachments/assets/0de5c90d-c660-4fb8-8623-6b404fed8297" />

> [!IMPORTANT]
>Tenemos que poner en el Id(id) el mismo valor del usuario que queremos actualizar.
<img width="1858" height="1024" alt="Image" src="https://github.com/user-attachments/assets/51c4b165-db98-4e0e-a748-2bb331218dac" />
<img width="1858" height="1024" alt="Image" src="https://github.com/user-attachments/assets/824e2b3e-f4ee-45c6-9edf-bd575e8ac810" />

**Resultado:** [204 No Content]

<img width="1860" height="1025" alt="Image" src="https://github.com/user-attachments/assets/f68aa5a0-b6a8-4d7c-82ee-8819c39806bc" />

**Resultado:** [401 Unauthorized]

<img width="1417" height="551" alt="image" src="https://github.com/user-attachments/assets/c0f4f9df-497c-43db-9a2d-b9b9826fe865" />

5. DELETE/id[/api/Usuarios/{id}]:

<img width="1861" height="1025" alt="Image" src="https://github.com/user-attachments/assets/d4c991d6-ecf9-4036-9138-7dc91a1f87fa" />
<img width="1860" height="1026" alt="Image" src="https://github.com/user-attachments/assets/7101e6f1-2e06-43fe-88f0-80c11eef1ba5" />
<img width="1857" height="1027" alt="Image" src="https://github.com/user-attachments/assets/f20339ee-bfe5-4830-962b-c1edfd2036bf" />
<img width="1857" height="1027" alt="Image" src="https://github.com/user-attachments/assets/b6da462e-82e0-4917-94ee-7263707ab8d2" />

**Resultado:** [204 No Content]

<img width="1856" height="1027" alt="Image" src="https://github.com/user-attachments/assets/a57d5fbe-8a17-47f1-847a-26eb77d6014d" />

**Resultado:** [401 Unauthorized]

<img width="1420" height="449" alt="image" src="https://github.com/user-attachments/assets/d47b6142-14b5-4fca-a1da-21eb21958436" />
