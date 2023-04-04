import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { DatasheetViewComponent } from "./components/datasheet/datasheet-view/datasheet-view.component";

const routes: Routes = [
  { path: 'Datasheet', component: DatasheetViewComponent },
  { path: '', redirectTo: '/Datasheet', pathMatch: 'full' },
  { path: '**', redirectTo: '/Datasheet', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
