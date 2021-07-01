CREATE PROCEDURE [dbo].[SP_ChtlePrj_UpdateEleve]
	@Id INT,
	@Nom NVARCHAR(50),
	@Prenom NVARCHAR(50),
	@Adresse NVARCHAR(250),
	@DateNaissance DATE,
	@RegistreNational CHAR(11),
	@Sexe NVARCHAR(5),
	@Classe_Id INT,
	@MedecinExterne_Id Nvarchar(20)
As
Begin
	Begin Transaction
	Begin Try
	Declare @DateNow DATETIME2(7)=sysdatetime();

		UPDATE Eleve
		SET Nom = @Nom,
			Prenom = @Prenom,
			Adresse = @Adresse,
			DateNaissance = @DateNaissance,
			RegistreNational = @RegistreNational,
			Sexe = @Sexe,
			DateDerniereModif = @DateNow,
			Classe_Id=@Classe_Id,
			MedecinExterne_Id=@MedecinExterne_Id

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
