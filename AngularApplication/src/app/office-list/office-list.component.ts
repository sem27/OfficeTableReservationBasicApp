import { Component, OnInit } from '@angular/core';
import { OfficeService } from '../shared/office.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-office-list',
  templateUrl: './office-list.component.html',
  styles: []
})
export class OfficeListComponent implements OnInit {

  constructor(public service: OfficeService, private router: Router) { }

  ngOnInit() {
    this.service.getOffices();
  }

  onSelect(office){
    this.router.navigate(['/officetables', office.Id]);
  }

}
