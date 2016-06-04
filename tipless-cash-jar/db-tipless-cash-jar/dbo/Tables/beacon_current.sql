CREATE TABLE [dbo].[beacon_current] (
    [beacon_hist_key]    INT          IDENTITY (100, 1) NOT NULL,
    [beacon_key]         INT          NOT NULL,
    [beacon_uid]         VARCHAR (50) NOT NULL,
    [beacon_type_uid]    VARCHAR (50) NOT NULL,
    [recipient_key]      INT          NOT NULL,
    [card_key]           INT          NOT NULL,
    [is_active]          BIT          NOT NULL,
    [is_locked]          BIT          NOT NULL,
    [is_donation_locked] BIT          NOT NULL,
    [lock_dtm]           DATETIME     NULL,
    [create_dtm]         DATETIME     NOT NULL,
    [created_by]         VARCHAR (50) NOT NULL,
    [last_modified_dtm]  DATETIME     NOT NULL,
    [last_modified_by]   VARCHAR (50) NOT NULL
);

