import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UnitformComponent } from './unitform.component';

describe('UnitformComponent', () => {
  let component: UnitformComponent;
  let fixture: ComponentFixture<UnitformComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UnitformComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UnitformComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
