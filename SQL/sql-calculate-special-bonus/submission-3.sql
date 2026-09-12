-- Write your query below
Select employee_id ,

    case 
       when employee_id % 2 = 1  AND name NOT LIKE 'M%' THEN salary
       else 0
    End as bonus

 from employees
 order by employee_id ;