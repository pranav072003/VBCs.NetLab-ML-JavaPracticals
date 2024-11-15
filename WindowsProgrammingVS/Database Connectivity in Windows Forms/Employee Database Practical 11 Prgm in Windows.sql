use Pranav;

/*CREATE TABLE EmployeeData(
ID INT NOT NULL IDENTITY(1,1),
NAME VARCHAR(60) NOT NULL,
EMPLOYEE_ID VARCHAR(7) PRIMARY KEY NOT NULL,
DEPARTMENT VARCHAR(60),
POST VARCHAR(60)
);*/

-- ALTER TABLE EmployeeData
-- ADD CONSTRAINT EMP_NAME_ALPHA CHECK (NAME NOT LIKE '%[^a-zA-Z]%' AND LEN(NAME)>0);

-- ALTER TABLE EmployeeData
-- ADD CONSTRAINT EMPLOYEE_ID_NUM CHECK (EMPLOYEE_ID NOT LIKE '%[^0-9]%' AND LEN(EMPLOYEE_ID) > 0);

-- INSERT INTO EmployeeData(NAME,EMPLOYEE_ID,DEPARTMENT,POST) VALUES('Pranav', '658792', 'IT Services', 'Junior Programmer');

-- INSERT INTO EmployeeData(NAME,EMPLOYEE_ID,DEPARTMENT,POST) VALUES('tyosud', '', 'IT Services', 'Junior Programmer');

Select * from EmployeeData;

-- get schema using select statement 

-- Select * from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='EmployeeData';  -- note that . operator is the same as the one used for dereferencing similar named attributes in different tables, as used in JOINS on tables

-- using alternative statement of desc in MySQL to get table schema in SQL server

-- exec sp_columns EmployeeData;