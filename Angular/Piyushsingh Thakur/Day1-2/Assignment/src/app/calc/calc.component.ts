import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calc',
  templateUrl: './calc.component.html',
  styleUrls: ['./calc.component.css']
})
export class CalcComponent implements OnInit {
  num1: number=0;
  num2 : number=0;
  result : number=0;
  constructor() { }

  ngOnInit(): void {
  }
  add(){
    this.result=this.num1+this.num2;
  }
  sub(){
    this.result=this.num1-this.num2;
  }
  mul(){
    this.result=this.num1*this.num2;
  }
  div(){
    this.result=this.num1/this.num2;
  }
}
