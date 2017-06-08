import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {RomanNumeralConverterComponent} from "./features/roman-numeral-converter/roman-numeral-converter.component";
import {AlertModule} from "ng2-bootstrap";

@NgModule({
  declarations: [
    AppComponent,
    RomanNumeralConverterComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    AppRoutingModule,
    AlertModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
