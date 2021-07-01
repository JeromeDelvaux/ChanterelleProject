CREATE PROCEDURE [dbo].[SP_ChtlePrj_UpdateTraitement]
	@Id INT,
	@NomMedicament NVARCHAR(50),
	@Posologie NVARCHAR(50),
	@DateDebut DATE,
	@DateFin DATE,
	@Objectif NVARCHAR(1500),
	@TargetPrescriptionMedical NVARCHAR(250),
	@Eleve_Id INT,
	@Utilisateur_Id INT
As
Begin
	Begin Transaction
	Begin Try
		UPDATE Traitement
		SET NomMedicament = @NomMedicament,
			Posologie = @Posologie,
			DateDebut = @DateDebut,
			DateFin = @DateFin,
			Objectif=@Objectif,
			TargetPrescriptionMedical = @TargetPrescriptionMedical,
			Eleve_Id = @Eleve_Id,
			Utilisateur_Id = @Utilisateur_Id
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