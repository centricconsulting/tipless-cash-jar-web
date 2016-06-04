CREATE TABLE [dbo].[giver_card] (
    [giver_card_hist_key]      INT             IDENTITY (1, 1) NOT NULL,
    [giver_key]                INT             NOT NULL,
    [card_key]                 INT             NOT NULL,
    [is_active]                BIT             NOT NULL,
    [is_locked]                BIT             NOT NULL,
    [is_donation_active]       BIT             NOT NULL,
    [daily_max_donation_total] NUMERIC (21, 5) DEFAULT ((100.00000)) NOT NULL,
    [create_dtm]               DATETIME        NOT NULL,
    [created_by]               VARCHAR (50)    NOT NULL
);

