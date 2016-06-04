CREATE TABLE [dbo].[giver_card_hist] (
    [giver_card_hist_key]      INT             NOT NULL,
    [giver_key]                INT             NOT NULL,
    [card_key]                 INT             NOT NULL,
    [is_active]                BIT             NOT NULL,
    [is_locked]                BIT             NOT NULL,
    [is_donation_active]       BIT             NOT NULL,
    [daily_max_donation_total] NUMERIC (21, 5) NOT NULL,
    [start_dtm]                DATETIME        NOT NULL,
    [end_dtm]                  DATETIME        NOT NULL
);

