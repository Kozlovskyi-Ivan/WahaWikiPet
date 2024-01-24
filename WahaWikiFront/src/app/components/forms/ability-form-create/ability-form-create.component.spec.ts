import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AbilityFormCreateComponent } from './ability-form-create.component';

describe('AbilityFormCreateComponent', () => {
  let component: AbilityFormCreateComponent;
  let fixture: ComponentFixture<AbilityFormCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AbilityFormCreateComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AbilityFormCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
