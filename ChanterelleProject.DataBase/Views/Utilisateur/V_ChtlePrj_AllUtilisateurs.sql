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
		TU.IntituleTypeUtilisateur,
		P.NumInami,
		SP.IntituleSpecialisation

		FROM Utilisateur U left JOIN ParaMedical P
		ON U.Id  = P.Id left JOIN TypeUtilisateur TU 
		ON U.TypeUtilisateur_Id=TU.Id left JOIN SpecialisationParaMedical SP
		ON P.Specialisation_Id = SP.Id
		
		WHERE U.Actif='True'
