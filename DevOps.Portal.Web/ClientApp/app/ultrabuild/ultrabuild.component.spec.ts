import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UltrabuildComponent } from './ultrabuild.component';

describe('UltrabuildComponent', () => {
  let component: UltrabuildComponent;
  let fixture: ComponentFixture<UltrabuildComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UltrabuildComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UltrabuildComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
