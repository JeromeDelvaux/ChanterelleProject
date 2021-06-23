CREATE VIEW [dbo].[V_ChtlePrj_AllUtilisateurs]
		AS	SELECT 
		U.Id,
		U.Nom,
		U.Prenom,
		U.Adressse,
		U.DateNaissance,
		U.RegistreNational,
		U.Sexe,
		U.DateDerniereModif,
		U.DateDebutContrat,
		U.Telephone,
		U.Mail,
		U.TypeUtilisateur_Id,
		P.NumInami,
		P.Specialisation_Id

		FROM Utilisateur U left JOIN ParaMedical P
		ON U.Id  = P.Id WHERE U.Actif='True'
