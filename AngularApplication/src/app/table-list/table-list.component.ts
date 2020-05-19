import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import { TableService } from '../shared/table.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-table-list',
  templateUrl: './table-list.component.html',
  styles: []
})
export class TableListComponent implements OnInit {

  public officeId;
  constructor(public service: TableService, private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit() {
    let id = parseInt(this.route.snapshot.paramMap.get('id'));
    this.officeId = id;
    
    this.service.getTables(this.officeId);
  }

  onSelect(tableId){
    this.router.navigate(['/booktable', tableId]);
  }
}
