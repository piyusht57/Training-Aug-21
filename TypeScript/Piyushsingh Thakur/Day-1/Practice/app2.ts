/*
bulit in type data type
number
string
boolean
void
null
undefined
*/

// var a="Piyush";
// var b:number=20;
// var c:boolean=true;
// var d ;
// console.log(a);
// console.log(typeof(a));
// console.log(b);
// console.log(typeof(b));
// console.log(c);
// console.log(typeof(c));
// console.log(d);
// console.log(typeof(d));

//---------------------------------------------------------------
// String Declaration, Template String
// var color : string = 'black';
 var fname : string = 'Piyush';
// var sentence : string = `My name is ${fname} and my favourite color is ${color}`;    
// console.log(sentence);

// console.log(sentence.charAt(3));   // n
// console.log(sentence.concat(color));
// console.log(sentence.indexOf('name'));
// console.log(sentence.replace("favourite", "FAVOURITE" ));
// console.log(sentence.split(" ", 3));
// console.log(sentence.toUpperCase());
// console.log(sentence.toLowerCase());
// console.log(sentence.charCodeAt(10));


//---------------------------------------------------------------
// Array Declaration
// var list : number[] = []
var num: Array<number> = [12, 24, 36];
var list: Array<number> = [1, 2, 3];
var anotherList: Array<string | number> = ['String', 'Number', 23, 4, 'Number', 474];  // Can contain values of 2 datatypes, also known as Multi Type Array

num.pop();
num.push(34);
num.shift();
num.sort();
console.log(num);


//---------------------------------------
for (var x in list) {
    console.log(list[x]);
}
list.sort();

//------------------------------------------
for (var i = 0; i < anotherList.length; i++) {
    console.log(anotherList[i]);
}
//------------------------------------------

var data =['hit','piyush','nisarg']
//data.push(12);
data.push('hardip');
console.log(data);


//-------------------------------------------
