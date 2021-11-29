// Store 5 Employee Data(ID,Name,City,DOJ) in one Array. Search the employee with ID. Search the employees who has joined after year 2020. Search the employee who has joined after year 2020 and stays in Mumbai city.
let Employee = new Map();
Employee.set(1, { ID: 1, Name: "Piyush", City: "Mumbai", DOJ: new Date(2021, 1, 24) });
Employee.set(2, { ID: 2, Name: "Hit", City: "Ahmedabad", DOJ: new Date(2021, 1, 21) });
Employee.set(3, { ID: 3, Name: "Shubh", City: "Mumbai", DOJ: new Date(2021, 2, 1) });
Employee.set(4, { ID: 4, Name: "Dhruvit", City: "Ahmedabad", DOJ: new Date(2019, 1, 16) });
Employee.set(5, { ID: 5, Name: "Harsh", City: "Ahmedabad", DOJ: new Date(2020, 1, 3) });
// Display Employee Details
console.log("Employee Details : ");
for (var entry of Employee.entries()) {
    console.log(Employee.get(entry[0]));
}
console.log("----------------------------------------------------");
console.log("searching by ID");
// Search By ID
console.log("Search by Id 2 : ");
var searchById = function () {
    let id = 2;
    if (Employee.has(id) == true) {
        console.log(Employee.get(id));
    }
    else {
        console.log("Data not found");
    }
};
searchById();
console.log("------------------------------------------------------");
console.log();
// Joined after year 2020
console.log("Joined after year 2020 : ");
for (var entry of Employee.entries()) {
    if (entry[1].DOJ.getYear() > 120) {
        console.log(Employee.get(entry[0]));
    }
}
console.log("------------------------------------------------------");
console.log();
// Joined after year 2020 and stays in Mumbai city.
console.log("Joined after year 2020 and stays in Mumbai city : ");
for (var entry of Employee.entries()) {
    if (entry[1].DOJ.getYear() > 120 && entry[1].City == "Mumbai") {
        console.log(Employee.get(entry[0]));
    }
}
