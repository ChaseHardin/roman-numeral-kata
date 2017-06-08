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
      fixture.componentInstance.number = 0;
      var actual = fixture.componentInstance.convert();
      expect(actual).toEqual('');
    });

    it('should return blank string when less than zero', () => {
      fixture.componentInstance.number = -10;
      var actual = fixture.componentInstance.convert();
      expect(actual).toEqual('');
    });

    it('should convert one', () => {
      fixture.componentInstance.number = 1;
      var actual = fixture.componentInstance.convert();
      expect(actual).toEqual('I');
    });

    it('should convert four', () => {
      fixture.componentInstance.number = 4;
      var actual = fixture.componentInstance.convert();
      expect(actual).toEqual('IV');
    });

    it('should convert five', () => {
      fixture.componentInstance.number = 5;
      var actual = fixture.componentInstance.convert();
      expect(actual).toEqual('V');
    });

    it('should convert nine', () => {
      fixture.componentInstance.number = 9;
      var actual = fixture.componentInstance.convert();
      expect(actual).toEqual('IX');
    });

    it('should convert ten', () => {
      fixture.componentInstance.number = 10;
      var actual = fixture.componentInstance.convert();
      expect(actual).toEqual('X');
    });
  });
});
