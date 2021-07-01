CREATE PROCEDURE [dbo].[SP_ChtlePrj_AddTraitement]
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

		Insert into Traitement(NomMedicament,Posologie,DateDebut,DateFin,Objectif,TargetPrescriptionMedical,Eleve_Id,Utilisateur_Id)
		
		Output inserted.[Id]

		values (@NomMedicament,@Posologie,@DateDebut,@DateFin,@Objectif,@TargetPrescriptionMedical,@Eleve_Id,@Utilisateur_Id);
		
		Commit;
		Return 0;
	END
	Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
