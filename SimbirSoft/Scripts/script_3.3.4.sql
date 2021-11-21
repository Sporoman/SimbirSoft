SELECT author.first_name as '���', author.last_name as '�������', author.middle_name as '��������',
	genre.name as '����', Count(*) as '���-��'
FROM author
JOIN book ON book.author_id = author.id
JOIN book_genre ON book_genre.book_id = book.id
JOIN genre ON genre.id = book_genre.genre_id
GROUP BY author.first_name, author.last_name, author.middle_name, genre.name;