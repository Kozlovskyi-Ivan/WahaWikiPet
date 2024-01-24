import { TestBed } from '@angular/core/testing';

import { ListAbilityService } from './list-ability.service';

describe('ListAbilityService', () => {
  let service: ListAbilityService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ListAbilityService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
