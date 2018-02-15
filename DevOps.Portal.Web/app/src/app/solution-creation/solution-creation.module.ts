import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SolutionCreationRoutingModule } from './solution-creation-routing.module';
import { SolutionCreationComponent } from './solution-creation.component';
import { TeamcityComponent } from './teamcity/teamcity.component';
import { OctopusComponent } from './octopus/octopus.component';
import { VisualStudioComponent } from './visual-studio/visual-studio.component';
import { AzureComponent } from './azure/azure.component';
import { GitlabComponent } from './gitlab/gitlab.component';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { MaterialModule } from '../shared/material.module';

@NgModule({
  imports: [
    CommonModule,
    MaterialModule,
    SolutionCreationRoutingModule,
    ReactiveFormsModule    
  ],
  declarations: [SolutionCreationComponent, TeamcityComponent, 
    OctopusComponent, VisualStudioComponent, AzureComponent, GitlabComponent]
})
export class SolutionCreationModule { }
