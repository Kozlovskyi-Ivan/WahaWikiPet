import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WeaponAbilityListComponent } from './weapon-ability-list.component';

describe('WeaponAbilityListComponent', () => {
  let component: WeaponAbilityListComponent;
  let fixture: ComponentFixture<WeaponAbilityListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WeaponAbilityListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WeaponAbilityListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
