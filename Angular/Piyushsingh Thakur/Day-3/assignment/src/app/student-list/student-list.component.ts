import { Component, OnInit } from '@angular/core';
import{student} from './Student'
@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {


  slist: student[]=[
    {
      'Id':1,
      'Name':'Piyush',
      'Age':21,
      'Grade':'A',
      'Avarage':90,
      'Active':true
    },
    {
     'Id':2,
     'Name':'Hit',
     'Age':21,
     'Grade':'E',
     'Avarage':23,
     'Active':true
   },
   {
     'Id':3,
     'Name':'Harsh',
     'Age':21,
     'Grade':'B',
     'Avarage':80,
     'Active':true
   },
   {
     'Id':4,
     'Name':'YAsh',
     'Age':22,
     'Grade':'C',
     'Avarage':70,
     'Active':true
   },
   {
     'Id':5,
     'Name':'Mihir',
     'Age':21,
     'Grade':'D',
     'Avarage':50,
     'Active':false
   }
   ];
  constructor() { }

  ngOnInit(): void {
  }

}
