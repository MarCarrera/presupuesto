CREATE PROCEDURE Transacciones_Actualizar
@Id                     int,
@FechaTransaccion       date,
@Monto					decimal(18,2),
@MontoAnterior			decimal(18,2),
@CategoriaId			int,
@CuentaId				int,
@CuentaAnteriorId		int,
@Nota					nvarchar(1000) = NULL
AS
BEGIN
--REVERTIR TRANSACCION ANTERIOR
UPDATE Cuentas SET Balance -= @MontoAnterior
WHERE Id = @CuentaAnteriorId;

--TEALIZAR NUEVA TRANSACCION
UPDATE Cuentas SET Balance += @Monto
WHERE Id = @CuentaId

UPDATE Transacciones SET Monto =ABS(@Monto),
FechaTransaccion = @FechaTransaccion,
CategoriaId = @CategoriaId, CuentaId = @CuentaId,
Nota = @Nota
WHERE Id = @Id

END
