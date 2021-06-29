
/*Insertion Table: TypeUtilisateur*/

		Insert into dbo.TypeUtilisateur(IntituleTypeUtilisateur)
		values ('Directrice')
		Insert into dbo.TypeUtilisateur(IntituleTypeUtilisateur)
		values ('EquipePluridisciplinaire')
		Insert into dbo.TypeUtilisateur(IntituleTypeUtilisateur)
		values ('AssistanteSocial')


/*Insertion Table: Utilisateur*/

	/*InsertionUtilisateur1*/
		Declare @Uid UNIQUEIDENTIFIER;
		Declare @DateNow DATETIME2(7)=sysdatetime();
		SET @Uid = NEWID();

		Insert into dbo.Utilisateur(Nom,Prenom,Adressse,DateNaissance,DateDebutContrat,RegistreNational,Sexe,DateDerniereModif,Telephone,Mail,TypeUtilisateur_Id,MotDePasse,Salage)
		values 
		(
		'Doe',
		'John',
		'Rue de morgue casier C',
		'1970-01-01', 
		@DateNow,
		'10002928389',
		'Homme',
		@DateNow,
		'0498567894',
		'john.doe@unknow.com',
		1,
		[dbo].SF_ChtlePrj_SalageEtHash('Test1234=',@Uid),
		@Uid);

	/*InsertionUtilisateur2*/
		SET @DateNow =sysdatetime();
		SET @Uid = NEWID();

		Insert into dbo.Utilisateur(Nom,Prenom,Adressse,DateNaissance,DateDebutContrat,RegistreNational,Sexe,DateDerniereModif,Telephone,Mail,TypeUtilisateur_Id,MotDePasse,Salage)
		values 
		(
		'Mouse',
		'Mickey',
		'Rue de la souris verte, 15 , 15000 WaltDisney',
		'1979-05-20', 
		@DateNow,
		'00012928389',
		'Homme',
		@DateNow,
		'0476589546',
		'mickey.mouse@waltdisney.com',
		2,
		[dbo].SF_ChtlePrj_SalageEtHash('Test1234=',@Uid),
		@Uid);

	/*InsertionUtilisateur3*/
		SET @DateNow =sysdatetime();
		SET @Uid = NEWID();

		Insert into dbo.Utilisateur(Nom,Prenom,Adressse,DateNaissance,DateDebutContrat,RegistreNational,Sexe,DateDerniereModif,Telephone,Mail,TypeUtilisateur_Id,MotDePasse,Salage)
		values 
		(
		'Donald',
		'Duck',
		'Rue de la tunne, 301 , 15000 WaltDisney',
		'1986-06-25', 
		@DateNow,
		'00112928389',
		'Homme',
		@DateNow,
		'0476589546',
		'donald.duck@waltdisney.com',
		3,
		[dbo].SF_ChtlePrj_SalageEtHash('Test1234=',@Uid),
		@Uid);


/*Insertion Table: SpecialisationParaMedical*/

			Insert into dbo.SpecialisationParaMedical(IntituleSpecialisation)
			values ('Pediatre')
			Insert into dbo.SpecialisationParaMedical(IntituleSpecialisation)
			values ('Kinesithérapeute')
			Insert into dbo.SpecialisationParaMedical(IntituleSpecialisation)
			values ('Logopede')

/*Insertion Table: InsertionParaMedical*/

	/*InsertionParaMedical1*/
			Declare @IdParaMedical int;
			SET @DateNow =sysdatetime();
			SET @Uid = NEWID();

			Insert into dbo.Utilisateur(Nom,Prenom,Adressse,DateNaissance,DateDebutContrat,RegistreNational,Sexe,DateDerniereModif,Telephone,Mail,TypeUtilisateur_Id,MotDePasse,Salage)
			values 
			(
			'Cendrillon',
			'Lecendriller',
			'Rue de la coquine, 356 , 15000 WaltDisney',
			'1992-06-25', 
			@DateNow,
			'22112928389',
			'Femme',
			@DateNow,
			'0476589546',
			'donald.duck@waltdisney.com',
			1,
			[dbo].SF_ChtlePrj_SalageEtHash('Test1234=',@Uid),
			@Uid);

			Set @IdParaMedical = SCOPE_IDENTITY(); /*Recupération du dernier id encodé*/
			Insert into ParaMedical(Id,NumInami,Specialisation_Id) values (@IdParaMedical,22112928389,1);

/*Insertion Table: MedecinExterne*/

	/*MedecinExterne1*/
			

			Insert into dbo.MedecinExterne(NumInami,Nom,Prenom,Adressse,Mail,DateNaissance,TelephonePerso,TelephoneCabinet)
			values 
			(
			'22112928389',
			'Alice',
			'Lachiante',
			'Rue du reve, 5 , 15000 WaltDisney',
			'alice.lachiante@waltdisney.com',
			'1995-03-18', 
			'0276582541',
			'0496579526');