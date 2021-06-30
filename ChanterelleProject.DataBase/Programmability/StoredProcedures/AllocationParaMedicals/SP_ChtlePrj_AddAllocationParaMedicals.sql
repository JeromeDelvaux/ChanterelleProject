CREATE PROCEDURE [dbo].[SP_ChtlePrj_AddAllocationParaMedicals]
	@DateDebut DATE,
	@ParaMedical_Id INT,
	@Classe_Id INT

As
Begin
	Begin Transaction
	Begin Try

		Insert into AllocationParaMedicals(DateDebut,Classe_Id,ParaMedical_Id)
		
		Output inserted.[Id]

		values (@DateDebut,@Classe_Id,@ParaMedical_Id);
		
		Commit;
		Return 0;
	END
	Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
