CREATE TABLE [dbo].[donation_status] (
    [donation_status_key] INT          IDENTITY (100, 1) NOT NULL,
    [donation_key]        INT          NOT NULL,
    [event_type]          INT          NOT NULL,
    [comments]            VARCHAR (50) NOT NULL,
    [create_dtm]          DATETIME     NOT NULL,
    [created_by]          VARCHAR (50) NOT NULL
);

