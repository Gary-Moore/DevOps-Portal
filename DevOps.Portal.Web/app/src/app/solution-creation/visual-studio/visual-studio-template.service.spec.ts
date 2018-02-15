import { TestBed, inject } from '@angular/core/testing';
import { VisualStudioTemplateService } from './visual-studio-template.service';

describe('VisualStudioTemplateService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [VisualStudioTemplateService]
    });
  });

  it('should be created', inject([VisualStudioTemplateService], (service: VisualStudioTemplateService) => {
    expect(service).toBeTruthy();
  }));
});
