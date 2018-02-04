import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SolutionCreationComponent } from './solution-creation.component';

describe('SolutionCreationComponent', () => {
  let component: SolutionCreationComponent;
  let fixture: ComponentFixture<SolutionCreationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SolutionCreationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SolutionCreationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
