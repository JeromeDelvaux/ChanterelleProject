CREATE PROCEDURE [dbo].[SP_ChtlePrj_UpdateClasse]
		@Id INT,
		@IntituleClasse NVARCHAR(50),
		@NbEleveMax INT,
		@Utilisateur_Id INT
As
Begin
	Begin Transaction
	Begin Try
	BEGIN
		UPDATE Classe
		SET IntituleClasse=@IntituleClasse,
			NbEleveMax=@NbEleveMax,
			Utilisateur_Id=@Utilisateur_Id
		WHERE Id=@Id
		Commit;
		Return 0;
	END
	End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
