import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WeaponAbilityFormEditComponent } from './weapon-ability-form-edit.component';

describe('WeaponAbilityFormEditComponent', () => {
  let component: WeaponAbilityFormEditComponent;
  let fixture: ComponentFixture<WeaponAbilityFormEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WeaponAbilityFormEditComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WeaponAbilityFormEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
