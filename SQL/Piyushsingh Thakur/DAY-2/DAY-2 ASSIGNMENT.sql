
USE day6


----------UPDATE QUERIES


----------TASK1
ALTER TABLE Employees DROP CONSTRAINT ukemail

UPDATE Employees SET Email='not available'

ALTER TABLE Employees ADD CONSTRAINT ukemail UNIQUE (Email)
----------TASK2
UPDATE Employees SET Email='not available', CommissionPct=0.10

----------TASK3
UPDATE Employees SET Email='not available', CommissionPct=0.10 WHERE DepartmentID=110;

----------TASK4
UPDATE Employees SET Email='not available' WHERE DepartmentID=80 AND CommissionPct<0.20

----------TASK5
UPDATE Employees SET Email='not available' FROM Employees E join Departments D ON D.DepartmentID=E.DepartmentID WHERE D.DepartmentName='Accounting'

----------TASK6
UPDATE Employees SET Salary = CASE WHEN salary<5000 THEN 8000 ELSE Salary END WHERE EmployeeID=105

----------TASK7
UPDATE Employees SET JobId='SH_CLERK' WHERE EmployeeID=118 AND DepartmentID=30 AND JobId!='SH%'

----------TASK8
UPDATE Employees 
	SET Salary = 
		CASE 
		WHEN DepartmentID=40 
			THEN Salary+((0.25*Salary))
		WHEN DepartmentID=90
			THEN (Salary+(0.15*Salary))
		WHEN DepartmentID=110
			THEN (Salary+(0.10*Salary))
		ELSE +
			Salary+
		END
----------TASK9


----------TASKc SELECT queries
----------TASK1
SELECT * FROM Employees

----------TASK2
SELECT FirstName,LastName FROM Employees

----------TASK3
SELECT FirstName = 'Employee Name' FROM Employees

----------TASK4
SELECT * FROM Employees WHERE FirstName='Steven'

----------TASK5
SELECT * FROM Employees WHERE FirstName='Neena' OR FirstName='Lex'

----------TASK6
SELECT * FROM Employees WHERE FirstName!='Neena' OR FirstName!='Nina'

----------TASK7
SELECT * FROM Employees WHERE Salary BETWEEN 5000 AND 8000

----------TASK8
SELECT CONCAT(FirstName,' ', LastName) AS names,Salary,(Salary*0.12) AS 'PF' FROM Employees

----------TASK9
SELECT * FROM Employees WHERE FirstName LIKE 'N%'

----------TASK10
SELECT DISTINCT DepartmentID FROM employees;

----------TASK11
SELECT * FROM Employees ORDER BY -++++++++FirstName DESC

----------TASK12
SELECT EmployeeID,  CONCAT(FirstName,' ', LastName) AS names, Salary FROM Employees ORDER BY Salary ASC

----------TASK13
SELECT TOP 2 Salary FROM Employees 
