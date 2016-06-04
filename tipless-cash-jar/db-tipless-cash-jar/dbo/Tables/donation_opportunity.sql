CREATE TABLE [dbo].[donation_opportunity] (
    [donation_key]    INT             IDENTITY (100, 1) NOT NULL,
    [beacon_hist_key] INT             NOT NULL,
    [giver_hist_key]  INT             NOT NULL,
    [giver_response]  VARCHAR (20)    NULL,
    [donation_amount] NUMERIC (21, 5) NOT NULL,
    [create_dtm]      DATETIME        NOT NULL,
    [donation_status] VARCHAR (50)    NOT NULL,
    [modified_dtm]    DATETIME        NOT NULL
);

