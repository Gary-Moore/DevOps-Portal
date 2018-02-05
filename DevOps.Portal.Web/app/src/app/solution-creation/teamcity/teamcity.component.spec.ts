import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TeamcityComponent } from './teamcity.component';

describe('TeamcityComponent', () => {
  let component: TeamcityComponent;
  let fixture: ComponentFixture<TeamcityComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TeamcityComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TeamcityComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
