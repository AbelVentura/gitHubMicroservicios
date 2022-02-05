import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { PoliciesComponent } from './policies.component';
import { PolicyCreateComponent } from './policy-create/policy-create.component';
import { PolicytListComponent } from './policy-list/policy-list.component';

const routes: Routes = [
  {
    path: '', component: PoliciesComponent,
    children: [
      { path: 'list', component: PolicytListComponent },
      { path: 'fromOffer/:offerNumber', component: PolicyCreateComponent },
    ]
  }
];

@NgModule({
  declarations: [],
  exports: [RouterModule],
  imports: [
    RouterModule.forChild(routes),
    CommonModule
  ]
})
export class PoliciesRoutingModule {
  static components = [
    PoliciesComponent,
    PolicytListComponent,
    PolicyCreateComponent
  ];
}
