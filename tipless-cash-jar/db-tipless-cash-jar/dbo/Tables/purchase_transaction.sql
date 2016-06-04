CREATE TABLE [dbo].[purchase_transaction] (
    [purchase_transaction_key] INT             NOT NULL,
    [recipient_key]            INT             NOT NULL,
    [amount]                   NUMERIC (21, 5) NOT NULL,
    [purchase_category]        VARCHAR (50)    NOT NULL,
    [purchase_type]            VARCHAR (50)    NOT NULL,
    [vendor]                   VARCHAR (50)    NOT NULL,
    [modified_dtm]             DATETIME        NOT NULL
);

