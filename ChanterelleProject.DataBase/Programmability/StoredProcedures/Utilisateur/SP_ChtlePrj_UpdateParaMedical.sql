CREATE PROCEDURE [dbo].[SP_ChtlePrj_UpdateParaMedical]
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
	@MotDePasse Nvarchar(20),
	@NumInami Nvarchar(50),
	@SpecialisationId INT
As
Begin
	Begin Transaction
	Begin Try

	IF EXISTS(SELECT Id FROM Utilisateur WHERE Actif=1)
		BEGIN
			UPDATE Utilisateur
			SET Nom = @Nom,
				Prenom = @Prenom,
				Adresse = @Adresse,
				DateNaissance = @DateNaissance,
				RegistreNational = @RegistreNational,
				Sexe = @Sexe,
				DateDebutContrat = @DateDebutContrat,
				Telephone = @Telephone,
				Mail = @Mail,
				TypeUtilisateur_Id = @TypeUtilisateurId,
				MotDePasse = [dbo].SF_ChtlePrj_SalageEtHash(@MotDePasse,[Salage])
			WHERE Id = @id

			UPDATE ParaMedical
			SET NumInami = @NumInami,
				Specialisation_Id = @SpecialisationId	
			WHERE Id = @id

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
