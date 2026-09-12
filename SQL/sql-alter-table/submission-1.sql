CREATE TABLE books (
  id INTEGER,
  title TEXT,
  author TEXT
);
-- Do not modify above this line --

Alter Table books
Add Column published_year integer;
Alter Table books
Rename Column id to isbn;
Alter Table books
Drop column author;









-- Do not modify below this line --
SELECT column_name, data_type, column_default
FROM information_schema.columns
WHERE table_name = 'books'
ORDER BY column_name;
