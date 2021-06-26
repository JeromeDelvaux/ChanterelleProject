CREATE PROCEDURE [dbo].[SP_ChtlePrj_GetSpecialisationParaMedicalById]
	@id INT
AS
	SELECT * FROM V_ChtlePrj_AllSpecialisationParaMedical WHERE Id = @id
RETURN 0
