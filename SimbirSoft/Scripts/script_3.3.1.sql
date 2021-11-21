SELECT book.name as 'Книга', genre.name as 'Жанр',
	author.first_name as 'Имя', author.last_name as 'Фамилия', author.middle_name as 'Отчество'
FROM library_card
JOIN person     ON person.id          = library_card.person_id
JOIN book       ON book.id            = library_card.book_id
JOIN book_genre ON book_genre.book_id = book.id
JOIN genre      ON genre.id           = book_genre.genre_id
JOIN author     ON author.id          = book.author_id
WHERE person.id = 1;