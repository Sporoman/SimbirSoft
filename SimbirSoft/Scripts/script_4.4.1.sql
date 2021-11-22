SELECT person.last_name as 'Фамилия', book.name as 'Книга',
	DATEDIFF(day, library_card.taking_date, SYSDATETIME()) as 'Просрочка в днях'
FROM library_card
JOIN person   ON person.id   = library_card.person_id
JOIN book     ON book.id     = library_card.book_id
WHERE DATEDIFF(day, library_card.taking_date, SYSDATETIME()) > 14;