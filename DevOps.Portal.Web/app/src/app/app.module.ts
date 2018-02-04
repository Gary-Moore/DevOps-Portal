import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app.module.routing';
import { SolutionCreationModule } from './solution-creation/solution-creation.module';
import { DashboardModule } from './dashboard/dashboard.module';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    DashboardModule,
    SolutionCreationModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
