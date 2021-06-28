CREATE PROCEDURE [dbo].[SP_ChtlePrj_AddParaMedical]
	@Nom NVARCHAR(50),
	@Prenom NVARCHAR(50),
	@Adresse NVARCHAR(250),
	@DateNaissance DATE,
	@RegistreNational CHAR(11),
	@Sexe NVARCHAR(5),
	@DateDebutContrat DATE,
	@Telephone INT,
	@Mail NVARCHAR(350),
	@TypeUtilisateurId INT,
	@MotDePasse Nvarchar(20),
	@NumInami Nvarchar(50),
	@SpecialisationId INT
	
As
Begin
	Begin Transaction
	Begin Try
		Declare @Id int;
		Declare @Uid UNIQUEIDENTIFIER;
		Declare @DateNow DATETIME2(7)=sysdatetime();/*Récupère la date actuelle*/

		Set @Uid = NEWID();

		Insert into Utilisateur(
		Nom,
		Prenom,
		Adressse,
		DateNaissance,
		RegistreNational,
		Sexe,
		DateDerniereModif,
		DateDebutContrat,
		Telephone,
		Mail,
		TypeUtilisateur_Id,
		MotDePasse,
		Salage)
		
		Output inserted.[Id]

		values (
		@Nom,
		@Prenom,
		@Adresse,
		@DateNaissance,
		@RegistreNational,
		@Sexe,
		@DateNow,
		@DateDebutContrat,
		@Telephone,
		@Mail,
		@TypeUtilisateurId,
		[dbo].SF_ChtlePrj_SalageEtHash(@MotDePasse,@Uid),
		@Uid);
		
		Set @Id = SCOPE_IDENTITY(); /*Recupération du dernier id encodé*/

		Insert into ParaMedical(Id,NumInami,Specialisation_Id) values (@Id,@NumInami,@SpecialisationId);
		Commit;
		Return 0;
	End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End


