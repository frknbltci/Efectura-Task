USE [Efectura]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9.03.2021 18:24:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SingleId] [nvarchar](11) NULL,
	[Name] [nvarchar](100) NULL,
	[Surname] [nvarchar](100) NULL,
	[Birthday] [date] NULL,
	[Address] [nvarchar](250) NULL,
	[LastModified] [datetime] NULL,
	[CreationDate] [datetime] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [SingleId], [Name], [Surname], [Birthday], [Address], [LastModified], [CreationDate]) VALUES (1, N'1231231343', N'Furkan', N'Baltacı', CAST(N'2021-03-09' AS Date), N'ABC ADRES', CAST(N'2021-03-09T13:41:58.123' AS DateTime), CAST(N'2021-03-09T13:41:58.123' AS DateTime))
INSERT [dbo].[Users] ([Id], [SingleId], [Name], [Surname], [Birthday], [Address], [LastModified], [CreationDate]) VALUES (2, N'1231231343', N'Furkan', N'Baltacı', CAST(N'2021-03-09' AS Date), N'ABC ADRES', CAST(N'2021-03-09T13:41:58.123' AS DateTime), CAST(N'2021-03-09T13:41:58.123' AS DateTime))
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
