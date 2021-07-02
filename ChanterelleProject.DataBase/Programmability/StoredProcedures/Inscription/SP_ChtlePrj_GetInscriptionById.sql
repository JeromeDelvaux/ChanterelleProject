CREATE PROCEDURE [dbo].[SP_ChtlePrj_GetInscriptionById]
	@id INT
AS
	SELECT * FROM V_ChtlePrj_AllInscription WHERE Id = @id
RETURN 0
