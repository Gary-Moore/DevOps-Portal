import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SolutionCreationComponent } from './solution-creation.component';
import { VisualStudioComponent } from './visual-studio/visual-studio.component';

const routes: Routes = [
  {
    path: 'solution-creation', 
    component: SolutionCreationComponent,
    children: [
      {path: '', component: VisualStudioComponent}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SolutionCreationRoutingModule { }
