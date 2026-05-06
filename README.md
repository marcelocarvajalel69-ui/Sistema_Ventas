# Sistema_Ventas

## Descripción del Negocio
Botaniq Bake es una repostería artesanal ubicada en Uruguay
que se especializa en la elaboración y venta de postres de
alta calidad. El negocio opera bajo las siguientes reglas:

---

## Reglas del Negocio

- Los productos son elaborados de forma artesanal con 
  ingredientes selectos.
- El catálogo está organizado por categorías: Tortas, Tartas,
  Pies, Cupcakes, Cookies, Alfajores, Salado, Petit Fours
  y Hora del Té.
- Los clientes pueden explorar el catálogo en línea y realizar
  pedidos personalizados según la ocasión.
- Se ofrecen tortas personalizadas para eventos como 
  cumpleaños y celebraciones especiales.
- Los clientes registrados pueden dejar comentarios sobre
  los productos y el servicio.
- Los precios están establecidos en Pesos Uruguayos según
  el tipo y tamaño del producto.
- El negocio gestiona sus ventas a través de un sistema web
  que permite administrar productos, pedidos y clientes.

---
## Entidades y Atributos

### Usuario
- id_Usuario
- Nombre_Completo (Nombre, Apellido) — atributo compuesto
- Correo
- Contraseña

### Cliente (subclase de Usuario)
- Direccion

### Administrador (subclase de Usuario)
- Nivel_Acceso

### Producto
- id_Producto
- Nombre
- Descripcion
- Precio
- Imagen
- Stock
- Personalizable 

### Categoria
- id_Categoria
- Nombre (Tortas, Cookies, Pies, Tartas, Cupcakes, Alfajores, Salado, Petit Fours)

### Pedido
- id_Pedido
- Fecha_Entrega
- Total
- Estado (pendiente / en preparacion / listo / entregado)
- Tipo_Entrega (delivery / retiro en tienda)
- Direccion_Entrega
- Nota_Personalizacion

### Detalle_Pedido
- id_Detalle
- Cantidad
- Subtotal

### Comentario
- id_Comentario
- Texto
- Fecha
- Calificacion (1 a 5 estrellas)

### Factura
- id_Factura
- Numero_Factura
- Fecha_Emision
- Total
- Estado (emitida / enviada / pagada)

---

## Relaciones

- Un **Usuario** se especializa en **Cliente** o **Administrador** (especialización disjunta)
- Un **Cliente** puede realizar muchos **Pedidos**
- Un **Pedido** contiene uno o varios **Detalle_Pedido**
- Un **Producto** puede estar en muchos **Detalle_Pedido**
- Una **Categoria** clasifica muchos **Productos**
- Un **Cliente** puede escribir muchos **Comentarios**
- Un **Pedido** genera una **Factura**

---

## Login del Panel Administrador
Pantalla de acceso exclusivo para administradores del sistema.

![Login Admin](imagenes/imgLogin.png)

---

## Enunciado del Sistema de Ventas 
Se desea diseñar una base de datos para gestionar un sistema de ventas en línea de productos de repostería, como tortas, cookies, pies y tartas. El sistema permitirá administrar usuarios, productos, pedidos, comentarios y facturación. En el sistema existen diferentes tipos de usuarios, los cuales pueden tener el rol de cliente o administrador. De cada usuario se almacena su identificador único, nombre, correo electrónico, contraseña y rol. Los usuarios pueden realizar múltiples pedidos y también pueden escribir comentarios sobre los productos o el servicio. Los productos disponibles en la tienda cuentan con información como identificador, nombre, descripción, precio e imagen. Cada producto pertenece a una categoría, como tortas, cookies, pies o tartas, y cada categoría puede agrupar varios productos. Los pedidos realizados por los usuarios incluyen datos como identificador, fecha, total y estado (pendiente o entregado). Cada pedido pertenece a un único usuario, pero un usuario puede realizar varios pedidos a lo largo del tiempo. Cada pedido está compuesto por uno o varios detalles de pedido, donde se especifica la cantidad de productos adquiridos y el subtotal correspondiente. Cada detalle de pedido está asociado a un producto específico, y un mismo producto puede aparecer en múltiples detalles de pedido. Además, el sistema permite registrar comentarios realizados por los usuarios, almacenando un identificador, el texto del comentario, la fecha y el usuario que lo realizó. Finalmente, por cada pedido generado, se emite una factura. Cada factura contiene un identificador, número de factura, fecha de emisión, total, estado (emitida, enviada o pagada) y un archivo en formato PDF. Cada pedido genera exactamente una factura, estableciendo una relación uno a uno entre pedido y factura.

---

## Diagrama Entidad Relacion (ER)

![Diagrama ER](imagenes/Diagrama%20ER.png)

---

## Esquema Relacional

![Esquema](imagenes/Esquema.png)

---

## Dashboard del Panel Administrador

![Dashboard](imagenes/Dashboard.png)

---

## Gestion (Productos)

![Productos](imagenes/products.png)
