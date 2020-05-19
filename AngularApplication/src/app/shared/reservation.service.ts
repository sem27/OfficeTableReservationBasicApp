import { Injectable } from '@angular/core';
import { Reservation } from './reservation.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class ReservationService {
  formData:Reservation;
  readonly rootURL = 'http://localhost:62811/api';
  list: Reservation[];

  constructor(private http:HttpClient) { }

  postNewReservation(formData:Reservation){
    return this.http.post(this.rootURL + '/reservation/new', formData)
  }

}
