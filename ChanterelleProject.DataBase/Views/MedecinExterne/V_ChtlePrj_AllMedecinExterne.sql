CREATE VIEW [dbo].[V_ChtlePrj_AllMedecinExterne]
AS SELECT 
		[Id] ,
		[NumInami],
		[Nom],
		[Prenom],
		[Adressse],
		[Mail] ,
		[DateNaissance],
		[TelephonePerso],
		[TelephoneCabinet]

		FROM MedecinExterne
		WHERE Actif='True'
