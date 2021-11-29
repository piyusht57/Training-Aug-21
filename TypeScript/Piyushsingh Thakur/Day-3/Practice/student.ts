namespace NStudent{
    export interface IStudent{
           fullName:string;
           rollNumber:number;
       }
       export class Student{
           constructor(public fullName:string,public rollNumber:number){
       
           }
       }
   }