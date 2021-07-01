CREATE PROCEDURE [dbo].[SP_ChtlePrj_AddEleve]
	@Nom NVARCHAR(50),
	@Prenom NVARCHAR(50),
	@Adresse NVARCHAR(250),
	@DateNaissance DATE,
	@RegistreNational CHAR(11),
	@Sexe NVARCHAR(5),
	@Classe_Id INT,
	@MedecinExterne_Id INT

As
Begin
	Begin Transaction
	Begin Try

	IF([dbo].SF_ChtlePrj_VerifNumRegistreNational(@RegistreNational)=1)
	BEGIN
		Declare @DateNow DATETIME2(7)=sysdatetime();

		Insert into Eleve(
		Nom,
		Prenom,
		Adresse,
		DateNaissance,
		RegistreNational,
		Sexe,
		DateDerniereModif,
		Classe_Id,
		MedecinExterne_Id)
		
		Output inserted.[Id]

		values (
		@Nom,
		@Prenom,
		@Adresse,
		@DateNaissance,
		@RegistreNational,
		@Sexe,
		@DateNow,
		@Classe_Id,
		@MedecinExterne_Id);
		
		Commit;
		Return 0;
	END
	ELSE
	BEGIN
	Rollback;
		Return -2;
	END
	End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
