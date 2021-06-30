CREATE PROCEDURE [dbo].[SP_ChtlePrj_AddAllocationClasses]
	@DateDebut DATE,
	@Utilisateur_Id INT,
	@Classe_Id INT

As
Begin
	Begin Transaction
	Begin Try

		Insert into AllocationClasses(DateDebut,Classe_Id,Utilisateur_Id)
		
		Output inserted.[Id]

		values (@DateDebut,@Classe_Id,@Utilisateur_Id);
		
		Commit;
		Return 0;
	END
	Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
