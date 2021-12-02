import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-hello-world',
  templateUrl: './hello-world.component.html',
  styleUrls: ['./hello-world.component.css']
})
export class HelloWorldComponent implements OnInit {
  name="Piyush";
  greet(){
    return "Greetings of the Day"
  }
  constructor() { }

  ngOnInit(): void {
  }

}
