import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { AppComponent } from "../app/app.component";
import { TableListComponent } from "../app/table-list/table-list.component";
import { NewReservationComponent } from "../app/reservations/new-reservation/new-reservation.component";
import { OfficeListComponent } from "../app/office-list/office-list.component";
import { ReservationListComponent } from './reservations/reservation-list/reservation-list.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
    // { path: "", redirectTo: '', pathMatch: 'full'},
    { path: "", component: HomeComponent},
    { path: "offices", component: OfficeListComponent},
    { path: "officetables/:id", component: TableListComponent},
    { path: "booktable/:id", component: NewReservationComponent},
    { path: "reservations", component: ReservationListComponent},
    { path: "home", component: HomeComponent}

]; 

@NgModule({
    imports: [
    RouterModule,
    RouterModule.forRoot(routes)
   ],
   exports: [RouterModule]
})

export class AppRoutingModule {}
export const routingComponents = [ ReservationListComponent, TableListComponent, OfficeListComponent, NewReservationComponent ]