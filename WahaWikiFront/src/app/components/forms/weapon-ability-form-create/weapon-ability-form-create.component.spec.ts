import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WeaponAbilityFormCreateComponent } from './weapon-ability-form-create.component';

describe('WeaponAbilityFormCreateComponent', () => {
  let component: WeaponAbilityFormCreateComponent;
  let fixture: ComponentFixture<WeaponAbilityFormCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WeaponAbilityFormCreateComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WeaponAbilityFormCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
