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
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NumOfModelsPipe } from './pipes/numberOfModels.pipe';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { AbilityformComponent } from './components/forms/abilityform/abilityform.component';
import { WeaponformComponent } from './components/forms/weaponform/weaponform.component';
import { UnitformComponent } from './components/forms/unitform/unitform.component';
import { AbilityFormCreateComponent } from './components/forms/ability-form-create/ability-form-create.component';
import { AbilityListComponent } from './components/lists/ability-list/ability-list.component';
import { PostItemComponent } from './components/post-item/post-item.component';
import { MyModalComponent } from './components/UI/my-modal/my-modal.component';
import { AbilityFormEditComponent } from './components/forms/ability-form-edit/ability-form-edit.component';
import { WeaponAbilityListComponent } from './components/lists/weapon-ability-list/weapon-ability-list.component';
import { WeaponAbilityFormCreateComponent } from './components/forms/weapon-ability-form-create/weapon-ability-form-create.component';
import { WeaponAbilityFormEditComponent } from './components/forms/weapon-ability-form-edit/weapon-ability-form-edit.component';

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
    UnitformComponent,
    AbilityFormCreateComponent,
    AbilityListComponent,
    PostItemComponent,
    MyModalComponent,
    AbilityFormEditComponent,
    WeaponAbilityListComponent,
    WeaponAbilityFormCreateComponent,
    WeaponAbilityFormEditComponent
    ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    NoopAnimationsModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
