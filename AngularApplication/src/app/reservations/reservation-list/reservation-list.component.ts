import { Component, OnInit } from '@angular/core';
import { FullreservationService } from 'src/app/shared/fullreservation.service';

@Component({
  selector: 'app-reservation-list',
  templateUrl: './reservation-list.component.html',
  styles: []
})
export class ReservationListComponent implements OnInit {

  constructor(public service: FullreservationService) { }

  ngOnInit() {
    this.service.getReservations();
  }

}
