import { Component, OnInit } from '@angular/core';

import { DataService } from '../data.service';
import { AppComponent } from '../app.component';

@Component({
  selector: 'app-my-car',
  templateUrl: './my-car.component.html',
  styleUrls: ['./my-car.component.css']
})
export class MyCarComponent implements OnInit {

  total = 0;
  products_total;
  id_products;
  
  products=[];

  constructor(private http:DataService) {
  }

  ngOnInit(): void {
    this.http.productos().subscribe(data => this.products_total=data);
    this.id_products = AppComponent.getId();
  }

  actualizar(){
    if(this.id_products.length != 0){
      for (let i = 0; i < this.id_products.length; i++) {
        for (let y = 0; y < this.products_total.length; y++) {
          if(this.products_total[y].code == this.id_products[i]){
            this.products.push(this.products_total[y]);
            break;
          }
        }
      }
      for (let index = 0; index < this.products.length; index++) {
        this.total += this.products[index].price;
      }
    }
    this.id_products=[];
  }

  del(num){
    for (let y = 0; y < this.products.length; y++) {
      if(this.products[y].code == num){
        this.total -= this.products[y].price;
        this.products.splice(y,1);
        break;
      }
    }
    AppComponent.delID(num);
  }

}
