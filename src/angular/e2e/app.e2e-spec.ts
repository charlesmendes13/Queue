import { QueueTemplatePage } from './app.po';

describe('Queue App', function() {
  let page: QueueTemplatePage;

  beforeEach(() => {
    page = new QueueTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
