--Seleccionar datos de una tabla
SELECT 
	Id, 
	UsuarioId AS 'Usuario', 
	FechaTransaccion AS 'Fecha de Transacción', 
	TipoTransaccion AS 'Tipo', 
	Monto,
	Nota
FROM Transacciones

-- Insertar datos en una tabla
INSERT INTO Transacciones 
	(UsuarioId, FechaTransaccion, Monto, TipoTransaccion, Nota) 
VALUES 
	('jperez', '21/03/2023', 300, 1, 'Compra de pan para la semana')

-- Ordernamiento de información
SELECT * FROM Transacciones
ORDER BY Id DESC

SELECT * FROM Transacciones 
ORDER BY UsuarioId

SELECT * FROM Transacciones 
ORDER BY UsuarioId, Monto DESC

SELECT * FROM Transacciones
WHERE UsuarioId = 'jperez'
ORDER BY Monto DESC