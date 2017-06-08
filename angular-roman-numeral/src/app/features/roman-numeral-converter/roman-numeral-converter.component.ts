import { Component } from '@angular/core';

@Component({
  selector: 'app-roman-numeral-converter',
  templateUrl: './roman-numeral-converter.component.html',
  styleUrls: ['./roman-numeral-converter.component.css']
})

export class RomanNumeralConverterComponent {
  private number: number;
  romanNumeral: string = '';

  public convert(){
    if(this.number <= 0) return '';

    this.updateRomanNumeral();
    this.updateNumber();
    this.convert();

    return this.romanNumeral;
  }

  private updateRomanNumeral() {
    this.romanNumeral += this.findMaxValueFromMapper();
  }

  private updateNumber() {
    this.number -= this.findMaxKeyFromMapper();
  }

  private findMaxKeyFromMapper(): number {
    return Math.max(...this.filterMappings().map(mapper => mapper.key));
  }

  private findMaxValueFromMapper(): string {
    return this.filterMappings().map(mapper => mapper.value).slice(-1).pop();
  }

  private filterMappings() {
    return decimalToRomanNumeralMapper.filter(x => x.key <= this.number);
  }
}

var decimalToRomanNumeralMapper = [
  { key: 1, value: 'I'},
  { key: 4, value: 'IV'},
  { key: 5, value: 'V'},
  { key: 9, value: 'IX'},
  { key: 10, value: 'X'},
  { key: 40, value: 'XL'},
  { key: 50, value: 'L'},
  { key: 90, value: 'XC'},
  { key: 100, value: 'C'},
  { key: 400, value: 'LD'},
  { key: 500, value: 'D'},
  { key: 900, value: 'CM'},
  { key: 1000, value: 'M'},
];
