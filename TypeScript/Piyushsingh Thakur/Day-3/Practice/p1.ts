///<reference path="student.ts"/>
///<reference path="teacher.ts"/>

let t2:NTeacher.ITeacher=new NTeacher.Teacher("Harsh Bhatt ","Maths")
console.log(t2.fullName+" is teaching us "+t2.subjects);


let S1:NStudent.IStudent=new NStudent.Student("hit shah",1);
console.log((S1.fullName+"'s roll number is "+S1.rollNumber));
