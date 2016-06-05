CREATE TABLE [dbo].[beacon_hist] (
    [beacon_hist_key]   INT          NOT NULL,
    [beacon_key]        INT          NOT NULL,
    [recipient_key]     INT          NOT NULL,
    [card_key]          INT          NOT NULL,
    [is_active]         BIT          NOT NULL,
    [is_locked]         BIT          NOT NULL,
    [lock_dtm]          DATETIME     NOT NULL,
    [start_dtm]         DATETIME     NOT NULL,
    [end_dtm]           DATETIME     NOT NULL,
    [last_modified_dtm] DATETIME     NOT NULL,
    [last_modified_by]  VARCHAR (50) NOT NULL
);

