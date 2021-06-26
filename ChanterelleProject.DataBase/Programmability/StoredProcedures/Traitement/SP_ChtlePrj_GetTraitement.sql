CREATE PROCEDURE [dbo].[SP_ChtlePrj_GetTraitement]
	@id INT,
	@idEleve INT
AS
	SELECT * FROM Traitement WHERE Id = @id and Eleve_Id=@idEleve
RETURN 0
