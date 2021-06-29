CREATE VIEW [dbo].[V_ChtlePrj_AllClasse]

	AS SELECT C.Id,C.IntituleClasse,C.NbEleveMax,U.Nom
	FROM Classe C left JOIN Utilisateur U
	ON C.Utilisateur_Id=U.Id
