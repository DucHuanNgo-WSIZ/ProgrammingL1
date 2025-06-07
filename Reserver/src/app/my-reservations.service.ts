import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class MyReservationsService {
  makeNewReservation(value: any) {
    return this.httpClient.post(`${environment.apiUrl}Reservation`, {
      carId: value.car.id,
      from: new Date(Date.UTC(value.from.year, value.from.month - 1, value.from.day)),
      to: new Date(Date.UTC(value.to.year, value.to.month - 1, value.to.day))
    });
  }

  getMyReservations() {
    return this.httpClient.get<Array<any>>(`${environment.apiUrl}Reservation`);
  }

  cancelReservation(reservation: any) {
    return this.httpClient.delete(`${environment.apiUrl}Reservation/${reservation.id}`);
  }

  constructor(private httpClient: HttpClient) { }
}