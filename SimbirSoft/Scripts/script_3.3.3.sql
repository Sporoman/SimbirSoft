SELECT genre.name as 'Жанр', Count(*) as 'Количество'
FROM genre
JOIN book_genre ON book_genre.genre_id = genre.id
GROUP BY genre.name;