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

1. GET[/api/Usuarios]: 

<img width="1862" height="1027" alt="image" src="https://github.com/user-attachments/assets/f589bbd3-e836-4b23-a0a7-a291681e46cd" />
<img width="1468" height="648" alt="image" src="https://github.com/user-attachments/assets/485486b6-260b-44f4-b2d2-990d2fe60370" />
<img width="1508" height="730" alt="image" src="https://github.com/user-attachments/assets/c52c3ac8-d57b-4b39-a3b2-e2f7623d0185" />

**Resultado:** [200 OK]

<img width="1421" height="830" alt="image" src="https://github.com/user-attachments/assets/41f34c1b-cdd4-407e-8e9c-010a0c6bd8a3" />

**Resultado:** [401 Unauthorized]

<img width="1421" height="461" alt="image" src="https://github.com/user-attachments/assets/5fc96c98-5ea1-425f-9bfe-210e63f5143d" />

2. GET/id[/api/Usuarios/{id}]:

<img width="1854" height="1025" alt="image" src="https://github.com/user-attachments/assets/c996944b-f154-4a48-8470-92af21077574" />
<img width="1568" height="823" alt="image" src="https://github.com/user-attachments/assets/48a63c01-dbd4-4f32-883b-07bfebda98d3" />
<img width="1469" height="743" alt="image" src="https://github.com/user-attachments/assets/69fd49b9-9ae7-4743-b17c-91ff720f2d75" />

**Resultado:** [200 OK]

<img width="1471" height="883" alt="image" src="https://github.com/user-attachments/assets/dbcc908a-e802-4fe5-8ccf-d81d8070bbda" />

**Resultado:** [401 Unauthorized]

<img width="1423" height="446" alt="image" src="https://github.com/user-attachments/assets/4bbb3aaa-d897-4c8d-8d37-88f1494f1f9c" />

3. POST[/api/Usuarios]:

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

<img width="1861" height="1029" alt="image" src="https://github.com/user-attachments/assets/536d47ef-3938-4897-979d-e721fc94e2f1" />
<img width="1484" height="693" alt="image" src="https://github.com/user-attachments/assets/555d4e80-ebbd-4906-893d-894fc0c36a0a" />
<img width="1512" height="710" alt="image" src="https://github.com/user-attachments/assets/50b9d12b-f036-47e3-86a1-9354f5542c52" />

**Resultado:** [200 OK]

<img width="1502" height="802" alt="image" src="https://github.com/user-attachments/assets/bafb09b3-e414-4a12-83f3-4a25697c8b73" />

**Resultado:** [401 Unauthorized]

<img width="1417" height="551" alt="image" src="https://github.com/user-attachments/assets/c0f4f9df-497c-43db-9a2d-b9b9826fe865" />

5. DELETE/id[/api/Usuarios/{id}]:

<img width="1863" height="1029" alt="image" src="https://github.com/user-attachments/assets/205fdac7-08e4-459b-9ead-2ff05ae526ce" />
<img width="1461" height="487" alt="image" src="https://github.com/user-attachments/assets/08c813ad-345d-485d-8220-cd4e7e0a37af" />
<img width="1526" height="588" alt="image" src="https://github.com/user-attachments/assets/44884fb8-328b-414f-920e-823e8e2a84ff" />

**Resultado:** [200 OK]

<img width="1494" height="831" alt="image" src="https://github.com/user-attachments/assets/971e5806-79da-4ba6-a872-09c7e225106f" />

**Resultado:** [401 Unauthorized]

<img width="1420" height="449" alt="image" src="https://github.com/user-attachments/assets/d47b6142-14b5-4fca-a1da-21eb21958436" />
