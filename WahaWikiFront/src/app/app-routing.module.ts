import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { DatasheetViewComponent } from "./components/datasheet/datasheet-view/datasheet-view.component";
import { AbilityFormCreateComponent} from "./components/forms/ability-form-create/ability-form-create.component"
import { AbilityformComponent } from './components/forms/abilityform/abilityform.component';
import { AbilityListComponent } from './components/lists/ability-list/ability-list.component';
import { WeaponAbilityListComponent } from './components/lists/weapon-ability-list/weapon-ability-list.component';

const routes: Routes = [
  { path: 'Datasheet', component: DatasheetViewComponent },
  { path: 'CreateAbility', component:  AbilityFormCreateComponent},
  { path: 'CreateAbility2', component:  AbilityformComponent},
  { path: 'AbilityList', component:  AbilityListComponent},
  { path: 'WeaponAbilityList', component:  WeaponAbilityListComponent},
  { path: '', redirectTo: '/Datasheet', pathMatch: 'full' },
  { path: '**', redirectTo: '/Datasheet', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
