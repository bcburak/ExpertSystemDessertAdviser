USE [TestExpert]
GO
/****** Object:  Table [dbo].[Meals]    Script Date: 14.02.2021 22:46:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[MealTypeId] [int] NOT NULL,
	[IsSpecial] [bit] NOT NULL,
	[RestaurantId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Meals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MealTypes]    Script Date: 14.02.2021 22:46:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MealTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dbo.MealTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 14.02.2021 22:46:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[MealId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.OrderItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 14.02.2021 22:46:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[OrderDate] [datetime] NULL,
	[Detail] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Restaurants]    Script Date: 14.02.2021 22:46:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Restaurants](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Restaurants] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 14.02.2021 22:46:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[UserName] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Meals] ON 

INSERT [dbo].[Meals] ([Id], [Title], [MealTypeId], [IsSpecial], [RestaurantId]) VALUES (11, N'Kuşbaşı Pide', 1, 0, 1)
INSERT [dbo].[Meals] ([Id], [Title], [MealTypeId], [IsSpecial], [RestaurantId]) VALUES (12, N'Adana Kebap', 1, 0, 1)
INSERT [dbo].[Meals] ([Id], [Title], [MealTypeId], [IsSpecial], [RestaurantId]) VALUES (13, N'Kazandibi', 2, 0, 1)
INSERT [dbo].[Meals] ([Id], [Title], [MealTypeId], [IsSpecial], [RestaurantId]) VALUES (14, N'Baklava', 2, 1, 1)
INSERT [dbo].[Meals] ([Id], [Title], [MealTypeId], [IsSpecial], [RestaurantId]) VALUES (15, N'Steak House', 1, 1, 2)
INSERT [dbo].[Meals] ([Id], [Title], [MealTypeId], [IsSpecial], [RestaurantId]) VALUES (16, N'Chicken Burger', 1, 0, 2)
INSERT [dbo].[Meals] ([Id], [Title], [MealTypeId], [IsSpecial], [RestaurantId]) VALUES (17, N'Supangle', 2, 1, 2)
INSERT [dbo].[Meals] ([Id], [Title], [MealTypeId], [IsSpecial], [RestaurantId]) VALUES (18, N'Ice Cream', 2, 0, 2)
INSERT [dbo].[Meals] ([Id], [Title], [MealTypeId], [IsSpecial], [RestaurantId]) VALUES (19, N'Profiterol', 2, 0, 2)
SET IDENTITY_INSERT [dbo].[Meals] OFF
GO
SET IDENTITY_INSERT [dbo].[MealTypes] ON 

INSERT [dbo].[MealTypes] ([Id], [Name]) VALUES (1, N'Yemek')
INSERT [dbo].[MealTypes] ([Id], [Name]) VALUES (2, N'Tatlı')
SET IDENTITY_INSERT [dbo].[MealTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderItems] ON 

INSERT [dbo].[OrderItems] ([Id], [OrderId], [MealId]) VALUES (2, 1, 15)
INSERT [dbo].[OrderItems] ([Id], [OrderId], [MealId]) VALUES (3, 1, 17)
INSERT [dbo].[OrderItems] ([Id], [OrderId], [MealId]) VALUES (4, 2, 16)
INSERT [dbo].[OrderItems] ([Id], [OrderId], [MealId]) VALUES (5, 2, 15)
SET IDENTITY_INSERT [dbo].[OrderItems] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [UserId], [OrderDate], [Detail]) VALUES (1, 1, CAST(N'2021-02-14T00:00:00.000' AS DateTime), N'Burger King')
INSERT [dbo].[Orders] ([Id], [UserId], [OrderDate], [Detail]) VALUES (2, 3, CAST(N'2021-02-10T00:00:00.000' AS DateTime), N'Burger King')
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Restaurants] ON 

INSERT [dbo].[Restaurants] ([Id], [Title], [Address]) VALUES (1, N'Ora Lahmacun', N'İzmir')
INSERT [dbo].[Restaurants] ([Id], [Title], [Address]) VALUES (2, N'Burger King', N'Bornova')
SET IDENTITY_INSERT [dbo].[Restaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [FullName], [Email], [UserName]) VALUES (1, N'Burak Celik', N'asdas@mail.com', N'burakcelik')
INSERT [dbo].[Users] ([Id], [FullName], [Email], [UserName]) VALUES (2, N'Efe Güre', N'afbaj@ma.con', N'efegure')
INSERT [dbo].[Users] ([Id], [FullName], [Email], [UserName]) VALUES (3, N'Yashar', N'yashar@asda', N'yashar')
INSERT [dbo].[Users] ([Id], [FullName], [Email], [UserName]) VALUES (4, N'safak', N'safak', N'safak')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Meals]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Meals_dbo.MealTypes_MealTypeId] FOREIGN KEY([MealTypeId])
REFERENCES [dbo].[MealTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Meals] CHECK CONSTRAINT [FK_dbo.Meals_dbo.MealTypes_MealTypeId]
GO
ALTER TABLE [dbo].[Meals]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Meals_dbo.Restaurants_RestaurantId] FOREIGN KEY([RestaurantId])
REFERENCES [dbo].[Restaurants] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Meals] CHECK CONSTRAINT [FK_dbo.Meals_dbo.Restaurants_RestaurantId]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OrderItems_dbo.Meals_MealId] FOREIGN KEY([MealId])
REFERENCES [dbo].[Meals] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_dbo.OrderItems_dbo.Meals_MealId]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OrderItems_dbo.Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_dbo.OrderItems_dbo.Orders_OrderId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Orders_dbo.Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_dbo.Orders_dbo.Users_UserId]
GO
