create database StockManagementDB

USE [StockManagementDB]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 03-Jul-19 2:23:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](25) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([ID], [Name]) VALUES (1, N'Stationaryee')
INSERT [dbo].[Categories] ([ID], [Name]) VALUES (2, N'ASDF')
INSERT [dbo].[Categories] ([ID], [Name]) VALUES (3, N'fgg')
INSERT [dbo].[Categories] ([ID], [Name]) VALUES (4, N'fgg')
INSERT [dbo].[Categories] ([ID], [Name]) VALUES (5, N'fgg')
SET IDENTITY_INSERT [dbo].[Categories] OFF
