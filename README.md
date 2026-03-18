> [!IMPORTANT]
>Para poder hacer login se necesita tener un usuario con su username y password registrado en la Base de Datos | Hacer un POST [/api/usuarios] si no tienes un usuario creado.

**POST[/api/Auth/login]**

<img width="1861" height="1026" alt="image" src="https://github.com/user-attachments/assets/f0c20bd7-74c4-4555-be1a-f96bd5cd50e0" />
<img width="1852" height="1026" alt="image" src="https://github.com/user-attachments/assets/4b58f99d-d8df-41ef-b071-e81d1606c023" />
<img width="1857" height="1029" alt="image" src="https://github.com/user-attachments/assets/60523279-82fb-417c-8a7b-a38b17070b7f" />
<img width="1857" height="1029" alt="image" src="https://github.com/user-attachments/assets/df169783-2e86-429e-b0e1-9337534d9d1a" />

> Resultado con credenciales correcta

<img width="1859" height="1027" alt="image" src="https://github.com/user-attachments/assets/7b4b86b2-ee78-4d55-8033-80e6d0ad27a3" />

> Resultado con credenciales incorrecta

<img width="1857" height="1030" alt="image" src="https://github.com/user-attachments/assets/cfee05fc-10ce-42d3-a0b3-a8b20808c3d3" />
<img width="1857" height="1030" alt="image" src="https://github.com/user-attachments/assets/47f8f2b9-3fdf-42d0-9b30-33a9317bbb0c" />
<img width="1859" height="945" alt="image" src="https://github.com/user-attachments/assets/7ec3e9ea-ebde-44c9-9c5b-5bf7fc1bb6fe" />

------------

<img width="1859" height="1025" alt="image" src="https://github.com/user-attachments/assets/550f0f1c-d527-400d-8e48-5964c773118d" />
<img width="1859" height="1025" alt="image" src="https://github.com/user-attachments/assets/df911392-b3f2-466d-81ee-4e7b9c2e60ee" />
<img width="1851" height="1028" alt="image" src="https://github.com/user-attachments/assets/60c08201-c798-4d34-9c53-e626f900f5c3" />


**POST[/api/Auth/refresh]**

<img width="1858" height="1026" alt="image" src="https://github.com/user-attachments/assets/282af554-7ead-424a-aff4-7d97c20076e8" />
<img width="1859" height="924" alt="image" src="https://github.com/user-attachments/assets/4eb1a235-90aa-4ed7-a72a-bf87ae6d548a" />
<img width="1857" height="1024" alt="image" src="https://github.com/user-attachments/assets/0141506f-2c0d-460d-bc36-472a06058951" />
<img width="1857" height="1024" alt="image" src="https://github.com/user-attachments/assets/0fcf8b4a-40e5-4c3a-a72b-db0c9b9e18d9" />

> [!IMPORTANT]
>El token que se debe de agregar como valor es el resreshToken del POST[/api/Auth/login] y no el token como tal.

> Resultado con token correcto

<img width="1859" height="1029" alt="image" src="https://github.com/user-attachments/assets/6c0b0c62-8563-445b-b45d-c26d5e0ce4bf" />

> Resultado con token incorrecto

<img width="1861" height="1026" alt="image" src="https://github.com/user-attachments/assets/8089b134-4337-4b3c-b351-76017f222102" />
<img width="1861" height="1026" alt="image" src="https://github.com/user-attachments/assets/8c14cf06-6667-4fec-ab57-9544b2ca586a" />
<img width="1858" height="1025" alt="image" src="https://github.com/user-attachments/assets/47ae67d8-47f6-4421-814d-0e090fc24c5a" />

> [!NOTE]
>Para las respuestas [200 OK] de c/u de los endpoints usuarios, se debe de ingresar el token generado por el endpoint POST[/api/Auth/login]

<img width="1861" height="1029" alt="image" src="https://github.com/user-attachments/assets/24006cf1-faaa-4d6d-8a7b-4e1a9aa94401" />
<img width="1869" height="1027" alt="image" src="https://github.com/user-attachments/assets/011d6171-3f87-4338-ba6a-e57a9a07dd51" />
<img width="1869" height="1027" alt="image" src="https://github.com/user-attachments/assets/60cabd7a-55aa-41d9-b0d3-b4ca0bf0d770" />
<img width="1857" height="1028" alt="image" src="https://github.com/user-attachments/assets/75819e9f-8d20-4481-8f26-d3966cb5d805" />

# Responses con token:

**GET[/api/usuarios]**

<img width="1860" height="1029" alt="image" src="https://github.com/user-attachments/assets/3ef3a1f1-e498-4446-961a-a3e8e09d9016" />
<img width="1856" height="1028" alt="image" src="https://github.com/user-attachments/assets/f80f85b7-916e-47e0-9697-d6669d827a34" />
<img width="1860" height="1026" alt="image" src="https://github.com/user-attachments/assets/ae39ec78-50c4-4c61-b72b-e6aa37232cb7" />

> Resultado

<img width="1860" height="1027" alt="image" src="https://github.com/user-attachments/assets/0b46d908-80a4-4fa6-b015-f9fa81e5c739" />

**GET[/api/usuarios/{Id}]**

<img width="1860" height="1024" alt="image" src="https://github.com/user-attachments/assets/c5132cb0-feb2-40f6-9e35-0c1da7b07960" />
<img width="1855" height="1026" alt="image" src="https://github.com/user-attachments/assets/d9849e5a-c913-44d2-8ee3-3fd7eadcd9cc" />
<img width="1853" height="1026" alt="image" src="https://github.com/user-attachments/assets/ce00cebc-554c-49e4-96cd-131ec4099318" />
<img width="1853" height="1026" alt="image" src="https://github.com/user-attachments/assets/8f0b7a36-0748-4c50-812e-a4809d9d5a18" />

> Resultado

<img width="1857" height="1026" alt="image" src="https://github.com/user-attachments/assets/3b177785-e0c8-487b-b383-5d15f064697f" />

**PUT[/api/usuarios/{Id}]**

<img width="1860" height="1024" alt="image" src="https://github.com/user-attachments/assets/61a0bfa2-31a3-40a6-9d1a-754511e5e44f" />
<img width="1860" height="1024" alt="image" src="https://github.com/user-attachments/assets/221bd5dc-a49b-4e6c-bf54-8be077a56fc1" />
<img width="1859" height="1025" alt="image" src="https://github.com/user-attachments/assets/519042a0-85c7-4130-be10-9a409291d31a" />
<img width="1859" height="1027" alt="image" src="https://github.com/user-attachments/assets/d8264753-6944-4e1b-b125-0b7a0bdd9135" />
<img width="1859" height="1027" alt="image" src="https://github.com/user-attachments/assets/3e1e5c40-967c-4e37-a711-f5d18d474c78" />
<img width="1859" height="1027" alt="image" src="https://github.com/user-attachments/assets/af691888-50f7-4c62-8068-86d586b81d94" />

> Resultado

<img width="1855" height="1026" alt="image" src="https://github.com/user-attachments/assets/62c66e1c-2949-456f-a796-7ca5ba7e2b7d" />

**DELETE[/api/usuarios/{Id}]**

<img width="1859" height="1029" alt="image" src="https://github.com/user-attachments/assets/8e903b62-5a43-4a05-8e88-bfae5385d3bf" />
<img width="1862" height="1025" alt="image" src="https://github.com/user-attachments/assets/84ac1cfe-ac22-45c9-bc2c-270da0c22387" />
<img width="1860" height="1025" alt="image" src="https://github.com/user-attachments/assets/bce862dc-d0a1-4b8c-aa31-2b6b74bd96b6" />
<img width="1860" height="1025" alt="image" src="https://github.com/user-attachments/assets/78a8b86b-a5e7-473a-add6-db643b2fee4c" />

> Resultado

<img width="1854" height="1028" alt="image" src="https://github.com/user-attachments/assets/211bee1b-e0d1-4624-8a31-1d61bde1ec9a" />

------------

# Responses sin token: 

**GET[/api/usuarios]**

<img width="1855" height="1027" alt="image" src="https://github.com/user-attachments/assets/f8c99253-3bb5-47e3-9493-5bc7e6f5eca0" />
<img width="1861" height="1027" alt="image" src="https://github.com/user-attachments/assets/176c501d-c53e-4301-86e2-608500eaadb2" />
<img width="1856" height="1026" alt="image" src="https://github.com/user-attachments/assets/f690d0e5-98ed-469f-910a-4d6b4f358e0c" />

> Resultado

<img width="1853" height="1021" alt="image" src="https://github.com/user-attachments/assets/6658941d-5d91-4090-aff5-7afabd0170a2" />

**GET[/api/usuarios/{Id}]**

<img width="1862" height="1026" alt="image" src="https://github.com/user-attachments/assets/8582f861-8af1-4cfe-abbf-49f8edad8abb" />
<img width="1859" height="1025" alt="image" src="https://github.com/user-attachments/assets/86698e8c-92df-4f23-b0d5-90c43c506c16" />
<img width="1861" height="1026" alt="image" src="https://github.com/user-attachments/assets/637003ba-686a-4a17-8c37-8dfded45ef67" />
<img width="1861" height="1026" alt="image" src="https://github.com/user-attachments/assets/47ff9e3e-5eea-48e2-b46e-72a1957aa12f" />

> Resultado

<img width="1861" height="1027" alt="image" src="https://github.com/user-attachments/assets/fd431931-d21c-4aad-bb65-a94e62695856" />

**PUT[/api/usuarios/{Id}]**

<img width="1859" height="1027" alt="image" src="https://github.com/user-attachments/assets/1cc0a69c-2ed4-4ff8-a33c-c73a26a18dec" />
<img width="1861" height="1028" alt="image" src="https://github.com/user-attachments/assets/5fff9b75-2090-4841-9889-da391858acc7" />
<img width="1857" height="1027" alt="image" src="https://github.com/user-attachments/assets/530c371d-8bb2-4234-84b8-e67eb8f0d637" />
<img width="1857" height="1027" alt="image" src="https://github.com/user-attachments/assets/17bb68db-4778-4625-8bc5-58b96af703b1" />

> Resultado

<img width="1855" height="1027" alt="image" src="https://github.com/user-attachments/assets/53fa11f4-9089-49f3-8db1-ecf3353151fe" />

**DELETE[/api/usuarios/{Id}]**

<img width="1861" height="1025" alt="image" src="https://github.com/user-attachments/assets/1afca757-56d6-4cad-a7b3-58e2b0af0481" />
<img width="1859" height="1028" alt="image" src="https://github.com/user-attachments/assets/5127ee74-413f-426e-92f5-49cc1d8bdc81" />
<img width="1859" height="1027" alt="image" src="https://github.com/user-attachments/assets/7d686c07-17b5-4a39-a258-367b5c5441ab" />
<img width="1859" height="1027" alt="image" src="https://github.com/user-attachments/assets/d1583451-0f1a-47c9-b182-e68ba61ba708" />

> Resultado

<img width="1861" height="1025" alt="image" src="https://github.com/user-attachments/assets/6f5d8e79-e031-4ae1-9325-e0a579680095" />
