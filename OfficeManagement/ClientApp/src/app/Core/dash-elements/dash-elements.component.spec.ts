import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DashElementsComponent } from './dash-elements.component';

describe('DashElementsComponent', () => {
  let component: DashElementsComponent;
  let fixture: ComponentFixture<DashElementsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DashElementsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DashElementsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
