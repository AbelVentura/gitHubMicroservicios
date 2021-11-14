import { Component, OnInit } from '@angular/core';
import { IPolicy } from '../models/ipolicy';
import { PoliciesService } from '../services/data/policies/policies.service';
@Component({
  selector: 'app-policies',
  templateUrl: './policies.component.html',
  styleUrls: ['./policies.component.scss']
})
export class PoliciesComponent implements OnInit {
  policies: IPolicy[] = [];
  constructor(
    private policiesService: PoliciesService,
  ) { }

  ngOnInit(): void {
    this.getPoliciesReport();
  }

  getPoliciesReport() {
    this.policiesService.getPoliciesReport()
      .subscribe((response: IPolicy[]) => {
        this.policies = response;
      });
  }

}
