Use[VideoGameArtGallery];
select * from dbo.GamesPlatforms;
DELETE FROM dbo.GamesPlatforms WHERE CreatedBy = 'Marc';
DBCC CHECKIDENT ('dbo.GamesPlatforms', RESEED, 0);
Insert into dbo.GamesPlatforms(CreatedBy,UpdatedBy,CreatedDate,UpdatedDate,GameId,PlatformId)
	Values 
		('Marc','Marc',GETDATE(),GETDATE(),1,1),
		('Marc','Marc',GETDATE(),GETDATE(),2,1),
		('Marc','Marc',GETDATE(),GETDATE(),2,2),
		('Marc','Marc',GETDATE(),GETDATE(),2,3),
		('Marc','Marc',GETDATE(),GETDATE(),3,1),
		('Marc','Marc',GETDATE(),GETDATE(),3,3),
		('Marc','Marc',GETDATE(),GETDATE(),4,1),
		('Marc','Marc',GETDATE(),GETDATE(),4,2),
		('Marc','Marc',GETDATE(),GETDATE(),4,3)
		
	;

Use[VideoGameArtGallery];
select * from dbo.Games;
DELETE FROM dbo.Games WHERE GameId <10;
DBCC CHECKIDENT ('dbo.Games', RESEED, 0);
Insert into dbo.Games(CreatedBy,UpdatedBy,CreatedDate,UpdatedDate,GameName,GameDescription,GenreId)
	Values 
		('Marc','Marc',GETDATE(),GETDATE(),'Uncharted','Indiana Jones',1),
		('Marc','Marc',GETDATE(),GETDATE(),'Call of Duty','Militar FPS',4),
		('Marc','Marc',GETDATE(),GETDATE(),'Horizon Zero Dawn','Post Apocalyptic world with giant Dino Robots',1),
		('Marc','Marc',GETDATE(),GETDATE(),'Hollow Knight','Best Game Ever',3)
	;


select * from dbo.Genres;
DELETE FROM dbo.Genres WHERE Id <12;
DBCC CHECKIDENT ('dbo.Genres', RESEED, 0);
Insert into dbo.Genres(CreatedBy,UpdatedBy,CreatedDate,UpdatedDate,GenreName)
	Values 
		('Marc','Marc',GETDATE(),GETDATE(),'Action'),
		('Marc','Marc',GETDATE(),GETDATE(),'RPG'),
		('Marc','Marc',GETDATE(),GETDATE(),'Indie'),
		('Marc','Marc',GETDATE(),GETDATE(),'FPS')
	;


select * from dbo.Images;
DELETE FROM dbo.Genres WHERE Id <12;
DBCC CHECKIDENT ('dbo.Genres', RESEED, 0);



select * from dbo.Platforms;
DELETE FROM dbo.Platforms WHERE PlatformId<10;
Insert into dbo.Platforms(CreatedBy,UpdatedBy,CreatedDate,UpdatedDate,PlatformName)
	Values 
		('Marc','Marc',GETDATE(),GETDATE(),'PS4'),
		('Marc','Marc',GETDATE(),GETDATE(),'XBOX'),
		('Marc','Marc',GETDATE(),GETDATE(),'PC')
	;
DBCC CHECKIDENT ('dbo.Platforms', RESEED, 0);