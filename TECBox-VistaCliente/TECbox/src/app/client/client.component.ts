import { Component, OnInit } from '@angular/core';

import { DataService } from '../data.service';
import { AppComponent } from '../app.component';

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.css']
})
export class ClientComponent implements OnInit{
  products;

  constructor(private http:DataService) {
   }

  ngOnInit(): void {
    this.http.productos().subscribe(data => this.products = data);
  }

  agregar(num){
    AppComponent.setID(num);
  }
  
}
