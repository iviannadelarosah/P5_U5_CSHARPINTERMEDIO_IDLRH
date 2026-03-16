:clock230: **Actualizaciones:**

| Fecha  | Proyecto  |
| ------------ | ------------ |
| 27/2/2026  |  5 (Creación API) |
|  6/3/2026 |  6 (Integración de autenticación) |
|  13/3/2026 | 7 (Code First) |

**Instrucciones:**

1. Debe de ejecutar el console application P5_U5_CSHARPINTERMEDIO_IDLRH para poder acceder a la API.
2. Debe de dar clic a la ventana del navegador que te llevará al **Swagger**.
3. Debe de ejecutar el endpoint /api/Auth/login para autenticar al usuario y devolver un token JWT.
4. Debe de ejecutar el endpoint /api/Auth/refresh para renovar el token JWT antes de que expire.
5. Debe de hacer las consultas especificadas: CRUD.

**¿Como ejecutar las rutas?**

> **AUTH**

1. POST[/api/Auth/login]:

<img width="1731" height="849" alt="image" src="https://github.com/user-attachments/assets/f4090710-45bd-4dca-8c46-bfc0925a19cc" />
<img width="1520" height="808" alt="image" src="https://github.com/user-attachments/assets/0717a823-a6b3-4b13-be90-60bb75593b4c" />
<img width="1520" height="808" alt="image" src="https://github.com/user-attachments/assets/f9480d7f-b0f3-43a5-bd60-6dc63c3808ff" />

**Resultado:** [200 OK]

<img width="1672" height="803" alt="image" src="https://github.com/user-attachments/assets/024c1b59-5714-4513-b984-9c97bd4b7c27" />

2. POST[/api/Auth/refresh]:

<img width="1665" height="800" alt="image" src="https://github.com/user-attachments/assets/e296b856-928c-4f13-8d6d-f37f5991413b" />
<img width="1662" height="1019" alt="image" src="https://github.com/user-attachments/assets/5a7f982d-ef78-412d-aa39-eba4f386bcdb" />
<img width="1662" height="1019" alt="image" src="https://github.com/user-attachments/assets/b49e0391-6d9c-4d98-b72b-a048ae46d83b" />

**Resultado:** [200 OK]

<img width="1657" height="842" alt="image" src="https://github.com/user-attachments/assets/48bb5519-d913-43dc-82a1-c6d32c5dd5c9" />

------------

> **Usuarios**

1. GET [/api/usuarios]: 

<img width="1856" height="1025" alt="Image" src="https://github.com/user-attachments/assets/001842c9-1f96-459a-9eed-858806f0a0c4" />
<img width="1858" height="1027" alt="Image" src="https://github.com/user-attachments/assets/6168402c-08f0-4f53-9f5e-8084d9aa8d71" />
<img width="1860" height="1026" alt="Image" src="https://github.com/user-attachments/assets/806c110a-7f70-4f2d-898b-4ae4c722a949" />

**Resultado:** [200 OK]

<img width="1858" height="1026" alt="Image" src="https://github.com/user-attachments/assets/0653ca64-4fc8-45bc-9fcc-29c6a7026805" />

**Resultado:** [401 Unauthorized]

<img width="1421" height="461" alt="image" src="https://github.com/user-attachments/assets/5fc96c98-5ea1-425f-9bfe-210e63f5143d" />

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

**Resultado:** [200 OK]

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
