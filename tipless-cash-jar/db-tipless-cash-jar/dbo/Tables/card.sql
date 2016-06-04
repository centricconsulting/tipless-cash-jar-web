CREATE TABLE [dbo].[card] (
    [card_key]        INT         IDENTITY (1, 1) NOT NULL,
    [card_number]     BIGINT      NOT NULL,
    [expiration_mmyy] VARCHAR (4) NOT NULL
);

