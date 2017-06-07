import { AngularRomanNumeralPage } from './app.po';

describe('angular-roman-numeral App', () => {
  let page: AngularRomanNumeralPage;

  beforeEach(() => {
    page = new AngularRomanNumeralPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
