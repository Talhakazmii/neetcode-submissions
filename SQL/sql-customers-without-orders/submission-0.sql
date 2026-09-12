-- Write your query below
Select c.name from customers c
Left join orders o On c.id = o.customer_id
where o.id is null;