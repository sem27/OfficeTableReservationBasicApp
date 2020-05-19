import { Injectable } from '@angular/core';
import { Office } from './office.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class OfficeService {
  readonly rootURL = 'http://localhost:62811/api';
  list: Office[];

  constructor(private http:HttpClient) { }

  getOffices(){
    this.http.get(this.rootURL + '/office/get')
    .toPromise()
    .then(result => this.list = result as Office[])
  }
}
