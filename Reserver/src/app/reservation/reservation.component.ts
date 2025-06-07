import { Component } from '@angular/core';
import { ReservationService } from '../reservation.service';
import { SeatInfoComponent } from '../seat-info/seat-info.component';

@Component({
  selector: 'app-reservation',
  imports: [SeatInfoComponent],
  templateUrl: './reservation.component.html',
  styleUrl: './reservation.component.css'
})
export class ReservationComponent {
  seats: any[] = []

  constructor(private reservationService: ReservationService) {  }

  ngOnInit() {
    this.reservationService
    .getAvailableSeats()
    .subscribe({
      next: seats => this.seats = seats
    })
  }
}
