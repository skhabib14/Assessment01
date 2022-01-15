USE [AssessmentDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 09/17/2021 4:31:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 09/17/2021 4:31:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Rating] [nvarchar](max) NULL,
	[Category] [nvarchar](max) NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210915184421_MovieAddDb', N'5.0.5')
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 
GO
INSERT [dbo].[Movies] ([Id], [Title], [Rating], [Category]) VALUES (1, N'The Matrix', N'7.5', N'Action')
GO
INSERT [dbo].[Movies] ([Id], [Title], [Rating], [Category]) VALUES (2, N'Focus', N'6.9', N'Comedy')
GO
INSERT [dbo].[Movies] ([Id], [Title], [Rating], [Category]) VALUES (3, N'The Lazarus Effect', N'6.4', N'Thriller')
GO
INSERT [dbo].[Movies] ([Id], [Title], [Rating], [Category]) VALUES (4, N'Everly', N'5.0', N'Action')
GO
INSERT [dbo].[Movies] ([Id], [Title], [Rating], [Category]) VALUES (5, N'Maps to the Stars', N'7.5', N'Drama')
GO
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
