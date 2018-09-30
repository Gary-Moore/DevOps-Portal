import { TestBed } from '@angular/core/testing';

import { UltraBuildService } from './ultrabuild.service';

describe('UltrabuildService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: UltraBuildService = TestBed.get(UltraBuildService);
    expect(service).toBeTruthy();
  });
});
