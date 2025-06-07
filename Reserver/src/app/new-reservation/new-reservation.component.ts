import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms'
import { Router } from '@angular/router';
import { ReservationService } from '../reservation.service';
import { MyReservationsService } from '../my-reservations.service';

@Component({
  selector: 'app-new-reservation',
  imports: [FormsModule],
  templateUrl: './new-reservation.component.html',
  styleUrl: './new-reservation.component.css'
})
export class NewReservationComponent {
  seats: any[] = [];

  seat = {};

  constructor(private router: Router, private seatService: ReservationService, private reservationService: MyReservationsService) {}

  submit(value: any) {
    this.reservationService.makeNewReservation(value).subscribe((_: any) => {
      this.router.navigate(['/myreservations']); 
    })
  };

  ngOnInit() {
    this.seatService.getAvailableSeats().subscribe((response: any) => {
      this.seats = response;
    })
  }
}
