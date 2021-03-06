USE [master]
GO
/****** Object:  Database [Dictionary]    Script Date: 7.10.2015 г. 11:27:43 ч. ******/
CREATE DATABASE [Dictionary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DictionaryDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DictionaryDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DictionaryDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DictionaryDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Dictionary] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Dictionary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Dictionary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Dictionary] SET ARITHABORT OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Dictionary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Dictionary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Dictionary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Dictionary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Dictionary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Dictionary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Dictionary] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Dictionary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Dictionary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Dictionary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Dictionary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Dictionary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Dictionary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Dictionary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Dictionary] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Dictionary] SET  MULTI_USER 
GO
ALTER DATABASE [Dictionary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Dictionary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Dictionary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Dictionary] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Dictionary] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Dictionary', N'ON'
GO
USE [Dictionary]
GO
/****** Object:  Table [dbo].[Dictionary]    Script Date: 7.10.2015 г. 11:27:43 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dictionary](
	[DictionaryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Dictionary] PRIMARY KEY CLUSTERED 
(
	[DictionaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Explanations]    Script Date: 7.10.2015 г. 11:27:43 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Explanations](
	[ExplanationId] [int] IDENTITY(1,1) NOT NULL,
	[Explanation] [nvarchar](max) NOT NULL,
	[WordId] [int] NOT NULL,
	[LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_Explanations] PRIMARY KEY CLUSTERED 
(
	[ExplanationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Languages]    Script Date: 7.10.2015 г. 11:27:43 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[LanguageId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Language] PRIMARY KEY CLUSTERED 
(
	[LanguageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Synonyms]    Script Date: 7.10.2015 г. 11:27:43 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Synonyms](
	[SynonymId] [int] NOT NULL,
	[Synonym] [nvarchar](100) NOT NULL,
	[WordId] [int] NOT NULL,
 CONSTRAINT [PK_Synonyms] PRIMARY KEY CLUSTERED 
(
	[SynonymId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Translations]    Script Date: 7.10.2015 г. 11:27:43 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Translations](
	[TranslationsId] [int] IDENTITY(1,1) NOT NULL,
	[Translation] [nvarchar](100) NOT NULL,
	[WordId] [int] NOT NULL,
	[LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_TranslationWords] PRIMARY KEY CLUSTERED 
(
	[TranslationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words]    Script Date: 7.10.2015 г. 11:27:43 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words](
	[WordId] [int] IDENTITY(1,1) NOT NULL,
	[Word] [nvarchar](100) NOT NULL,
	[DictionaryId] [int] NOT NULL,
	[LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_Words] PRIMARY KEY CLUSTERED 
(
	[WordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Explanations]  WITH CHECK ADD  CONSTRAINT [FK_Explanations_Languages] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([LanguageId])
GO
ALTER TABLE [dbo].[Explanations] CHECK CONSTRAINT [FK_Explanations_Languages]
GO
ALTER TABLE [dbo].[Explanations]  WITH CHECK ADD  CONSTRAINT [FK_Explanations_Words] FOREIGN KEY([WordId])
REFERENCES [dbo].[Words] ([WordId])
GO
ALTER TABLE [dbo].[Explanations] CHECK CONSTRAINT [FK_Explanations_Words]
GO
ALTER TABLE [dbo].[Synonyms]  WITH CHECK ADD  CONSTRAINT [FK_Synonyms_Words] FOREIGN KEY([WordId])
REFERENCES [dbo].[Words] ([WordId])
GO
ALTER TABLE [dbo].[Synonyms] CHECK CONSTRAINT [FK_Synonyms_Words]
GO
ALTER TABLE [dbo].[Translations]  WITH CHECK ADD  CONSTRAINT [FK_Translations_Languages] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([LanguageId])
GO
ALTER TABLE [dbo].[Translations] CHECK CONSTRAINT [FK_Translations_Languages]
GO
ALTER TABLE [dbo].[Translations]  WITH CHECK ADD  CONSTRAINT [FK_Translations_Words] FOREIGN KEY([WordId])
REFERENCES [dbo].[Words] ([WordId])
GO
ALTER TABLE [dbo].[Translations] CHECK CONSTRAINT [FK_Translations_Words]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Dictionary] FOREIGN KEY([DictionaryId])
REFERENCES [dbo].[Dictionary] ([DictionaryId])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Dictionary]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Languages] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([LanguageId])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Languages]
GO
USE [master]
GO
ALTER DATABASE [Dictionary] SET  READ_WRITE 
GO
