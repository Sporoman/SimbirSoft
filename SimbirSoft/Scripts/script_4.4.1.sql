SELECT person.last_name as '�������', book.name as '�����',
	DATEDIFF(day, library_card.taking_date, SYSDATETIME()) as '��������� � ����'
FROM library_card
JOIN person   ON person.id   = library_card.person_id
JOIN book     ON book.id     = library_card.book_id
WHERE DATEDIFF(day, library_card.taking_date, SYSDATETIME()) > 14;