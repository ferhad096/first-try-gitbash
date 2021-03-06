USE [MedicineDBK209]
GO
/****** Object:  Table [dbo].[Firms]    Script Date: 05/06/2021 00:14:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Firms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Firms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicine]    Script Date: 05/06/2021 00:14:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Count] [int] NOT NULL,
	[Description] [nvarchar](500) NULL,
	[ProductionDate] [datetime] NOT NULL,
	[ExpireDate] [datetime] NOT NULL,
	[FirmId] [int] NOT NULL,
	[IsReceipt] [bit] NOT NULL,
 CONSTRAINT [PK_Medicine] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicine_to_tags]    Script Date: 05/06/2021 00:14:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine_to_tags](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MedicineId] [int] NOT NULL,
	[TagId] [int] NOT NULL,
 CONSTRAINT [PK_Medicine_to_tags] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 05/06/2021 00:14:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [int] NOT NULL,
	[MedicineId] [int] NOT NULL,
	[OrderId] [int] NULL,
	[ItemPrice] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 05/06/2021 00:14:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TotalPrice] [decimal](18, 2) NULL,
	[PurchaseDate] [datetime] NULL,
	[WorderId] [int] NULL,
 CONSTRAINT [PK_Orders_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tags]    Script Date: 05/06/2021 00:14:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tags](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tags] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workers]    Script Date: 05/06/2021 00:14:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Workers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Firms] ON 

INSERT [dbo].[Firms] ([Id], [Name]) VALUES (1, N'')
INSERT [dbo].[Firms] ([Id], [Name]) VALUES (2, N'Buta Firm')
SET IDENTITY_INSERT [dbo].[Firms] OFF
GO
SET IDENTITY_INSERT [dbo].[Medicine] ON 

INSERT [dbo].[Medicine] ([Id], [Name], [Price], [Count], [Description], [ProductionDate], [ExpireDate], [FirmId], [IsReceipt]) VALUES (1, N'', CAST(0.00 AS Decimal(18, 2)), 0, N'', CAST(N'2021-06-03T15:10:09.523' AS DateTime), CAST(N'2021-06-03T15:10:09.507' AS DateTime), 1, 0)
INSERT [dbo].[Medicine] ([Id], [Name], [Price], [Count], [Description], [ProductionDate], [ExpireDate], [FirmId], [IsReceipt]) VALUES (2, N'', CAST(0.00 AS Decimal(18, 2)), 0, N'', CAST(N'2021-06-03T15:10:29.633' AS DateTime), CAST(N'2021-06-03T15:10:29.620' AS DateTime), 1, 0)
INSERT [dbo].[Medicine] ([Id], [Name], [Price], [Count], [Description], [ProductionDate], [ExpireDate], [FirmId], [IsReceipt]) VALUES (3, N'', CAST(0.00 AS Decimal(18, 2)), 0, N'', CAST(N'2021-06-03T15:13:44.357' AS DateTime), CAST(N'2021-06-03T15:13:44.343' AS DateTime), 1, 0)
INSERT [dbo].[Medicine] ([Id], [Name], [Price], [Count], [Description], [ProductionDate], [ExpireDate], [FirmId], [IsReceipt]) VALUES (4, N'', CAST(0.00 AS Decimal(18, 2)), 0, N'', CAST(N'2021-06-03T15:18:56.250' AS DateTime), CAST(N'2021-06-03T15:18:56.237' AS DateTime), 1, 0)
INSERT [dbo].[Medicine] ([Id], [Name], [Price], [Count], [Description], [ProductionDate], [ExpireDate], [FirmId], [IsReceipt]) VALUES (5, N'', CAST(0.00 AS Decimal(18, 2)), 0, N'', CAST(N'2021-06-03T15:20:19.527' AS DateTime), CAST(N'2021-06-03T15:20:19.513' AS DateTime), 1, 0)
INSERT [dbo].[Medicine] ([Id], [Name], [Price], [Count], [Description], [ProductionDate], [ExpireDate], [FirmId], [IsReceipt]) VALUES (6, N'Nimesil', CAST(2.50 AS Decimal(18, 2)), 20, N'almayin', CAST(N'2021-06-03T15:20:50.857' AS DateTime), CAST(N'2025-06-20T15:20:50.000' AS DateTime), 2, 1)
SET IDENTITY_INSERT [dbo].[Medicine] OFF
GO
ALTER TABLE [dbo].[Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Medicine_Firms] FOREIGN KEY([FirmId])
REFERENCES [dbo].[Firms] ([Id])
GO
ALTER TABLE [dbo].[Medicine] CHECK CONSTRAINT [FK_Medicine_Firms]
GO
ALTER TABLE [dbo].[Medicine_to_tags]  WITH CHECK ADD  CONSTRAINT [FK_Medicine_to_tags_Medicine] FOREIGN KEY([MedicineId])
REFERENCES [dbo].[Medicine] ([Id])
GO
ALTER TABLE [dbo].[Medicine_to_tags] CHECK CONSTRAINT [FK_Medicine_to_tags_Medicine]
GO
ALTER TABLE [dbo].[Medicine_to_tags]  WITH CHECK ADD  CONSTRAINT [FK_Medicine_to_tags_Tags] FOREIGN KEY([TagId])
REFERENCES [dbo].[Tags] ([Id])
GO
ALTER TABLE [dbo].[Medicine_to_tags] CHECK CONSTRAINT [FK_Medicine_to_tags_Tags]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Orders]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Medicine] FOREIGN KEY([MedicineId])
REFERENCES [dbo].[Medicine] ([Id])
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_Orders_Medicine]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Workers1] FOREIGN KEY([WorderId])
REFERENCES [dbo].[Workers] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Workers1]
GO
