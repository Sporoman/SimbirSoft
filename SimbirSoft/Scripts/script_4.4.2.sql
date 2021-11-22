SELECT person.last_name as 'Фамилия', COUNT(*) as 'Кол-во просроченных книг'
FROM library_card
JOIN person ON person.id = library_card.person_id
WHERE DATEDIFF(day, library_card.taking_date, SYSDATETIME()) > 14
GROUP BY person.last_name
HAVING Count(*) > 3;