import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-practice',
  templateUrl: './practice.component.html',
  styleUrls: ['./practice.component.css']
})
export class PracticeComponent implements OnInit {
  name='Piyush';
  show=true;
  color='';
  title='Style Binding';
  bgColor='skyblue';
  c="red";
  cv="white"
  switch1="yellow"

  users=['Hit','Piyush','Harsh','Mihir','Yash'];
  employees=[
    {
      empId:1,
      name1:'Hit',
      number:898989,
    },

    {
      empId:2,
      name1:'Piyush',
      number:999989,

    },
    {
      empId:3,
      name1:'Yash',
      number:778978,

    },
    {
      empId:4,
      name1:'Mihir',
      number:666666,

    }
  ]

  students=[
      {
        stdId:1,
        name1:'Hit',
        number:898989,
        social:['Snapchat','Facebook']
      },
  
      {
        stdId:2,
        name1:'Piyush',
        number:999989,
        social:['Whatsapp','Facebook']
      },
      {
        stdId:3,
        name1:'Yash',
        number:778978,
        social:['Instagram','Twitter']
      },
      {
        stdId:4,
        name1:'Mihir',
        number:666666,
        social:['Youtube','LinkedIn']
      }
  ]
  constructor() { }

  ngOnInit(): void {
  }

  check(){
    this.show=false;
  }
  red(){
    this.color='red';
    this.switch1="red"
    this.cv="red"
  }
  green(){
    this.color='green';
  }
  blue(){
    this.color='blue';
  }
  yellow(){
    this.color='yellow';
    this.switch1="yellow"
    this.cv="yellow"
  }
  brown(){
    this.color='brown';
    this.switch1="brown"
    this.cv="brown"
  }
  orange(){
    this.color='orange';
    this.switch1="orange"
    this.switch1="orange"
  }

   uc(){
    this.c="blue"
    this.bgColor="yellow"
  }

  purple(){
    this.switch1="purple"
    this.cv="purple"
  }


}