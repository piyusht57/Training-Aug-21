// Store 5 Employee’ data in one array (ID,FirstName,LastName,Address,Salary). Do the operation searching by indexnumber, EmployeeD, Insert the Employee delete the employee from the Array. Create one more array emp and join the value with above array. When display list combine firstname and lastname as fullname, From the address field flatnumber,city,state and should be splited.PF should be computed and total salary should be display.
var Employee = [
    { "ID": 1, "FirstName": "Piyush", "LastName": "Singh", "Address": "12,Nikol,Ahmedabad", "Salary": 34000 },
    { "ID": 2, "FirstName": "Hit", "LastName": "Shah", "Address": "34,Ranip,Ahmedabad", "Salary": 37000 },
    { "ID": 3, "FirstName": "Nisarg", "LastName": "Modi", "Address": "98,Maninagar,Ahmedabad", "Salary": 40000 },
    { "ID": 4, "FirstName": "Harsh", "LastName": "Bhatt", "Address": "19,Gota,Ahmedabad", "Salary": 32000 },
    { "ID": 5, "FirstName": "Hardip", "LastName": "Sisodiya", "Address": "110,Vapi,Ahmedabad", "Salary": 30000 }
];
//Find By Index
console.log(Employee[4]);
//Find By Id
for (var x in Employee) {
    console.log(Employee[x]);
}
//Insert Employye
Employee.push({ "ID": 6, "FirstName": "ashu", "LastName": "patel", "Address": "110/11,Wadaj,Ahmedabad", "Salary": 25000 });
console.log(Employee[5]);
//deleteing employee
Employee.pop();
console.log(Employee);
//Create array and join with first one
var Employee1 = [{ "ID": 7, "FirstName": "Nikung", "LastName": "Parth", "Address": "109,Shubhas Bridge,Ahmedabad", "Salary": 25000 }];
var result = Employee1.concat(Employee);
console.log(result);
//Display in different format with computed PF.
var e1 = Employee;
var a1 = [];
for (var _i = 0, e1_1 = e1; _i < e1_1.length; _i++) {
    var values = e1_1[_i];
    var ID = values.ID;
    var FullName = values.FirstName + " " + values.LastName;
    var Address = values.Address.split(",");
    var Salary = values.Salary;
    var PF = values.Salary * 0.12;
    a1.push({ "ID": ID, "FullName": FullName, "Address": Address, "Salary": Salary, "PF": PF });
}
console.log(a1);
