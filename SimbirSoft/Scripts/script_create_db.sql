/****** Object: Database [Simbirsoft] ******/
CREATE DATABASE [simbirSoft]
GO

USE [simbirSoft]
GO

/****** Object: Table [author] ******/
CREATE TABLE [author]
(
	[id]            [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_author] PRIMARY KEY,
	[first_name]    [nvarchar](50) NOT NULL,
	[last_name]     [nvarchar](50) NOT NULL,
	[middle_name]   [nvarchar](50) NULL
)
GO

/****** Object: Table [person] ******/
CREATE TABLE [person]
(
	[id]            [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_person] PRIMARY KEY,
	[first_name]    [nvarchar](50) NOT NULL,
	[last_name]     [nvarchar](50) NOT NULL,
	[middle_name]   [nvarchar](50) NULL,
	[birth_date]    [date] NULL
)
GO

/****** Object: Table [genre] ******/
CREATE TABLE [genre]
(
	[id]     [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_genre] PRIMARY KEY,
	[name]   [nvarchar](50) NOT NULL
)
GO

/****** Object: Table [book] ******/
CREATE TABLE [book]
(
	[id]          [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_book] PRIMARY KEY,
	[name]        [nvarchar](50) NOT NULL,
	[author_id]   [int] NOT NULL
)
GO

/****** Object: Table [book_genre] ******/
CREATE TABLE [book_genre]
(
	[book_id]    [int] NOT NULL,
	[genre_id]   [int] NOT NULL
)
GO

/****** Object: Table [library_card] ******/
CREATE TABLE [library_card]
(
	[person_id]     [int] NULL,
	[book_id]       [int] NULL,
	[taking_date]   [date] NULL
)
GO

/****** Foreign keys ******/
ALTER TABLE [book] ADD CONSTRAINT [FK_book_author] 
	FOREIGN KEY ([author_id]) 
		REFERENCES [author] ([id])
GO

ALTER TABLE [book_genre] ADD CONSTRAINT [FK_book_genre_book] 
	FOREIGN KEY ([book_id])
		REFERENCES [book] ([id])
GO

ALTER TABLE [book_genre] ADD CONSTRAINT [FK_book_genre_genre]
	FOREIGN KEY ([genre_id])
		REFERENCES [genre] ([id])
GO

ALTER TABLE [library_card] ADD CONSTRAINT [FK_library_card_book]
	FOREIGN KEY ([book_id])
		REFERENCES [book] ([id])
GO

ALTER TABLE [library_card] ADD CONSTRAINT [FK_library_card_person]
	FOREIGN KEY ([person_id])
		REFERENCES [person] ([id])
GO