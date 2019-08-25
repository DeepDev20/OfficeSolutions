import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductAndserviceComponent } from './product-andservice.component';

describe('ProductAndserviceComponent', () => {
  let component: ProductAndserviceComponent;
  let fixture: ComponentFixture<ProductAndserviceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProductAndserviceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductAndserviceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
