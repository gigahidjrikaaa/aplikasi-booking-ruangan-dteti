CREATE TABLE [dbo].[Table] (
    [Id]          INT            NOT NULL,
    [Name]        NVARCHAR (50)  NULL,
    [Seats]       NCHAR (10)     NULL,
    [Description] NVARCHAR (MAX) NULL,
    [IsBooking]   NCHAR (10)     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

