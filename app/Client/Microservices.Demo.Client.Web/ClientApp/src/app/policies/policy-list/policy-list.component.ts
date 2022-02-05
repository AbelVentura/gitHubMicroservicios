import { Component, OnInit } from '@angular/core';
import { PoliciesService } from '../../services/data/policies/policies.service';
import { IPolicy } from '../../models/ipolicy';

@Component({
  selector: 'app-policy-list',
  templateUrl: './policy-list.component.html',
  styleUrls: ['./policy-list.component.scss']
})
export class PolicytListComponent implements OnInit {
  title: string;
  products: IPolicy[] = [];

  constructor(
    private policyService: PoliciesService,
  ) { }

  ngOnInit(): void {
    this.getProducts();
  }

  getProducts() {
    this.policyService.getPoliciesReport()
      .subscribe((response: IPolicy[]) => {
        this.products = response;
      });
  }
}
