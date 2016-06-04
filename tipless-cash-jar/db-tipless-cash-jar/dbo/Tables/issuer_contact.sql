CREATE TABLE [dbo].[issuer_contact] (
    [issuer_contact_key] INT           IDENTITY (1, 1) NOT NULL,
    [last_name]          VARCHAR (100) NOT NULL,
    [first_name]         VARCHAR (100) NOT NULL,
    [email]              VARCHAR (100) NULL,
    [phone]              VARCHAR (30)  NULL,
    [is_primary]         BIT           NOT NULL
);

