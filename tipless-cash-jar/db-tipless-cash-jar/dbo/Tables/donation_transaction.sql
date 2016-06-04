CREATE TABLE [dbo].[donation_transaction] (
    [donation_key]       INT             NOT NULL,
    [beacon_hist_key]    INT             NOT NULL,
    [giver_hist_key]     INT             NOT NULL,
    [donation_amount]    NUMERIC (21, 5) NOT NULL,
    [submit_dtm]         DATETIME        NOT NULL,
    [transaction_status] VARCHAR (50)    NOT NULL,
    [modified_dtm]       DATETIME        NOT NULL
);

