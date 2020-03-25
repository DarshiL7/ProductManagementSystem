import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import{UserAddComponent} from './components/user/user-add'


import {CustomerAddComponent} from './components/customer/customer-add'


const routes: Routes = [


  {
    path: '',
    component : UserAddComponent
  },
  {
    path:'CustomerAdd',
    component:CustomerAddComponent,
  },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
