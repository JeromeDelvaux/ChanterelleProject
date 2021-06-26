CREATE PROCEDURE [dbo].[SP_ChtlePrj_GetAllTraitementForOneEleve]
	@idEleve INT
AS
	SELECT * FROM Traitement WHERE Eleve_Id=@idEleve
RETURN 0

