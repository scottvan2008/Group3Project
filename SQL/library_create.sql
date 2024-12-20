USE [Library] 
GO
/****** Object:  Table [dbo].[book]    Script Date: 2024-08-12 11:45:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book](
	[isbn] [char](17) NOT NULL,
	[book_name] [varchar](50) NOT NULL,
	[author_name] [varchar](50) NOT NULL,
	[genre] [varchar](50) NOT NULL,
	[availability] [bit] NOT NULL,
	[quantity] [int] NOT NULL
) ON [PRIMARY]
GO
