// Generic 
function Generic<T>(args : T) : T{
    return args;
}
console.log(Generic(2363256));
console.log(Generic("This is a GENERIC demo"));
console.log("generic class finish");
//generic interface


interface IGeneric<T, U>{
    (args : T, value : U) : void;
}

function GenericFunc(args : number, val : string) : void{
    console.log(`Id : ${args}, Value : ${val}`);
}
let variable : IGeneric<number, string> = GenericFunc;
variable(23456236, "This is a Generic Interface");

// Generic Class
class GenericClass<T>{
    temp : T;
    add : (x : T, y : T) => T;
}

var a = new GenericClass<number>();
a.add = function(x , y){
    return x + y;
};
console.log(a.add(23, 34));


// //Namespace
// ///<reference path="utils.ts"/>
// namespace UsersUtils{
//    export class Users extends parent{
//         getName(){
//             //return "piyush";
//             return this.name;
//         }
//     }
// }

// // let u1=new UsersUtils.Users();
// // console.log(u1.getName());
// let u2=new UsersUtils.Users();
// u2.setName("hit");
// console.log(u2.getName());

