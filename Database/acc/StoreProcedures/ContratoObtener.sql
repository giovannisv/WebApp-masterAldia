CREATE PROCEDURE [acc].[ContratoObtener]
      @IdContrato int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     C.IdContrato,
	 C.TipoContrato,
	 C.FechaInicio,
	 C.FechaFin,
     
     E.IdEmpleado,
     E.Identificacion

    FROM  acc.Contrato C
    INNER JOIN dbo.Empleado E
       ON E.IdEmpleado= C.IdEmpleado
    WHERE
    (@IdContrato IS NULL OR IdContrato=@IdContrato)

END


