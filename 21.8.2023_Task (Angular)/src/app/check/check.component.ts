import { Component } from '@angular/core';
import { NgModel } from '@angular/forms';

@Component({
  selector: 'app-check',
  templateUrl: './check.component.html',
  styleUrls: ['./check.component.css']
})
export class CheckComponent {

  temperature!: number;
  selectedUnit: string = 'celsius';
  convertedTemperature!: number;

  convert() {
    if (this.selectedUnit === 'celsius') {
      this.convertedTemperature = (this.temperature * 9/5) + 32;
    } else {
      this.convertedTemperature = (this.temperature - 32) * 5/9;
    }
  }

}
