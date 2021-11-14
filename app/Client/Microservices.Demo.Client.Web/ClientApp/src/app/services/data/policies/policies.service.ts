import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { ICreatePolicyCommand } from './icreate-policy-command';
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { ICreatePolicyResult } from './icreate-policy-result';
import { IPolicy } from '../../../models/ipolicy';

@Injectable({
  providedIn: 'root'
})
export class PoliciesService {
  port = '44399';
  //baseUrl = `${this.window.location.protocol}//${this.window.location.hostname}:${this.port}`;
  baseUrl = `http://${this.window.location.hostname}:${this.port}`;
  policiesApiUrl = this.baseUrl + '/api/policies';
  reportsApiUrl = this.baseUrl + '/api/report';
  constructor(
    private http: HttpClient,
    @Inject('Window') private window: Window
  ) { }

  CreatePolicy(createPolicyCommand: ICreatePolicyCommand): Observable<ICreatePolicyResult> {
    return this.http.post<ICreatePolicyResult>(this.policiesApiUrl, createPolicyCommand)
      .pipe(catchError(this.handleError));
  }

  getPoliciesReport(): Observable<IPolicy[]> {
    return this.http.get<IPolicy[]>(this.reportsApiUrl)
      .pipe(catchError(this.handleError));
  }

  private handleError(error: HttpErrorResponse) {
    console.error('server error:', error);
    if (error.error instanceof Error) {
      const errMessage = error.error.message;
      return Observable.throw(errMessage);
    }
    return Observable.throw(error || 'server error');
  }
}
