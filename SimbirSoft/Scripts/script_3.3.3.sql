SELECT genre.name as '����', Count(*) as '����������'
FROM genre
JOIN book_genre ON book_genre.genre_id = genre.id
GROUP BY genre.name;