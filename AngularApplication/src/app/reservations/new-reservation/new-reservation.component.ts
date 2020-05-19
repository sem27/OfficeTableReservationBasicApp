import { Component, OnInit } from '@angular/core';
import { ReservationService } from 'src/app/shared/reservation.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { ActivatedRoute } from "@angular/router";

@Component({
  selector: 'app-new-reservation',
  templateUrl: './new-reservation.component.html',
  styles: []
})
export class NewReservationComponent implements OnInit {

  constructor(public service:ReservationService, private toastr: ToastrService,
    private router: Router, private route: ActivatedRoute) { }

  ngOnInit() {
    this.resetForm();
    let id = parseInt(this.route.snapshot.paramMap.get('id'));
    this.service.formData.TableId = id;
  }

  resetForm(form?:NgForm){
    if(form != null)
      form.resetForm();

    this.service.formData = {
      Id : 0,
      TableId: 0,
      Name: '',
      Datum_Reservierung: null
    }
  }

  onSubmit(form: NgForm){
    this.service.postNewReservation(form.value).subscribe(
      result => {
        this.resetForm(form);
        this.toastr.success('Tisch erfolgreich gebucht!');
        this.router.navigate(['/reservations']);
      },
      error => {
        this.toastr.error(error.error);
        console.log(error);
      }
    )
  }

}
