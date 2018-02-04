import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SolutionCreationRoutingModule } from './solution-creation-routing.module';
import { SolutionCreationComponent } from './solution-creation.component';

@NgModule({
  imports: [
    CommonModule,
    SolutionCreationRoutingModule
  ],
  declarations: [SolutionCreationComponent]
})
export class SolutionCreationModule { }
