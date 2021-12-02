import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {
  name : any;
  phoneNumber : any;
  DOB : any;
  address : any;
  panNumber : any;
  detail: any;
  constructor() { }

  ngOnInit(): void {
  }
  display(){
    this.detail=`Hi your name is ${this.name} \n
     your phoneNumber is ${this.phoneNumber} \n
     your DOB is ${this.DOB} \n
     your address is ${this.address} \n
     your panNumber is ${this.panNumber};
    `
   
   }
}
