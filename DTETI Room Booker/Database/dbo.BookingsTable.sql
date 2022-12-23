CREATE TABLE [dbo].[BookingsTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Date] DATETIME NULL, 
    [isBooked] INT NULL, 
    [Room_ID] INT NULL
)
