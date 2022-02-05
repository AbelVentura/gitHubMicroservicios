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
  policies: IPolicy[] = [];

  constructor(
    private policyService: PoliciesService,
  ) { }

  ngOnInit(): void {
    this.getPolicies();
  }

  getPolicies() {
    this.policyService.getPoliciesReport()
      .subscribe((response: IPolicy[]) => {
        this.policies = response;
      });
  }
}
