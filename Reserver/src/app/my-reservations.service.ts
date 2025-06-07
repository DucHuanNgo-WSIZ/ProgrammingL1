import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class MyReservationsService {
  makeNewReservation(value: any) {
    return this.httpClient.post(`${environment.apiUrl}/Reservation`, {
      seatId: value.seat.id
    });
  }

  getMyReservations() {
    return this.httpClient.get<Array<any>>(`${environment.apiUrl}/Reservation`);
  }

  cancelReservation(reservation: any) {
    return this.httpClient.delete(`${environment.apiUrl}/Reservation/${reservation.id}`);
  }

  constructor(private httpClient: HttpClient) { }
}