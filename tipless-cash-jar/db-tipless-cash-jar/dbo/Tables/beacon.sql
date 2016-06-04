CREATE TABLE [dbo].[beacon] (
    [beacon_key]      INT           IDENTITY (1, 1) NOT NULL,
    [beacon_uid]      VARCHAR (100) NOT NULL,
    [beacon_type_uid] VARCHAR (30)  NOT NULL,
	[beacon_issuer_key] INT NOT NULL,
    [create_dtm]      DATETIME      NOT NULL,
    [created_by]      VARCHAR (50)  NOT NULL
);

