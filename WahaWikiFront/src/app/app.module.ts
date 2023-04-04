import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { RouterModule } from "@angular/router";
import { AppComponent } from './app.component';
import { DatasheetViewComponent } from './components/datasheet/datasheet-view/datasheet-view.component';
import { StatlineComponent } from './components/datasheet/statline/statline.component';
import { WeaponListComponent } from './components/datasheet/weapon-list/weapon-list.component';
import { AbilitiesComponent } from './components/datasheet/abilities/abilities.component';
import { StatPlusPipe } from './pipes/stat-plus.pipe'
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { NumOfModelsPipe } from './pipes/numberOfModels.pipe';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { AbilityformComponent } from './components/forms/abilityform/abilityform.component';
import { WeaponformComponent } from './components/forms/weaponform/weaponform.component';
import { UnitformComponent } from './components/forms/unitform/unitform.component';

@NgModule({
  declarations: [
    AppComponent,
    DatasheetViewComponent,
    StatlineComponent,
    WeaponListComponent,
    AbilitiesComponent,
    StatPlusPipe,
    NumOfModelsPipe,
    AbilityformComponent,
    WeaponformComponent,
    UnitformComponent
    ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    NoopAnimationsModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
