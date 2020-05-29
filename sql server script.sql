use [VideoGameArtGallery];

-- Genres
Insert into dbo.Genres (GenreName,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)
	Values('Metroidvania','Marc','2018-06-23 07:30:20','Marc','2018-06-24 07:30:20'),
	('Walking Simulator','Marc','2018-06-23 07:30:20','Marc','2018-06-24 07:30:20')
	;

	select * from dbo.Genres;
	DELETE FROM dbo.Genres
WHERE CreatedBy = 'Marc';


use [VideoGameArtGallery];

-- Games
Insert into dbo.Games(GameName,GameDescription,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,GenreId)
	Values('Call of Duty','Bow and dinosaur Robots','Marc','2018-06-23 07:30:20','Marc','2018-06-24 07:30:20',7),
	('Hollow Knight','Indiana Jones, shoot shoot','Marc','2018-06-23 07:30:20','Marc','2018-06-24 07:30:20',9)
	;

	select * from dbo.Games;
	DELETE FROM dbo.Games
WHERE CreatedBy = 'Marc';


-- ^Platforms
Insert into dbo.Platforms(SystemName,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)
	Values('PS4','Marc','2018-06-23 07:30:20','Marc','2018-06-24 07:30:20'),
	('XBOX','Marc','2018-06-23 07:30:20','Marc','2018-06-24 07:30:20'),
	('PC','Marc','2018-06-23 07:30:20','Marc','2018-06-24 07:30:20')
	;

	select * from dbo.Platforms;
	DELETE FROM dbo.Platforms
WHERE CreatedBy = 'Marc';


-- ^Platforms
Insert into dbo.GamesPlatforms(GameId,PlatformId,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)
	Values(3,4,'Marc','2018-06-23 07:30:20','Marc','2018-06-24 07:30:20'),
	(4,4,'Marc','2018-06-23 07:30:20','Marc','2018-06-24 07:30:20'),
	(5,5,'Marc','2018-06-23 07:30:20','Marc','2018-06-24 07:30:20'),
	(5,4,'Marc','2018-06-23 07:30:20','Marc','2018-06-24 07:30:20'),
	
	(6,5,'Marc','2018-06-23 07:30:20','Marc','2018-06-24 07:30:20'),
	(6,4,'Marc','2018-06-23 07:30:20','Marc','2018-06-24 07:30:20')
	
	;

	select * from dbo.GamesPlatforms;
	DELETE FROM dbo.Platforms
WHERE CreatedBy = 'Marc';