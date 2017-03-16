import { TakeFlightPage } from './app.po';

describe('take-flight App', function() {
  let page: TakeFlightPage;

  beforeEach(() => {
    page = new TakeFlightPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
