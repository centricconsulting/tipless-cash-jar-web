CREATE TABLE [dbo].[recipient] (
    [recipient_key] INT           IDENTITY (100, 1) NOT NULL,
    [last_name]     VARCHAR (100) NOT NULL,
    [first_name]    VARCHAR (100) NOT NULL,
    [middle_name]   VARCHAR (100) NULL,
    [photo_url]     VARCHAR (200) NULL
);

