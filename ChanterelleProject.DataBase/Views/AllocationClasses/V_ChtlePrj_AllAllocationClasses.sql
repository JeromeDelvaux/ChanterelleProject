CREATE VIEW [dbo].[V_ChtlePrj_AllAllocationClasses]
	AS SELECT 
		AC.Id,
		AC.DateDebut,
		U.Nom,
		C.IntituleClasse		

		FROM AllocationClasses AC left JOIN Utilisateur U
		ON AC.Utilisateur_Id  = U.Id left JOIN Classe C ON AC.Classe_Id=C.Id
		
		WHERE AC.DateFin is null
