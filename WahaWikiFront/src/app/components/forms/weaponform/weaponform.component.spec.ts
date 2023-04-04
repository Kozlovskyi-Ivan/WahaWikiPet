import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WeaponformComponent } from './weaponform.component';

describe('WeaponformComponent', () => {
  let component: WeaponformComponent;
  let fixture: ComponentFixture<WeaponformComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WeaponformComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WeaponformComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
