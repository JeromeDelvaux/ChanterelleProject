CREATE FUNCTION [dbo].[SF_ChtlePrj_SalageEtHash]
(
	@value NVARCHAR(20),
	@salt UNIQUEIDENTIFIER
)
RETURNS BINARY(64)
AS
BEGIN
	DECLARE @encrypted NVARCHAR(68);
	SET @encrypted = CONCAT(@salt,@value);
	RETURN HASHBYTES('SHA2_512', @encrypted)
END
