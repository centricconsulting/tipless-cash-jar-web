CREATE TABLE [dbo].[beacon_issuer] (
    [beacon_issuer_key]        INT           IDENTITY (1, 1) NOT NULL,
    [issuer_organization_name] VARCHAR (100) NOT NULL,
    [primary_contact_key]      INT           NOT NULL,
    [active_recipients_ind]    BIT           NOT NULL,
    [active_issuer_ind]        BIT           NOT NULL
);

