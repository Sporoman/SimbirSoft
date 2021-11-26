/****** Object: Database [Simbirsoft] ******/
CREATE DATABASE [simbirSoft]
GO

USE [simbirSoft]
GO

/****** Object: Table [authors] ******/
CREATE TABLE [authors]
(
	[id]            [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_authors] PRIMARY KEY,
	[first_name]    [nvarchar](50) NOT NULL,
	[last_name]     [nvarchar](50) NOT NULL,
	[middle_name]   [nvarchar](50) NULL
)
GO

/****** Object: Table [persons] ******/
CREATE TABLE [persons]
(
	[id]            [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_persons] PRIMARY KEY,
	[first_name]    [nvarchar](50) NOT NULL,
	[last_name]     [nvarchar](50) NOT NULL,
	[middle_name]   [nvarchar](50) NULL,
	[birth_date]    [date] NULL
)
GO

/****** Object: Table [genres] ******/
CREATE TABLE [genres]
(
	[id]     [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_genres] PRIMARY KEY,
	[name]   [nvarchar](50) NOT NULL
)
GO

/****** Object: Table [books] ******/
CREATE TABLE [books]
(
	[id]          [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_books] PRIMARY KEY,
	[name]        [nvarchar](50) NOT NULL,
	[author_id]   [int] NOT NULL
)
GO

/****** Object: Table [book_genres] ******/
CREATE TABLE [book_genres]
(
	[book_id]    [int] NOT NULL,
	[genre_id]   [int] NOT NULL
)
GO

/****** Object: Table [library_cards] ******/
CREATE TABLE [library_cards]
(
	[person_id]     [int] NULL,
	[book_id]       [int] NULL,
	[taking_date]   [date] NULL
)
GO

/****** Foreign keys ******/
ALTER TABLE [books] ADD CONSTRAINT [FK_books_authors] 
	FOREIGN KEY ([author_id]) 
		REFERENCES [authors] ([id])
GO

ALTER TABLE [book_genres] ADD CONSTRAINT [FK_book_genres_books] 
	FOREIGN KEY ([book_id])
		REFERENCES [books] ([id])
GO

ALTER TABLE [book_genres] ADD CONSTRAINT [FK_book_genre_genres]
	FOREIGN KEY ([genre_id])
		REFERENCES [genres] ([id])
GO

ALTER TABLE [library_cards] ADD CONSTRAINT [FK_library_cards_books]
	FOREIGN KEY ([book_id])
		REFERENCES [books] ([id])
GO

ALTER TABLE [library_cards] ADD CONSTRAINT [FK_library_cards_persons]
	FOREIGN KEY ([person_id])
		REFERENCES [persons] ([id])
GO