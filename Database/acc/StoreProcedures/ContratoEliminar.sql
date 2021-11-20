﻿CREATE PROCEDURE [acc].[ContratoEliminar]
 @IdContrato int


AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
            DELETE FROM acc.Contrato WHERE IdContrato=@IdContrato
	
	  COMMIT TRANSACTION TRASA
	  SELECT 0 AS CodeError, '' AS MsgError

  END TRY

  BEGIN CATCH

	   SELECT 
			 ERROR_NUMBER() AS CodeError,
			 ERROR_MESSAGE() AS MsgError
   
	   ROLLBACK TRANSACTION TRASA

   END CATCH

 END
