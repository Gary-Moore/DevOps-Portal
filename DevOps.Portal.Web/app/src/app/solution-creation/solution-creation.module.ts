import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SolutionCreationRoutingModule } from './solution-creation-routing.module';
import { SolutionCreationComponent } from './solution-creation.component';
import { TeamcityComponent } from './teamcity/teamcity.component';
import { OctopusComponent } from './octopus/octopus.component';
import { VisualStudioComponent } from './visual-studio/visual-studio.component';
import { AzureComponent } from './azure/azure.component';
import { MatStepperModule } from '@angular/material/stepper';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { GitlabComponent } from './gitlab/gitlab.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  imports: [
    CommonModule,
    SolutionCreationRoutingModule,
    MatStepperModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule
  ],
  declarations: [SolutionCreationComponent, TeamcityComponent, OctopusComponent, VisualStudioComponent, AzureComponent, GitlabComponent]
})
export class SolutionCreationModule { }
