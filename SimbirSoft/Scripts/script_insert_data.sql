USE [simbirSoft]
GO

/****** Insert in [person] ******/
INSERT [person] 
	([first_name], [last_name], [middle_name], [birth_date]) 
	VALUES 
	(N'Владимир', N'Ульянов',  N'Ильич', 	CAST(N'1870-04-22' AS Date)),
	(N'Николай',  N'Воронин',  N'Петрович', CAST(N'1963-05-12' AS Date)),
	(N'Андрей',   N'Максимов', N'Иванович', CAST(N'2000-10-21' AS Date)),
	(N'Тестик',   N'Тест',	   N'Тестович', CAST(N'2003-03-23' AS Date))
GO

/****** Insert in [author] ******/
INSERT [author] 
	([first_name], [last_name], [middle_name]) 
	VALUES 
	(N'Дмитрий', N'Воронин',	N'Анатольевич'),
	(N'Гарриет', N'Бичер-Стоу', NULL),
	(N'Кнут',	 N'Гамсун',		NULL),
	(N'Тест',	 N'Тестович',	NULL)
GO

/****** Insert in [genre] ******/
INSERT [genre] 
	([name]) 
	VALUES 
	(N'Фэнтези'),
	(N'Роман'),
	(N'Научная фантастика'),
	(N'Детектив')

/****** Insert in [book] ******/
INSERT [book] 
	([name], [author_id]) 
	VALUES 
	(N'Синее пламя', 1),
	(N'Хижина дяди Тома', 2),
	(N'Плоды земли', 3),
	(N'Тестирование', 4),
	(N'Тестовик', 4),
	(N'Тест космолёта', 4),
	(N'Ночной тестировщик', 4)
GO

/****** Insert in [book_genre] ******/
INSERT [book_genre] 
	([book_id], [genre_id])
	VALUES 
	(1, 1),
	(2, 2),
	(3, 2),
	(4, 1),
	(5, 2),
	(6, 3),
	(7, 4)
GO

/****** Insert in [library_card] ******/
INSERT [library_card]
	([person_id], [book_id]) 
	VALUES 
	(1, 3),
	(2, 3),
	(3, 3),
	(1, 1),
	(2, 2),
	(4, 2),
	(4, 4),
	(4, 5),
	(4, 6),
	(4, 7)
GO