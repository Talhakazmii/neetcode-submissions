-- Write your query below
Select customer_id from customers where year = '2020'
Group by customer_id
Having  SUM(revenue) > 0;