﻿SELECT * from users;

CREATE TABLE employees
(
	id INT PRIMARY KEY IDENTITY (1,1),
	employee_id VARCHAR(MAX) NULL,
	full_name VARCHAR(MAX) NULL,
	gender VARCHAR(MAX) NULL,
	contact_number VARCHAR(MAX) NULL,
	position VARCHAR(MAX) NULL,
	image VARCHAR(MAX) NULL,
	salary FLOAT,
	insert_date DATE NULL,
	update_date DATE NULL,
	delete_date DATE NULL
)

select * from employees WHERE delete_date is null;
select * from employees ;
ALTER TABLE employees
ADD status VARCHAR(MAX) NULL;

delete from employees;