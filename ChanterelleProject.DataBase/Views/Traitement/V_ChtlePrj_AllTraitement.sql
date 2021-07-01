CREATE VIEW [dbo].[V_ChtlePrj_AllTraitement]
	AS SELECT 
		T.Id,
		T.NomMedicament,
		T.Posologie,
		T.DateDebut,
		T.DateFin,
		T.Objectif,
		T.TargetPrescriptionMedical,
		U.Nom as [NomCreateur],
		E.Id as[EleveId],
		E.Nom as [NomEleve]

		FROM Traitement T left JOIN Utilisateur U
		ON T.Utilisateur_Id  = U.Id left JOIN Eleve E 
		ON T.Eleve_Id=E.Id 
		
		WHERE T.Actif='True'
