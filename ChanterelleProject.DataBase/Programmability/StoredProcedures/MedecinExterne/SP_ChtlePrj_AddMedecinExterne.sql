CREATE PROCEDURE [dbo].[SP_ChtlePrj_AddMedecinExterne]
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

		Insert into MedecinExterne(
		NumInami,
		Nom,
		Prenom,
		Adresse,
		Mail,
		DateNaissance,
		TelephonePerso,
		TelephoneCabinet
		)
		
		Output inserted.[Id]

		values (
		@NumInami,
		@Nom,
		@Prenom,
		@Adresse,
		@Mail,
		@DateNaissance,
		@TelephonePerso,
		@TelephoneCabinet
		);

		Commit;
		Return 0;
	End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
