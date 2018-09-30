import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app.module.routing';

import { AppComponent } from './app.component';
import { NavComponent } from './core/nav/nav.component';
import { VirtualMachineListComponent } from './azure/virtual-machine-list/virtual-machine-list.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { SideNavComponent } from './core/side-nav/side-nav.component';
import { UltrabuildComponent } from './ultrabuild/ultrabuild.component';
import { WizardComponent } from './core/wizard/wizard.component';
import { WizardStepComponent } from './core/wizard/wizard-step/wizard-step.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    VirtualMachineListComponent,
    DashboardComponent,
    SideNavComponent,
    UltrabuildComponent,
    WizardComponent,
    WizardStepComponent
  ],
  imports: [
    BrowserModule,
    NgbModule,
    HttpClientModule,
    RouterModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
