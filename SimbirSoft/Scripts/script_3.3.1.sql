SELECT book.name as '�����', genre.name as '����',
	author.first_name as '���', author.last_name as '�������', author.middle_name as '��������'
FROM library_card
JOIN person		ON person.id		  = library_card.person_id
JOIN book		ON book.id			  = library_card.book_id
JOIN book_genre ON book_genre.book_id = book.id
JOIN genre		ON genre.id			  = book_genre.genre_id
JOIN author		ON author.id		  = book.author_id
WHERE person.id = 1;