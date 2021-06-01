CREATE PROCEDURE [dbo].[SP_ChtlePrj_UpdateUtilisateur]
	@Id INT,
	@Nom NVARCHAR(50),
	@Prenom NVARCHAR(50),
	@Adressse NVARCHAR(250),
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
		UPDATE Utilisateur
		SET Nom = @Nom,
			Prenom = @Prenom,
			Adressse = @Adressse,
			DateNaissance = @DateNaissance,
			RegistreNational = @RegistreNational,
			Sexe = @Sexe,
			DateDebutContrat = @DateDebutContrat,
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

