

/****** Object:  Database [NovahubLibrary]    Script Date: 7/2/2017 5:55:06 PM ******/
CREATE DATABASE [NovahubLibrary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NovahubLibrary', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\NovahubLibrary.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NovahubLibrary_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\NovahubLibrary_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [NovahubLibrary] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NovahubLibrary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [NovahubLibrary] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [NovahubLibrary] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [NovahubLibrary] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [NovahubLibrary] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [NovahubLibrary] SET ARITHABORT OFF 
GO

ALTER DATABASE [NovahubLibrary] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [NovahubLibrary] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [NovahubLibrary] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [NovahubLibrary] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [NovahubLibrary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [NovahubLibrary] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [NovahubLibrary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [NovahubLibrary] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [NovahubLibrary] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [NovahubLibrary] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [NovahubLibrary] SET  DISABLE_BROKER 
GO

ALTER DATABASE [NovahubLibrary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [NovahubLibrary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [NovahubLibrary] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [NovahubLibrary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [NovahubLibrary] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [NovahubLibrary] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [NovahubLibrary] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [NovahubLibrary] SET RECOVERY FULL 
GO

ALTER DATABASE [NovahubLibrary] SET  MULTI_USER 
GO

ALTER DATABASE [NovahubLibrary] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [NovahubLibrary] SET DB_CHAINING OFF 
GO

ALTER DATABASE [NovahubLibrary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [NovahubLibrary] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [NovahubLibrary] SET  READ_WRITE 
GO

USE [NovahubLibrary]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 7/2/2017 5:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Cover] [nvarchar](250) NULL,
	[Description] [nvarchar](250) NULL,
	[CreateTime] [datetime] NOT NULL,
	[LastUpdateTime] [datetime] NULL,
	[DelFlag] [bit] NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Books]    Script Date: 7/2/2017 5:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](250) NOT NULL,
	[Author] [int] NOT NULL,
	[Cover] [nvarchar](250) NULL,
	[Description] [nvarchar](550) NULL,
	[Publisher] [nvarchar](250) NOT NULL,
	[Year] [int] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[LastUpdateTime] [datetime] NULL,
	[DelFlag] [bit] NULL,
	[Category] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categories]    Script Date: 7/2/2017 5:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[CreateTime] [datetime] NULL,
	[LastUpdateTime] [datetime] NULL,
	[DelFlag] [bit] NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Roles]    Script Date: 7/2/2017 5:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [varchar](20) NOT NULL,
	[RoleName] [varchar](20) NOT NULL,
	[DelFlag] [bit] NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/2/2017 5:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [varchar](20) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Role] [varchar](20) NULL,
	[DelFlag] [bit] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Author] ON 

INSERT [dbo].[Author] ([Id], [Name], [Cover], [Description], [CreateTime], [LastUpdateTime], [DelFlag]) VALUES (1, N'Paula Hawkins', N'\Images\20170702091911446.jpg', N'Paula Hawkins is the author of the #1 New York Times bestseller The Girl on the Train, which was made into a major motion picture. Her new novel of psychological suspense, Into The Water, is coming May 2.', CAST(0x0000A7A40099961A AS DateTime), NULL, 0)
INSERT [dbo].[Author] ([Id], [Name], [Cover], [Description], [CreateTime], [LastUpdateTime], [DelFlag]) VALUES (2, N'Sarah J. Maas', N'\Images\20170702091957293.jpg', N'Sarah J. Maas is the New York Times and USA Today bestselling author of the Throne of Glass series (Queen of Shadows, Book 4, will be out in September 2015), as well as the A Court of Thorns and Roses series (out 5/5/15).', CAST(0x0000A7A40099CBD4 AS DateTime), NULL, 0)
INSERT [dbo].[Author] ([Id], [Name], [Cover], [Description], [CreateTime], [LastUpdateTime], [DelFlag]) VALUES (3, N'Stephanie Garber', N'\Images\20170702092057551.jpg', N'Hi! Thanks so much for stopping by this page. I’m only on this site occasionally, so if you’d like to send me a message, please use the contact form on my website: http://stephaniegarberauthor.com. ', CAST(0x0000A7A4009A1271 AS DateTime), NULL, 0)
INSERT [dbo].[Author] ([Id], [Name], [Cover], [Description], [CreateTime], [LastUpdateTime], [DelFlag]) VALUES (4, N'Victoria Aveyard', N'\Images\20170702092156733.jpg', N'I''m a screenwriter/YA author who likes books and lists. This site is the nexus of my universe', CAST(0x0000A7A4009A57CC AS DateTime), NULL, 0)
INSERT [dbo].[Author] ([Id], [Name], [Cover], [Description], [CreateTime], [LastUpdateTime], [DelFlag]) VALUES (5, N'Neil Gaiman', N'\Images\20170702092251237.jpg', N'I read James'' Vance''s work before I met the man. He was a playwright who had discovered comics and  wrote a graphic novel called KINGS IN DISGUISE, set in the great depression. I loved it. Powerful, moving and smart.', CAST(0x0000A7A4009A97AB AS DateTime), NULL, 0)
INSERT [dbo].[Author] ([Id], [Name], [Cover], [Description], [CreateTime], [LastUpdateTime], [DelFlag]) VALUES (6, N'Cassandra Clare', N'\Images\20170702092350315.jpg', N'"Cassandra Clare was born overseas and spent her early years traveling around the world with her family and several trunks of fantasy books.', CAST(0x0000A7A4009ADCE7 AS DateTime), NULL, 0)
SET IDENTITY_INSERT [dbo].[Author] OFF
INSERT [dbo].[Books] ([Id], [Title], [Author], [Cover], [Description], [Publisher], [Year], [CreateTime], [LastUpdateTime], [DelFlag], [Category]) VALUES (1, N'Into the Water ', 1, N'\Images\20170702053405300.jpg', N'A single mother turns up dead at the bottom of the river that runs through town. Earlier in the summer, a vulnerable teenage girl met the same fate', N' G.P. Putnam''s Sons Books for Young Readers', 1962, CAST(0x0000A7A400000000 AS DateTime), CAST(0x0000A7A40121839F AS DateTime), 0, 8)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Cover], [Description], [Publisher], [Year], [CreateTime], [LastUpdateTime], [DelFlag], [Category]) VALUES (2, N'A Court of Wings and Ruin', 1, N'\Images\20170702043103753.jpg', N'Feyre has returned to the Spring Court, determined to gather information on Tamlin’s maneuverings and the invading king threatening to bring Prythian to its knees. But to do so she must play a deadly game of deceit—and one slip may spell doom not only for', N'Bloomsbury Childrens Books', 2016, CAST(0x0000A7A40110341B AS DateTime), CAST(0x0000A7A40110341B AS DateTime), 0, 9)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Cover], [Description], [Publisher], [Year], [CreateTime], [LastUpdateTime], [DelFlag], [Category]) VALUES (3, N'Caraval ', 3, N'\Images\20170702043248050.jpg', N'Scarlett Dragna has never left the tiny island where she and her sister, Tella, live with their powerful, and cruel, father. Now Scarlett’s father has arranged a marriage for her, and Scarlett thinks her dreams of seeing Caraval—the faraway, once-a-year p', N'Flatiron Books', 2016, CAST(0x0000A7A40110AE4F AS DateTime), CAST(0x0000A7A40110AE4F AS DateTime), 0, 10)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Cover], [Description], [Publisher], [Year], [CreateTime], [LastUpdateTime], [DelFlag], [Category]) VALUES (4, N'King''s Cage', 4, N'\Images\20170702051929567.jpg', N'n this breathless third installment to Victoria Aveyard’s bestselling Red Queen series, allegiances are tested on every side. And when the Lightning Girl''s spark is gone, who will light the way for the rebellion?', N'HarperTeen', 2014, CAST(0x0000A7A4011D8157 AS DateTime), CAST(0x0000A7A4011D8157 AS DateTime), 0, 12)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Cover], [Description], [Publisher], [Year], [CreateTime], [LastUpdateTime], [DelFlag], [Category]) VALUES (5, N'Norse Mythology', 4, N'\Images\20170702052021946.jpg', N'Introducing an instant classic—master storyteller Neil Gaiman presents a dazzling version of the great Norse myths.', N'W. W. Norton & Company', 2017, CAST(0x0000A7A4011DBEB8 AS DateTime), CAST(0x0000A7A4011DBEB8 AS DateTime), 0, 9)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Cover], [Description], [Publisher], [Year], [CreateTime], [LastUpdateTime], [DelFlag], [Category]) VALUES (6, N'The Hate U Give', 5, N'\Images\20170702052741114.jpg', N'Sixteen-year-old Starr Carter moves between two worlds: the poor neighborhood where she lives and the fancy suburban prep school she attends. The uneasy balance between these worlds is shattered when Starr witnesses the fatal shooting of her childhood bes', N'Balzer & Bray/Harperteen', 2017, CAST(0x0000A7A4011FC163 AS DateTime), CAST(0x0000A7A4011FC163 AS DateTime), 0, 13)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Cover], [Description], [Publisher], [Year], [CreateTime], [LastUpdateTime], [DelFlag], [Category]) VALUES (7, N'Lord of Shadows', 3, N'\Images\20170702053315231.jpg', N'A Shadowhunter’s life is bound by duty. Constrained by honor. The word of a Shadowhunter is a solemn pledge, and no vow is more sacred than the vow that binds parabatai, warrior partners—sworn to fight together, die together, but never to fall in love.', N' G.P. Putnam''s Sons Books for Young Readers', 2017, CAST(0x0000A7A400000000 AS DateTime), CAST(0x0000A7A4012148EE AS DateTime), 0, 9)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Cover], [Description], [Publisher], [Year], [CreateTime], [LastUpdateTime], [DelFlag], [Category]) VALUES (8, N'Flame in the Mist', 2, N'\Images\20170702053450606.jpg', N'The only daughter of a prominent samurai, Mariko has always known she’d been raised for one purpose and one purpose only: to marry. Never mind her cunning, which rivals that of her twin brother, Kenshin, or her skills as an accomplished alchemist. Since M', N' G.P. Putnam''s Sons Books for Young Readers', 1960, CAST(0x0000A7A400000000 AS DateTime), CAST(0x0000A7A40121BFEF AS DateTime), 0, 13)
INSERT [dbo].[Books] ([Id], [Title], [Author], [Cover], [Description], [Publisher], [Year], [CreateTime], [LastUpdateTime], [DelFlag], [Category]) VALUES (9, N'aaaaaa', 2, N'\Images\20170702054551457.jpg', N'aaaaaaaaaaaaaaaaaaaaaaaaaaaaa', N'aaaaaaaaaaaaaaaaaa', 1960, CAST(0x0000A7A400000000 AS DateTime), CAST(0x0000A7A40124C21F AS DateTime), 1, 12)
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Title], [Description], [CreateTime], [LastUpdateTime], [DelFlag]) VALUES (8, N'Fiction', N'Fiction is the classification for any story or setting that is imaginary—in other words, not based strictly on history or fact.', CAST(0x0000A7A100000000 AS DateTime), CAST(0x0000A7A2000200BC AS DateTime), 0)
INSERT [dbo].[Categories] ([Id], [Title], [Description], [CreateTime], [LastUpdateTime], [DelFlag]) VALUES (9, N'Comedy', N'The word "comedy" is derived from the Classical Greek κωμῳδία kōmōidía, which is a compound either of κῶμος kômos (revel) or κώμη kṓmē (village) and ᾠδή ōidḗ (singing)', CAST(0x0000A7A100000000 AS DateTime), CAST(0x0000A7A200022F92 AS DateTime), 0)
INSERT [dbo].[Categories] ([Id], [Title], [Description], [CreateTime], [LastUpdateTime], [DelFlag]) VALUES (10, N'Drama', N'Drama is the specific mode of fiction represented in performance.[1] The term comes from a Greek word meaning "action"', CAST(0x0000A7A20002529D AS DateTime), CAST(0x0000A7A20002529D AS DateTime), 0)
INSERT [dbo].[Categories] ([Id], [Title], [Description], [CreateTime], [LastUpdateTime], [DelFlag]) VALUES (11, N'Horror ', N'Horror is a genre of fiction which is intended to, or has the capacity to frighten, scare, disgust, or startle their readers or viewers by inducing feelings of horror and terror.', CAST(0x0000A7A20002703F AS DateTime), CAST(0x0000A7A20002703F AS DateTime), 0)
INSERT [dbo].[Categories] ([Id], [Title], [Description], [CreateTime], [LastUpdateTime], [DelFlag]) VALUES (12, N'Non-fiction', N'Non-fiction or nonfiction is content (sometimes, in the form of a story) whose creator, in good faith, assumes responsibility for the truth or accuracy of the events, people, or information presented', CAST(0x0000A7A2000291C8 AS DateTime), CAST(0x0000A7A2000291C8 AS DateTime), 0)
INSERT [dbo].[Categories] ([Id], [Title], [Description], [CreateTime], [LastUpdateTime], [DelFlag]) VALUES (13, N'Literary realism', N'Literary realism is part of the realist art movement beginning with mid nineteenth-century French literature (Stendhal), and Russian literature (Alexander Pushkin) and extending to the late nineteenth and early twentieth century', CAST(0x0000A7A20002B42D AS DateTime), CAST(0x0000A7A20002B42D AS DateTime), 0)
INSERT [dbo].[Categories] ([Id], [Title], [Description], [CreateTime], [LastUpdateTime], [DelFlag]) VALUES (14, N'Romance', N'he romance novel or romantic novel discussed in this article is the mass-market literary genre. Novels of this type of genre fiction place their primary focus on the relationship and romantic love between two people', CAST(0x0000A7A20002D6FA AS DateTime), CAST(0x0000A7A20002D6FA AS DateTime), 0)
INSERT [dbo].[Categories] ([Id], [Title], [Description], [CreateTime], [LastUpdateTime], [DelFlag]) VALUES (15, N'Satire', N'Satire is a genre of literature, and sometimes graphic and performing arts, in which vices, follies, abuses, and shortcomings are held up to ridicule', CAST(0x0000A7A20003D5EF AS DateTime), CAST(0x0000A7A20003D5EF AS DateTime), 0)
INSERT [dbo].[Categories] ([Id], [Title], [Description], [CreateTime], [LastUpdateTime], [DelFlag]) VALUES (16, N'Tragedy', N'Tragedy (from the Greek: τραγῳδία, tragōidia[a]) is a form of drama based on human suffering that invokes an accompanying catharsis or pleasure in audiences', CAST(0x0000A7A200042F23 AS DateTime), CAST(0x0000A7A200042F23 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Categories] OFF
INSERT [dbo].[Roles] ([Id], [RoleName], [DelFlag]) VALUES (N'Admin', N'Administrator ', NULL)
INSERT [dbo].[Roles] ([Id], [RoleName], [DelFlag]) VALUES (N'User', N'User Role', NULL)
INSERT [dbo].[Users] ([Id], [Email], [Password], [FirstName], [LastName], [Role], [DelFlag]) VALUES (N'CuongCN', N'nguyencongcuong.dlu@gmail.com', N'abcde12345--', N'Cuong', N'Cong', N'Admin', NULL)
INSERT [dbo].[Users] ([Id], [Email], [Password], [FirstName], [LastName], [Role], [DelFlag]) VALUES (N'LyNT4', N'lynt4@gmail.com', N'abcde12345--', N'Ly', N'Nguyen', N'User', NULL)

