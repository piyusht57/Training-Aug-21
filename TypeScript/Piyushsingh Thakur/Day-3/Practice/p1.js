var NStudent;
(function (NStudent) {
    var Student = /** @class */ (function () {
        function Student(fullName, rollNumber) {
            this.fullName = fullName;
            this.rollNumber = rollNumber;
        }
        return Student;
    }());
    NStudent.Student = Student;
})(NStudent || (NStudent = {}));
var NTeacher;
(function (NTeacher) {
    var Teacher = /** @class */ (function () {
        function Teacher(fullName, subjects) {
            this.fullName = fullName;
            this.subjects = subjects;
        }
        return Teacher;
    }());
    NTeacher.Teacher = Teacher;
})(NTeacher || (NTeacher = {}));
///<reference path="student.ts"/>
///<reference path="teacher.ts"/>
var t2 = new NTeacher.Teacher("Harsh Bhatt ", "Maths");
console.log(t2.fullName + " is teaching us " + t2.subjects);
var S1 = new NStudent.Student("hit shah", 1);
console.log((S1.fullName + "'s roll number is " + S1.rollNumber));
