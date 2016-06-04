CREATE TABLE [dbo].[DonationEntities] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [BeaconNumber] NVARCHAR (MAX)   NULL,
    [Amount]       INT              NOT NULL,
    [GiverId]      UNIQUEIDENTIFIER NOT NULL,
    [WhenCreated]  DATETIME         NOT NULL,
    [WhenModified] DATETIME         NULL,
    CONSTRAINT [PK_dbo.DonationEntities] PRIMARY KEY CLUSTERED ([Id] ASC)
);

