CREATE PROCEDURE [dbo].[SP_ChtlePrj_GetUtilisateursById]
	@id INT
AS
	SELECT * FROM V_ChtlePrj_AllUtilisateurs WHERE Id = @id
RETURN 0

