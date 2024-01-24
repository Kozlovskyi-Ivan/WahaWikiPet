import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AbilityFormEditComponent } from './ability-form-edit.component';

describe('AbilityFormEditComponent', () => {
  let component: AbilityFormEditComponent;
  let fixture: ComponentFixture<AbilityFormEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AbilityFormEditComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AbilityFormEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
