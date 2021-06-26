CREATE FUNCTION [dbo].[SF_ChtlePrj_VerifNumRegistreNational]
(
	@value NVARCHAR(11)
)
RETURNS BIT
AS
BEGIN
Declare @valueModifSansEspaceMilieu NVARCHAR(11)
Declare @valueModifSansEspaceAvant NVARCHAR(11)
Declare @valueModifSansEspaceArriere NVARCHAR(11)
Declare @nbLettres INT

SET @valueModifSansEspaceMilieu= REPLACE(@value, ' ', '');
SET @valueModifSansEspaceAvant= RTRIM(@valueModifSansEspaceMilieu);
SET @valueModifSansEspaceArriere= LTRIM(@valueModifSansEspaceAvant);
SET @nbLettres= LEN(@valueModifSansEspaceArriere)

IF( @nbLettres=11)
	BEGIN
		RETURN 1
	END
ELSE
	BEGIN
		RETURN 0
	END

RETURN 0
END
