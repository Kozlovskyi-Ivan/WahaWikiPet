import { TestBed } from '@angular/core/testing';

import { FormWeaponAbilityService } from './form-weapon-ability.service';

describe('FormWeaponAbilityService', () => {
  let service: FormWeaponAbilityService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FormWeaponAbilityService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
