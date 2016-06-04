CREATE TABLE [dbo].[giver] (
    [giver_key]         INT           IDENTITY (100, 1) NOT NULL,
    [last_name]         VARCHAR (100) NOT NULL,
    [first_name]        VARCHAR (100) NOT NULL,
    [middle_name]       VARCHAR (100) NULL,
    [address1]          VARCHAR (100) NULL,
    [address2]          VARCHAR (100) NULL,
    [address3]          VARCHAR (100) NULL,
    [city]              VARCHAR (50)  NULL,
    [state_or_province] VARCHAR (30)  NULL,
    [postal_code]       VARCHAR (20)  NULL,
    [country]           VARCHAR (50)  NULL,
    [email]             VARCHAR (50)  NULL,
    [phone]             VARCHAR (20)  NULL
);

