import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VisualStudioComponent } from './visual-studio.component';

describe('VisualStudioComponent', () => {
  let component: VisualStudioComponent;
  let fixture: ComponentFixture<VisualStudioComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VisualStudioComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VisualStudioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
