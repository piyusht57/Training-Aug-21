/*Online table reservation in the restaurant for specific date and time. This will
Provide the list of restaurants in the country so that the user can choose accordingly.
Provide the list of tables available for online reservation at different dining rooms in the restaurant.
Mention the number of guests that can be accommodated on the particular table.
Accept the booking for tables.
Online table reservations are done 6hrs in advance for the current date.
Table reservation can be done up to one month in advance.
Give a token number to the customer as an acknowledgement of booking. */

import {Restaurant} from "./list";
import {Table} from "./Table";
import {Booking} from "./info";


// Storing Restaurant data
let data : Restaurant[] = [
    new Restaurant(1, "Restaurant 1", "Ahmedabad",16),
    new Restaurant(2, "Restaurant 2", "Surat",8),
    new Restaurant(3, "Restaurant 3", "Vapi",10),
    new Restaurant(4, "Restaurant 4", "Rajkot",4),
    new Restaurant(5, "Restaurant 5", "Baroda",12)
];

//displaying the list of restaurant

for(var R of data){
    console.log(R);
}

console.log("");
console.log("Please Seleact the Restaurant you want to choose");   
console.log("");


// adding table data for restaurant1
let R1 : Table[] = [
    new Table(1,1, "Table 1","Restaurant 1", 16,6,5),
    new Table(2,1, "Table 2","Restaurant 1", 16,6,5),
    new Table(3,1, "Table 3","Restaurant 1", 16,6,6),
    new Table(4,1, "Table 4","Restaurant 1", 16,6,7),
    new Table(5,1, "Table 5","Restaurant 1",16,6,4)
];

// adding table data for restaurant2
let R2 : Table[] = [
    new Table(1,2, "Table 1","Restaurant 2", 8,6,5),
    new Table(2,2, "Table 2","Restaurant 2", 8,6,5),
    new Table(3,2, "Table 3","Restaurant 2", 8,6,6),
    new Table(4,2, "Table 4","Restaurant 2", 8,6,7),
    new Table(5,2, "Table 5","Restaurant 2", 8,6,4)
];

// adding table data for restaurant3
let R3 : Table[] = [
    new Table(1,3, "Table 1","Restaurant 3", 10,6,5),
    new Table(2,3, "Table 2","Restaurant 3", 10,6,2),
    new Table(3,3, "Table 3","Restaurant 3", 10,6,4),
    new Table(4,3, "Table 4","Restaurant 3", 10,6,7),
    new Table(5,3, "Table 5","Restaurant 3", 10,6,10)
];

// adding table data for restaurant4
let R4 : Table[] = [
    new Table(1,4, "Table 1","Restaurant 4", 12,6,3),
    new Table(2,4, "Table 2","Restaurant 4", 12,6,2),
    new Table(3,4, "Table 3","Restaurant 4", 12,6,4),
    new Table(4,4, "Table 4","Restaurant 4", 12,6,4),
    new Table(5,4, "Table 5","Restaurant 4", 12,6,10)
];

// adding table data for restaurant5
let R5 : Table[] = [
    new Table(1,5, "Table 1","Restaurant 5", 10,9,3),
    new Table(2,5, "Table 2","Restaurant 5", 10,9,2),
    new Table(3,5, "Table 3","Restaurant 5", 10,9,6),
    new Table(4,5, "Table 4","Restaurant 5", 10,9,4),
    new Table(5,5, "Table 5","Restaurant 5", 10,9,12)
];
//displaying table information after 
function selecting(id:number){
    if (id==1){
        for(var T of R1){
            console.log(T);
        }
    }
    if (id==2){
        for(var T of R2){
            console.log(T);
        }
    }
    if (id==3){
        for(var T of R3){
            console.log(T);
        }
    }
    if (id==4){
        for(var T of R5){
            console.log(T);
        }
    }
    if (id==5){
        for(var T of R5){
            console.log(T);
        }
    }
}
//selecting resturant
selecting(1);
// selecting(2);
// selecting(3);
// selecting(4);
// selecting(5);
console.log();
console.log();
console.log();



//selecting table;
let Book : Booking[] = [
    new Booking(1,1, "Table 1","Restaurant 5",5,new Date("11-12-2020")),
    new Booking(2,2, "Table 2","Restaurant 5",5,new Date("12-11-2020")),
    new Booking(3,3, "Table 3","Restaurant 5",3,new Date("3-06-2020")),
    new Booking(4,4, "Table 4","Restaurant 5",10,new Date("1-12-2020")),
    new Booking(5,5, "Table 5","Restaurant 5",4,new Date("05-10-2020"))
];

// for(var T of Book){
//     console.log(Book);
// }


function booking(id:number){
    if(id==1){
        console.log("yoo have selected table 1 here is the");
        Book[0].display(Book[0]);
    }
    if(id==2){
        console.log("yoo have selected table 2 here is the");
        Book[0].display(Book[1]);
    }
    if(id==3){
        console.log("yoo have selected table 3 here is the");
        Book[0].display(Book[2]);
    }
    if(id==4){
        console.log("yoo have selected table 4 here is the");
        Book[0].display(Book[3]);
    }
    if(id==4){
        console.log("yoo have selected table 5 here is the");
        Book[0].display(Book[4]);
    }
}

booking(1);
console.log("---------------------------");
