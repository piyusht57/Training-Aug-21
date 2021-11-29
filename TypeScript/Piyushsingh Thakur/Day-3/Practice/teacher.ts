namespace NTeacher{
    export interface ITeacher{
        fullName:string;
        subjects:string;
    }
    export class Teacher{
        constructor(public fullName:string,public subjects:string){
    
        }
    }
}