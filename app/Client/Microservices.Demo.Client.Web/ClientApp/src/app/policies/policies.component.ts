import { Component, OnInit } from '@angular/core';
import { IPolicy } from '../models/ipolicy';
import { PoliciesService } from '../services/data/policies/policies.service';
@Component({
  selector: 'app-policies',
  templateUrl: './policies.component.html',
  styleUrls: ['./policies.component.scss']
})
export class PoliciesComponent implements OnInit {
  constructor(
    private policiesService: PoliciesService,
  ) { }

  ngOnInit(): void {
  }
}
