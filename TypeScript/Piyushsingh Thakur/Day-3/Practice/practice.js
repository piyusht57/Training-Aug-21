// Generic 
function Generic(args) {
    return args;
}
console.log(Generic(2363256));
console.log(Generic("This is a GENERIC demo"));
console.log("generic class finish");
function GenericFunc(args, val) {
    console.log("Id : ".concat(args, ", Value : ").concat(val));
}
var variable = GenericFunc;
variable(23456236, "This is a Generic Interface");
// Generic Class
var GenericClass = /** @class */ (function () {
    function GenericClass() {
    }
    return GenericClass;
}());
var a = new GenericClass();
a.add = function (x, y) {
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
