import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.css']
})
export class ClientComponent implements OnInit{
  products = [{"nombre": "hola", "precio" : 2300, "descripcion": "Todo bien Olman??"}];

  constructor() {
   }

  ngOnInit(): void {
  }
  
}
