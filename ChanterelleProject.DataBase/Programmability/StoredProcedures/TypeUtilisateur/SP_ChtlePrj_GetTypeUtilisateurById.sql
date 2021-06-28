CREATE PROCEDURE [dbo].[SP_ChtlePrj_GetTypeUtilisateurById]
@id INT
AS
	SELECT * FROM V_ChtlePrj_AllTypeUtilisateur WHERE Id = @id
RETURN 0

