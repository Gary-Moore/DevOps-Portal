import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { HttpModule } from "@angular/http";

import { MatToolbarModule } from '@angular/material/toolbar';
import { MaterialModule } from '../shared/material.module';

import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { SideMenuComponent } from './side-menu/side-menu.component';

@NgModule({
  imports: [
    CommonModule,
    MaterialModule,
    RouterModule,
    HttpModule
  ],
  declarations: [HeaderComponent, FooterComponent, SideMenuComponent],
  exports:[HeaderComponent, FooterComponent, SideMenuComponent]
})
export class CoreModule { }
