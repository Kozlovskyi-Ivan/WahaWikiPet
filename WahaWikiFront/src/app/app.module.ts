import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DatasheetViewComponent } from './components/datasheet/datasheet-view/datasheet-view.component';
import { StatlineComponent } from './components/datasheet/statline/statline.component';
import { WeaponListComponent } from './components/datasheet/weapon-list/weapon-list.component';
import { AbilitiesComponent } from './components/datasheet/abilities/abilities.component';

@NgModule({
  declarations: [
    AppComponent,
    DatasheetViewComponent,
    StatlineComponent,
    WeaponListComponent,
    AbilitiesComponent
    ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
