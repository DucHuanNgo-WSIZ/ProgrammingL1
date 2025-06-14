import { Routes } from '@angular/router';
import { ReservationComponent } from './reservation/reservation.component';
import { MyReservationsComponent } from './my-reservations/my-reservations.component';
import { NewReservationComponent } from './new-reservation/new-reservation.component';



export const routes: Routes = [
    { path: "reservation", component: ReservationComponent },
    { path: "myreservations", component: MyReservationsComponent },
    { path: "newreservation", component: NewReservationComponent }
];
