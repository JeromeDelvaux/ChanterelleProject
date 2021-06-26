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
		TU.Intitule,
		P.NumInami,
		P.Specialisation_Id

		FROM Utilisateur U left JOIN ParaMedical P
		ON U.Id  = P.Id left JOIN TypeUtilisateur TU 
		ON U.Id=TU.Id WHERE U.Actif='True'
