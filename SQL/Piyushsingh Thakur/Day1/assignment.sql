create table inventory(
ProductId INT PRIMARY KEY Identity(1,1),
ProdName varchar(50),
ProdPrice decimal(8,2),
);
create table sales(
SalesId INT PRIMARY KEY Identity(1,1),
SalesPerson int,
ProductId int,
CONSTRAINT FK_SalesPerson FOREIGN KEY (SalesPerson) REFERENCES employee(EmployeeId),
CONSTRAINT FK_ItemId FOREIGN KEY (ProductId) REFERENCES inventory(ProductId),
);
create table employee(
EmployeeId INT PRIMARY KEY Identity(1,1), 
EmpName varchar(50),
EmpLastName varchar(50),
EmpType varchar(10),
CommisionPer decimal(4,2)
);