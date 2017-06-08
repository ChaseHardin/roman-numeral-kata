import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RomanNumeralConverterComponent } from './roman-numeral-converter.component';

fdescribe('RomanNumeralConverterComponent', () => {
  let component: RomanNumeralConverterComponent;
  let fixture: ComponentFixture<RomanNumeralConverterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RomanNumeralConverterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RomanNumeralConverterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });

  describe('convert tests', () => {
    it('should return blank string when zero', () => {
      fixture.componentInstance.decimalNumber = 0;
      var actual = fixture.componentInstance.convert();
      expect(actual).toEqual('');
    });

    it('should return blan string when less than zero', () => {
      fixture.componentInstance.decimalNumber = -10;
      var actual = fixture.componentInstance.convert();
      expect(actual).toEqual('');
    });
  });
});
