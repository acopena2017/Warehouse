import { WhseAppPage } from './app.po';

describe('whse-app App', () => {
  let page: WhseAppPage;

  beforeEach(() => {
    page = new WhseAppPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
