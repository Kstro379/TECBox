import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-my-car',
  templateUrl: './my-car.component.html',
  styleUrls: ['./my-car.component.css']
})
export class MyCarComponent implements OnInit {

  total = 0;
  products = [{"nombre": "hola", "precio" : 2300, "descripcion": "Todo bien Olman??"}];

  constructor() {
    for (let index = 0; index < this.products.length; index++) {
      this.total += this.products[index].precio;
    }
  }

  ngOnInit(): void {
  }

}
