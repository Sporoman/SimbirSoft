SELECT author.first_name as '���', author.last_name as '�������', author.middle_name as '��������',
	book.name as '�����', genre.name as '����'
FROM author
JOIN book		ON book.author_id	  = author.id
JOIN book_genre ON book_genre.book_id = book.id
JOIN genre		ON genre.id			  = book_genre.genre_id
WHERE author.id = 1;