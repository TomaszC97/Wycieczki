import { InfoComponent } from './info/info.component';
import { WyswietlComponent } from './wyswietl/wyswietl.component';
import { DodajComponent } from './dodaj/dodaj.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {path: '', redirectTo:'/info',pathMatch: 'full'},
  {path: 'info', component: InfoComponent},
  {path: 'wyswietl', component: WyswietlComponent},
  {path: 'dodaj', component: DodajComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
