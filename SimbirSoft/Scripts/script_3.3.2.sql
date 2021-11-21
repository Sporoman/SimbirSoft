SELECT author.first_name as 'Имя', author.last_name as 'Фамилия', author.middle_name as 'Отчество',
	book.name as 'Книга', genre.name as 'Жанр'
FROM author
JOIN book			ON book.author_id		= author.id
JOIN book_genre		ON book_genre.book_id	= book.id
JOIN genre			ON genre.id				= book_genre.genre_id
WHERE author.id = 1;