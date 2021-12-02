import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor() { }
  uid:any;
  password:any;
  ngOnInit(): void {
  }
  validate(){
    if(this.uid == null || this.password == null){
      alert("Please do not leave any field blank");
    }
    else if(this.uid != "admin"){
      alert("Please enter valid username")
    }
    else if(this.password != "admin"){
      alert("Please enter valid password")
    }
    else if(this.uid == "admin" && this.password == "admin"){
      alert("Logged In Successfully");
    }
  }
}
