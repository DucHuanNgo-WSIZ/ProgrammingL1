import { Injectable } from '@angular/core';
import { of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ReservationService {

  getAvailableSeats() {
    return of([
      {id: 1, location: 'front', class: 'first', price: 10.0},
      {id: 2, location: 'front', class: 'first', price: 10.0},
      {id: 3, location: 'front', class: 'second', price: 8.0},
      {id: 4, location: 'front', class: 'second', price: 8.0},
      {id: 5, location: 'front', class: 'second', price: 8.0},
      {id: 6, location: 'back', class: 'first', price: 6.0},
      {id: 7, location: 'back', class: 'first', price: 6.0},
      {id: 8, location: 'back', class: 'second', price: 5.0},
      {id: 9, location: 'back', class: 'second', price: 5.0},
      {id: 10, location: 'back', class: 'second', price: 5.0}
    ])
  }

  constructor() { }
}
