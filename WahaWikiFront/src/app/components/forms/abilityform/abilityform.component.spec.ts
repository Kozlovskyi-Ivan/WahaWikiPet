import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AbilityformComponent } from './abilityform.component';

describe('AbilityformComponent', () => {
  let component: AbilityformComponent;
  let fixture: ComponentFixture<AbilityformComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AbilityformComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AbilityformComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
