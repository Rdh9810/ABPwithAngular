import { WebWithAngularTemplatePage } from './app.po';

describe('WebWithAngular App', function() {
  let page: WebWithAngularTemplatePage;

  beforeEach(() => {
    page = new WebWithAngularTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
