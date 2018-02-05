import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OctopusComponent } from './octopus.component';

describe('OctopusComponent', () => {
  let component: OctopusComponent;
  let fixture: ComponentFixture<OctopusComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OctopusComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OctopusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
