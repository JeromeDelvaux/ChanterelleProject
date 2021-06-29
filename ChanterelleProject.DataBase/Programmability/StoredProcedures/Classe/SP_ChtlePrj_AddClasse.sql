CREATE PROCEDURE [dbo].[SP_ChtlePrj_AddClasse]
		@IntituleClasse NVARCHAR(50),
		@NbEleveMax INT,
		@Utilisateur_Id INT
As
Begin
	Begin Transaction
	Begin Try
	BEGIN
		Insert into Classe(IntituleClasse,NbEleveMax,Utilisateur_Id)
		Output inserted.[Id]
		values (@IntituleClasse,@NbEleveMax,@Utilisateur_Id);
		
		Commit;
		Return 0;
	END
	End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
