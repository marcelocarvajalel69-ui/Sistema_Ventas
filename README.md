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
- id_usuario
- nombre
- correo
- contraseña
- rol (cliente / admin)

### Producto
- id_producto
- nombre
- descripcion
- precio
- imagen
- id_categoria

### Categoria
- id_categoria
- nombre (Tortas, Cookies, Pies, Tartas, etc.)

### Pedido
- id_pedido
- fecha
- total
- estado (pendiente / entregado)
- id_usuario

### Detalle_Pedido
- id_detalle
- cantidad
- subtotal
- id_pedido
- id_producto

### Comentario
- id_comentario
- texto
- fecha
- id_usuario

---

## Relaciones

- Un **Usuario** puede tener muchos **Pedidos**
- Un **Pedido** puede tener muchos **Productos** (a través de Detalle_Pedido)
- Un **Producto** pertenece a una **Categoría**
- Un **Usuario** puede dejar muchos **Comentarios**

---

## Login del Panel Administrador
Pantalla de acceso exclusivo para administradores del sistema.

![Login Admin](imagenes/imgLogin.png)