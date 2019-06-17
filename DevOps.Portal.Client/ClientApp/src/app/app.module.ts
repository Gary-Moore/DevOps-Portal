import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './core/nav/nav.component';
import { SideNavComponent } from './core/side-nav/side-nav.component';

import { library } from '@fortawesome/fontawesome-svg-core';
import { faTachometerAlt, faHammer, faCogs,
  faCheck, faTimesCircle, faStickyNote, faExclamationCircle, faInfoCircle,
  faExclamationTriangle, faCalendarAlt } from '@fortawesome/free-solid-svg-icons';

library.add(faTachometerAlt, faHammer, faCogs, faCheck, faTimesCircle,
  faStickyNote, faExclamationCircle, faInfoCircle, faExclamationTriangle, faCalendarAlt);

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    SideNavComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FontAwesomeModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
