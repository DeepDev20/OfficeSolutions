import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SendEmailComponentComponent } from './send-email-component.component';

describe('SendEmailComponentComponent', () => {
  let component: SendEmailComponentComponent;
  let fixture: ComponentFixture<SendEmailComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SendEmailComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SendEmailComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
