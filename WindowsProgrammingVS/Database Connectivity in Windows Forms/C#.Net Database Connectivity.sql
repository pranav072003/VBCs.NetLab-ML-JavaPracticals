-- CREATE DATABASE Pranav;

-- create a form comprising of fields, department(as a drop down menu), name (as First name and last name), enrollment (to be entered by user), subjects, course (as a drop down menu)

use Pranav;   -- need to use the database, the table needs to be stored in it

/* CREATE TABLE MyFirstTable(
ID INT NOT NULL IDENTITY(1,1),
NAME VARCHAR(60) NOT NULL,
ENROLLMENT_NUM VARCHAR(12) PRIMARY KEY NOT NULL,
DEPARTMENT VARCHAR(60),
COURSE VARCHAR(60)
); */

-- INSERT INTO MyFirstTable(NAME,ENROLLMENT_NUM,DEPARTMENT,COURSE) VALUES('Pranav', '00516403221', 'USICT', 'B.Tech');

-- alter the table to add constraints for the table attributes/columns

-- ALTER TABLE MyFirstTable
-- ADD CONSTRAINT NAME_ALPHA CHECK (NAME NOT LIKE '%[^a-zA-Z]%' AND LEN(NAME)>0);

-- ALTER TABLE MyFirstTable
-- ADD CONSTRAINT ENROLL_NUM CHECK (ENROLLMENT_NUM NOT LIKE '%[^0-9]%' AND LEN(ENROLLMENT_NUM) > 0);

-- INSERT INTO MyFirstTable(NAME,ENROLLMENT_NUM,DEPARTMENT,COURSE) VALUES('Prince', '053t346789', 'USICT', 'B.Tech');

Select * from MyFirstTable;

-- get schema using select statement 

-- Select * from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='MyFirstTable';  -- note that . operator is the same as the one used for dereferencing similar named attributes in different tables, as used in JOINS on tables

-- using alternative statement of desc in MySQL to get table schema in SQL server

-- exec sp_columns MyFirstTable;