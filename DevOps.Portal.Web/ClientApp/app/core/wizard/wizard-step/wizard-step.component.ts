import { Component, OnInit, EventEmitter, Output, Input } from '@angular/core';

@Component({
  selector: 'app-wizard-step',
  templateUrl: './wizard-step.component.html',
  styleUrls: ['./wizard-step.component.scss']
})
export class WizardStepComponent implements OnInit {
  @Input() title: string;
  @Input() showPrev: boolean;
  @Input() showNext: boolean;

  @Output() next: EventEmitter<any> = new EventEmitter<any>();
  @Output() prev: EventEmitter<any> = new EventEmitter<any>();
  @Output() active: EventEmitter<any> = new EventEmitter<any>();

  private _isActive = false;

  constructor() { }

  ngOnInit() {
  }

  set isActive(isActive: boolean) {
    this._isActive = isActive;
  }

  get isActive(): boolean {
    return this._isActive;
  }
}
