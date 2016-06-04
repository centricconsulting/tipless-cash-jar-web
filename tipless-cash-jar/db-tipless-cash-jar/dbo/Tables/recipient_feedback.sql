CREATE TABLE [dbo].[recipient_feedback] (
    [feedback_key]  INT           IDENTITY (100, 1) NOT NULL,
    [recipient_key] INT           NOT NULL,
    [giver_key]     INT           NOT NULL,
    [is_like]       BIT           NOT NULL,
    [is_dislike]    BIT           NOT NULL,
    [is_void]       BIT           NOT NULL,
    [comments]      VARCHAR (500) NULL,
    [create_dtm]    DATETIME      NOT NULL,
    [created_by]    VARCHAR (50)  NOT NULL,
    [modified_dtm]  DATETIME      NOT NULL,
    [modified_by]   VARCHAR (50)  NOT NULL
);

