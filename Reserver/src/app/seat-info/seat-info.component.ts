import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-seat-info',
  imports: [],
  templateUrl: './seat-info.component.html',
  styleUrl: './seat-info.component.css'
})
export class SeatInfoComponent {
  @Input() seat: any;
}
