import { Component } from '@angular/core';
import { MyReservationsService } from '../my-reservations.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-my-reservations',
  imports: [DatePipe],
  templateUrl: './my-reservations.component.html',
  styleUrls: ['./my-reservations.component.css']
})
export class MyReservationsComponent {
  myReservations: any[] = [];

  ngOnInit() {
    this.getReservations();
  }

  cancelReservation(reservation: any): any {
    this.myReservationsService
      .cancelReservation(reservation)
      .subscribe({
        next: () => this.getReservations()
      });
  }

  getReservations(): any {
    this.myReservationsService
      .getMyReservations()
      .subscribe({
        next: reservations => this.myReservations = reservations
      });
  }

  constructor(private myReservationsService: MyReservationsService) { }
}
