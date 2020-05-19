import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Table } from './table.model';

@Injectable({
  providedIn: 'root'
})
export class TableService {
  readonly rootURL = 'http://localhost:62811/api';
  list: Table[];

  constructor(private http:HttpClient) { }

  getTables(officeId){
    this.http.get(this.rootURL + '/table/' + officeId)
    .toPromise()
    .then(result => this.list = result as Table[])
  }
}
