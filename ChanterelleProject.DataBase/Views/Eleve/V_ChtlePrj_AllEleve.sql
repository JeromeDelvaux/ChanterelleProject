CREATE VIEW [dbo].[V_ChtlePrj_AllEleve]
	AS SELECT 
		E.Id,
		E.Nom,
		E.Prenom,
		E.Adresse,
		E.DateNaissance,
		E.RegistreNational,
		E.Sexe,
		E.DateDerniereModif,
		I.DateDebutInsciption,
		M.Nom as [NomMedecinExterne],
		M.Nom as [NomClasse]

		FROM Eleve E left JOIN MedecinExterne M
		ON E.MedecinExterne_Id  = M.Id left JOIN Classe C
		ON E.Classe_Id=C.Id  left Join Inscription I ON E.Id=I.Eleve_Id
		
		WHERE E.Actif='True'
