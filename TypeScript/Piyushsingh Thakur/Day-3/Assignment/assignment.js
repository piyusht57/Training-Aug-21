"use strict";
// This project is aimed at developing a web-based and central Recruitment Process System for the HR Group for a company. Some features of this system will be creating vacancies, storing Applicants data, Interview process initiation, Scheduling Interviews, Storing Interview results for the applicant and finally Hiring of the applicant. Reports may be required to be generated for the use of HR group.
exports.__esModule = true;
var StoreData_1 = require("./StoreData");
var ScheduleInterview_1 = require("./ScheduleInterview");
var StoreInterviewResult_1 = require("./StoreInterviewResult");
// Storing Applicants data
var data = [
    new StoreData_1.Applicant(1, "Piyush", "Singh", "piyush@gmail.com", 8989898989, "BE"),
    new StoreData_1.Applicant(2, "Hit", "Shah", "hit@gmail.com", 5656565655, "IT Engineer"),
    new StoreData_1.Applicant(3, "Harsh", "Bhatt", "harsh@gmail.com", 7772672627, "Designer")
];
//data[0].display(data);
// Scheduling Interview
var schedule = new ScheduleInterview_1.ScheduleInterview(new Date(2021, 1, 23).toDateString(), new Date().getHours(), "Ahmedabad");
schedule.display(schedule);
// Interview Result
var result = [
    new StoreInterviewResult_1.InterviewResult(1, 25, 24, 20, 29, 20),
    new StoreInterviewResult_1.InterviewResult(2, 21, 29, 25, 25, 20),
    new StoreInterviewResult_1.InterviewResult(3, 26, 14, 12, 17, 25)
];
result[0].display(result);
