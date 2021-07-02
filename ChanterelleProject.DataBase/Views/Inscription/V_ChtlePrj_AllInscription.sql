CREATE VIEW [dbo].[V_ChtlePrj_AllInscription]
	AS SELECT 
		I.Id,
		I.DateDebut,
		I.DateFin,
		U.Nom as[NomCreateur],
		E.Nom as[NomEleve]		

		FROM Inscription I left JOIN Utilisateur U
		ON I.Utilisateur_Id  = U.Id left JOIN Eleve E ON I.Eleve_Id=E.Id
