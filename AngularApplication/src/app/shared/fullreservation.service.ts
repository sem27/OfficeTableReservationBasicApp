import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Fullreservation } from './fullreservation.model';

@Injectable({
  providedIn: 'root'
})
export class FullreservationService {
  readonly rootURL = 'http://localhost:62811/api';
  list: Fullreservation[];

  constructor(private http:HttpClient) { }

  getReservations(){
    this.http.get(this.rootURL + '/reservation')
    .toPromise()
    .then(result => this.list = result as Fullreservation[])
  }
}
