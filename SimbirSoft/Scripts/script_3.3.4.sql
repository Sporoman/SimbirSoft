SELECT author.first_name as 'Имя', author.last_name as 'Фамилия', author.middle_name as 'Отчество',
	genre.name as 'Жанр', Count(*) as 'Кол-во'
FROM author
JOIN book         ON book.author_id       = author.id
JOIN book_genre   ON book_genre.book_id   = book.id
JOIN genre        ON genre.id             = book_genre.genre_id
GROUP BY author.first_name, author.last_name, author.middle_name, genre.name;