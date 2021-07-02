CREATE PROCEDURE [dbo].[SP_ChtlePrj_AddInscription]
	@DateDebut DATE,
	@Utilisateur_Id INT,
	@Eleve_Id INT

As
Begin
	Begin Transaction
	Begin Try

		Insert into Inscription(DateDebut,Eleve_Id,Utilisateur_Id)
		
		Output inserted.[Id]

		values (@DateDebut,@Eleve_Id,@Utilisateur_Id);
		
		Commit;
		Return 0;
	END
	Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
