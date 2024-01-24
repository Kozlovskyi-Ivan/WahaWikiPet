import { TestBed } from '@angular/core/testing';

import { ListWeaponAbilityService } from './list-weapon-ability.service';

describe('ListWeaponAbilityService', () => {
  let service: ListWeaponAbilityService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ListWeaponAbilityService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
