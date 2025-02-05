// //classes
// class Invoice{
//     client:string;
//     details:string;
//     amount:number;

//     constructor(c:string,d:string,a:number){
//         this.client=c;
//         this.details=d;
//         this.amount=a;
//     }
//     format(){
//         return`${this.client} owes rs${this.amount} for ${this.details}`;
//     }
// }

// const I1=new Invoice('piyush','laptop',2000);
// const I2=new Invoice('hit','pc',5000);


//--------------------------------------------------------------------------------------
class Trial{

 Fname : string;     
 Lname :string;      
 
    constructor(fname : string, lname : string) {
        // super();       #Can only be referenced in a derived class
        this.Fname = fname;
        this.Lname = lname;
    }

    getFullName() : string {
        return `${this.Fname} ${this.Lname}`;
    }

}
let trial : Trial = new Trial("Piyush", "Singh");
// let trial = new Trial("Piyush", "Singh");
console.log(trial.getFullName());
console.log("class done");


// Inheritance
class Testing extends Trial{

    // Also runs without ctor
    constructor(fname : string, lname : string) {
        super(fname, lname);
    }

    getFullName() : string{
        return super.getFullName();
        // return `Full Name : ${this.Fname} ${this.Lname}`;
    }

}

let test = new Testing("Poonam", "Singh");
console.log(test.getFullName());

console.log("inheritance finish");

// Tuple
let a : [string, number] = ["String", 2134];    // Cannot add another elements because only 2 variables are defined. Sequence should be proper
console.log(a[0].substring(3));     // Only applicable on string datatype

console.log("tuple finish");

//Union
let union : (string | number);
union = 2345;
union = "2155";
console.log(typeof union);


// Union in Function
let func = function (union : (string | number)) : string {
    if(typeof union === "string"){
        return "Union is String";
    }
    else{
        return "Union is not a String";
    }
}
console.log(func(union));
console.log("union finish");


// Enum
enum val {v1 = 1, v2, v3};
console.log(val.v1);
console.log(val.v2);    // v1 starts from 1 so v2 value is 2
enum shape { Circle = "Circle", Square = "Square" };

interface Circle{
    Circle : string;
    radius : number;
}

interface Square{
    Square : string;
    sides : number;
}

let circle : Circle = {Circle : shape.Circle, radius : 20};
console.log(circle);
console.log("enum finish");

// Reverse Mapping
enum e { A };
let z = e.A;
let nameOfA = e[z];
console.log(nameOfA);

console.log("------------------");

// Interface
interface IEmployee{
    Fname : string;
    Lname : string;
    getFullName : () => string;
}

class Employee implements IEmployee{
    Fname : string;
    Lname : string;

    constructor(fname : string, lname : string) {
        this.Fname = fname;
        this.Lname = lname;
    }

    getFullName() :string{
        return `${this.Fname} ${this.Lname}`;
    }
}

// Interface can also be extended
//let emp : Employee = {Fname : "Piyush", Lname : "Singh", getFullName()};
let emp = new Employee("Piyush", "Singh");
console.log(emp.getFullName());


// Interface as Type
interface interfaceAsType {
    key : number;
    value : string;
}

let type : interfaceAsType = {key : 345, value : "Implementation of Interface as Type"};
console.log(type);


// Interface as Function
interface interfaceAsFunction{
    (key : number, value : string) : string;
}

let funct = function (key : number, value : string) : string{     // Anonymous Function
    return `${key} ${value}`;
}

console.log(funct(3254, "Implementation of Inerface as Function"));


// Interface for Array Type
interface interfaceForArray{
    [index : number] : number;
}

let arr : interfaceForArray = [234, 3456, 2];
console.log(arr);


// Interface for creating Property
interface Student{
    studentID : number;
    name : string;
    gender : string;
    readonly bloodGroup : string;
    phoneNumber? : bigint;   // Optional Field
}

let st : Student = {
    studentID : 23,
    name : "Abc",
    gender : "Female",
    bloodGroup : "B+"
}
console.log(st);
