CREATE PROCEDURE [dbo].[SP_ChtlePrj_GetAllocationParaMedicalsById]
	@id INT
AS
	SELECT * FROM V_ChtlePrj_AllAllocationParaMedicals WHERE Id = @id
RETURN 0
