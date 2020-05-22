import { Component, OnInit } from '@angular/core';

import { DataService } from '../data.service';
import { AppComponent } from '../app.component';

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.css']
})
export class ClientComponent implements OnInit{

  // Lista de todos los productos.
  products;

  /**
   * Constructor
   * @param http: Api 
   */
  constructor(private http:DataService) {
   }

   /**
    * Trae la data.
    */
  ngOnInit(): void {
    this.http.productos().subscribe(data => this.products = data);
  }

  /**
   * Agrega el producto a la lista de productos a comprar.
   * @param num: ID del producto.
   */
  agregar(num){
    AppComponent.setID(num);
  }
  
}
