CREATE PROCEDURE [dbo].[SP_ChtlePrj_AddUtilisateur]
	@Nom NVARCHAR(50),
	@Prenom NVARCHAR(50),
	@Adresse NVARCHAR(250),
	@DateNaissance DATE,
	@RegistreNational CHAR(11),
	@Sexe NVARCHAR(5),
	@DateDebutContrat DATE,
	@Telephone NVARCHAR(12),
	@Mail NVARCHAR(350),
	@TypeUtilisateurId INT,
	@MotDePasse Nvarchar(20)

As
Begin
	Begin Transaction
	Begin Try

	IF([dbo].SF_ChtlePrj_VerifNumRegistreNational(@RegistreNational)=1)
	BEGIN
		Declare @Uid UNIQUEIDENTIFIER;
		Declare @DateNow DATETIME2(7)=sysdatetime();
		Set @Uid = NEWID();

		Insert into Utilisateur(
		Nom,
		Prenom,
		Adresse,
		DateNaissance,
		RegistreNational,
		Sexe,
		DateDerniereModif,
		DateDebutContrat,
		Telephone,
		Mail,
		TypeUtilisateur_Id,
		MotDePasse,
		Salage)
		
		Output inserted.[Id]

		values (
		@Nom,
		@Prenom,
		@Adresse,
		@DateNaissance,
		@RegistreNational,
		@Sexe,
		@DateNow,
		@DateDebutContrat,
		@Telephone,
		@Mail,
		@TypeUtilisateurId,
		[dbo].SF_ChtlePrj_SalageEtHash(@MotDePasse,@Uid),
		@Uid);
		
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