CREATE VIEW [dbo].[V_ChtlePrj_AllAllocationParaMedicals]
	AS	SELECT 
		APM.Id,
		APM.DateDebut,
		U.Nom,
		C.IntituleClasse		

		FROM AllocationParaMedicals APM left JOIN ParaMedical P
		ON APM.ParaMedical_Id  = P.Id left JOIN Utilisateur U 
		ON U.Id=p.Id left JOIN Classe C ON APM.Classe_Id=C.Id
		
		WHERE APM.DateFin is null
