CREATE TABLE [dbo].[contact](
	[contact_key] [int] IDENTITY(1,1) NOT NULL,
	[last_name] [varchar](100) NOT NULL,
	[first_name] [varchar](100) NOT NULL,
	[email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[contact_key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
