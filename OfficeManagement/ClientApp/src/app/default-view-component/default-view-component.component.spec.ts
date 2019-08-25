import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DefaultViewComponentComponent } from './default-view-component.component';

describe('DefaultViewComponentComponent', () => {
  let component: DefaultViewComponentComponent;
  let fixture: ComponentFixture<DefaultViewComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DefaultViewComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DefaultViewComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
