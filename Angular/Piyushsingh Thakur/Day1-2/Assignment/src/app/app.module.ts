import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms'
import { AppComponent } from './app.component';
import { CalcComponent } from './calc/calc.component';
import { HelloWorldComponent } from './hello-world/hello-world.component';
import { LeftBarComponent } from './left-bar/left-bar.component';
import { LoginComponent } from './login/login.component';
import { SignupComponent } from './signup/signup.component';
import { CircleComponent } from './circle/circle.component';
import { RectangleComponent } from './rectangle/rectangle.component';

@NgModule({
  declarations: [
    AppComponent,
    CalcComponent,
    HelloWorldComponent,
    LeftBarComponent,
    LoginComponent,
    SignupComponent,
    CircleComponent,
    RectangleComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
