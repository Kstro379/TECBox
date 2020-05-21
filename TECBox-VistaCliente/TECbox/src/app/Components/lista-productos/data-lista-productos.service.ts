import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Ventas } from './ventas';

@Injectable({
  providedIn: 'root'
})
export class DataListaProductosService {

  constructor(private httpClient: HttpClient) { }

  getVentasData() {
    return this.httpClient.get<Ventas[]>('https://localhost:44395/api/Sell');

  }
}
