--PROCEDIMIENTOS ALMACENADOS
--Agregar Produto
INSERT INTO Productos 
(Nombre, Marca, Precio, Descripcion, CategoriaId, ProveedorId)
VALUES 
(@Nombre, @Marca, @Precio, @Descripcion, @CategoriaId, @ProveedorId);
SELECT SCOPE_IDENTITY();

SELECT ProductoId, Nombre, Marca, Precio, Descripcion, CategoriaId, ProveedorId
FROM Productos
WHERE ProveedorId = 2


SELECT VentasId, Fecha, Cantidad, ProductoId, EmpleadoId, ClienteId
FROM Ventas
WHERE VentasId = 1 AND EmpleadoId = 1

SELECT VentasId,Fecha, Cantidad, ProductoId, EmpleadoId, ClienteId
FROM Ventas
WHERE EmpleadoId = 1

SELECT p.ProductoId,
p.Nombre,
p.Precio,
p.Marca,
p.Descripcion,
p.CategoriaId,
p.ProveedorId,
ca.Nombre AS CategoriaNombre,
po.Nombre AS ProveedorNombre

FROM Productos AS p
INNER JOIN Categoria AS ca ON ca.CategoriaId = p.CategoriaId
INNER JOIN Proveedores AS po ON po.ProveedorId = p.ProveedorId

UPDATE Productos
SET 
Nombre = 'Extension',
Marca = 'Truper', 
Precio = 345.00, 
Descripcion = '',
CategoriaId = 1,
ProveedorId = 1
WHERE ProductoId = 1

INSERT INTO Categoria
(Nombre, Descripcion)
VALUES
('Borrame x3', 'No lo se')
SELECT SCOPE_IDENTITY()


SELECT v.VentasId, 
v.Fecha,
v.Cantidad,
v.EmpleadoId,
v.ClienteId,
v.ProductoId,
em.Nombre AS EmpleadoNombre,
cl.Nombre AS ClienteNombre,
p.Nombre AS ProductoNombre
FROM Ventas AS v
INNER JOIN Empleados AS em ON em.EmpleadoId = v.EmpleadoId
INNER JOIN Clientes AS cl ON cl.ClienteId = v.ClienteId
INNER JOIN Productos AS p ON p.ProductoId = v.ProductoId