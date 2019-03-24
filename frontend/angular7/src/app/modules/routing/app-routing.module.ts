import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MainHostComponent } from 'src/app/components/hosts/main-host/main.host';

const routes: Routes = [
  { path: '', component: MainHostComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
