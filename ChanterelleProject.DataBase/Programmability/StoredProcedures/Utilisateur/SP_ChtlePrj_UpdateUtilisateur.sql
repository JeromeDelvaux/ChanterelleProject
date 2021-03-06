CREATE PROCEDURE [dbo].[SP_ChtlePrj_UpdateUtilisateur]
	@Id INT,
	@Nom NVARCHAR(50),
	@Prenom NVARCHAR(50),
	@Adresse NVARCHAR(250),
	@DateNaissance DATE,
	@RegistreNational CHAR(11),
	@Sexe NVARCHAR(5),
	@DateDebutContrat DATE,
	@Telephone INT,
	@Mail NVARCHAR(350),
	@TypeUtilisateurId INT,
	@MotDePasse Nvarchar(20)
As
Begin
	Begin Transaction
	Begin Try
	Declare @DateNow DATETIME2(7)=sysdatetime();

		UPDATE Utilisateur
		SET Nom = @Nom,
			Prenom = @Prenom,
			Adresse = @Adresse,
			DateNaissance = @DateNaissance,
			RegistreNational = @RegistreNational,
			Sexe = @Sexe,
			DateDebutContrat = @DateDebutContrat,
			DateDerniereModif=@DateNow,
			Telephone = @Telephone,
			Mail = @Mail,
			TypeUtilisateur_Id = @TypeUtilisateurId,
			MotDePasse = [dbo].SF_ChtlePrj_SalageEtHash(@MotDePasse,[Salage])
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

