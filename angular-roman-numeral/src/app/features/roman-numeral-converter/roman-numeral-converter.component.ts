import { Component } from '@angular/core';

@Component({
  selector: 'app-roman-numeral-converter',
  templateUrl: './roman-numeral-converter.component.html',
  styleUrls: ['./roman-numeral-converter.component.css']
})
export class RomanNumeralConverterComponent {
  number: number;

  constructor() { }

  public convert(){
    return this.number <= 0 ? '' : this.findMaxValueFromMapper();
  }

  private findMaxValueFromMapper(): string {
    return decimalToRomanNumeralMapper.filter(x => x.key <= this.number).map(mapper => mapper.value).slice(-1).pop();
  }
}

var decimalToRomanNumeralMapper = [
  { key: 1, value: 'I'},
  { key: 4, value: 'IV'},
  { key: 5, value: 'V'},
  { key: 9, value: 'IX'},
];
