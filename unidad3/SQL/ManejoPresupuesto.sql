INSERT INTO TiposCuenta
(Nombre, UsuarioId, Orden)
VALUES
(@Nombre, @UsuarioId, @Orden);

SELECT SCOPE_IDENTITY();
SELECT * FROM Usuarios

SELECT 1
FROM TiposCuenta
WHERE Nombre = @Nombre AND UsuarioId = @UsuarioId
--WHERE Nombre = 'Préstamos' AND UsuarioId = 1

-- Obtener los tipos de cuenta que pertenecen a un usuario
SELECT Id, Nombre, Orden
FROM TiposCuenta
--WHERE UsuarioId = @UsuarioId
WHERE UsuarioId = 1

-- Editar un tipo de cuenta
UPDATE TiposCuenta
SET Nombre = @Nombre
WHERE Id = @Id

-- Obtener tipo de cuenta por usuarioId
SELECT Id, Nombre, Orden
FROM TiposCuenta
WHERE Id = @Id AND UsuarioId = @UsuarioId

--Borrar tipo cuenta
DELETE FROM TiposCuenta WHERE Id= @Id;

SELECT * FROM TiposCuenta ORDER BY Orden
UPDATE TiposCuenta SET Orden = @Orden WHERE Id = @Id;

--Procedimiento Almacenado Crear Tipo Cuenta
CREATE PROCEDURE TiposCuentas_Insertar
	@Nombre NVARCHAR(50),
	@UsuarioId INT
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Orden INT;

	SELECT @Orden = COALESCE (MAX(@Orden),0)+1
	FROM TiposCuenta
	WHERE UsuarioId = @UsuarioId;

	INSERT INTO TiposCuenta (Nombre, UsuarioId, Orden)
	VALUES (@Nombre, @UsuarioId, @Orden);

	SELECT SCOPE_IDENTITY();
END

--Unir 2 tablas
SELECT
	cu.Id,
	cu.Nombre,
	cu.Balance,
	tc.Nombre AS TipoCuenta
FROM Cuentas cu
INNER JOIN TiposCuenta tc
ON tc.Id = cu.TipoCuentaId
WHERE tc.UsuarioId = 1
ORDER BY Orden
