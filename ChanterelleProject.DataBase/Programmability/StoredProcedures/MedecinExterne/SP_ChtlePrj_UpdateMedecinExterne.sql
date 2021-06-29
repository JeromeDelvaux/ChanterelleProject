CREATE PROCEDURE [dbo].[SP_ChtlePrj_UpdateMedecinExterne]
	@Id INT,
	@NumInami Nvarchar(50),
	@Nom NVARCHAR(50),
	@Prenom NVARCHAR(50),
	@Adresse NVARCHAR(250),
	@Mail NVARCHAR(350),
	@DateNaissance DATE,
	@TelephonePerso NVARCHAR(12),
	@TelephoneCabinet NVARCHAR(12)
As
Begin
	Begin Transaction
	Begin Try
		UPDATE MedecinExterne
		SET NumInami=@NumInami,
			Nom = @Nom,
			Prenom = @Prenom,
			Adressse = @Adresse,
			Mail = @Mail,
			DateNaissance = @DateNaissance,
			TelephonePerso=@TelephonePerso,
			TelephoneCabinet=@TelephoneCabinet

		WHERE Id = @id
			AND [Actif] = 1
			Commit;
			Return 0;
	End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
