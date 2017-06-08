import { Component } from '@angular/core';

@Component({
  selector: 'app-roman-numeral-converter',
  templateUrl: './roman-numeral-converter.component.html',
  styleUrls: ['./roman-numeral-converter.component.css']
})
export class RomanNumeralConverterComponent {
  decimalNumber: number;

  constructor() { }

  public convert(){
    return '';
  }
}
