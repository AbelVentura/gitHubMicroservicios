import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PoliciesRoutingModule } from './policies-routing.module';
import { SharedModule } from '../shared/shared.module';
import { PolicytListComponent } from './policy-list/policy-list.component';

@NgModule({
  declarations: [PoliciesRoutingModule.components, PolicytListComponent],
  imports: [
    CommonModule,
    SharedModule,
    PoliciesRoutingModule
  ]
})
export class PoliciesModule { }
