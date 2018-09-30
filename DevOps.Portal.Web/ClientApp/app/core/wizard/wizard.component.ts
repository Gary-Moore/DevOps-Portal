import {
  Component,
  OnInit,
  ContentChildren,
  QueryList,
  AfterContentInit,
  Output,
  EventEmitter
} from '@angular/core';
import { WizardStepComponent } from './wizard-step/wizard-step.component';

@Component({
  selector: 'app-wizard',
  templateUrl: './wizard.component.html',
  styleUrls: ['./wizard.component.scss']
})
export class WizardComponent implements OnInit, AfterContentInit {
  @ContentChildren(WizardStepComponent)
  wizardSteps: QueryList<WizardStepComponent>;
  private _steps: Array<WizardStepComponent>;

  @Output() completed: EventEmitter<any> = new EventEmitter<any>();
  constructor() {}

  ngOnInit() {}

  ngAfterContentInit(): void {
    this._steps = this.wizardSteps.toArray();
    this.activeStep = this._steps[0];
  }

  get activeStep(): WizardStepComponent {
    return this.steps.find(step => step.isActive);
  }

  set activeStep(step: WizardStepComponent) {
    if (this.activeStep != null) {
      this.activeStep.isActive = false;
    }
    step.isActive = true;
  }

  get steps(): Array<WizardStepComponent> {
    return this._steps;
  }

  get hasNextStep(): boolean {
    return this.activeStepIndex < this.steps.length - 1;
  }

  get hasPrevStep(): boolean {
    return this.activeStepIndex > 0;
  }

  public next(): void {
    this.activeStep = this.steps[this.activeStepIndex + 1];
    this.activeStep.next.emit();
  }

  public prev(): void {
    this.activeStep = this.steps[this.activeStepIndex - 1];
    this.activeStep.prev.emit();
  }

  public complete(): void {
    this.completed.emit();
  }

  get activeStepIndex(): number {
    return this.steps.indexOf(this.activeStep);
  }

  goToStep(step: WizardStepComponent): void {
    this.activeStep = step;
  }
}
