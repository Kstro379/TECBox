import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Ventas } from './ventas';

@Injectable({
  providedIn: 'root'
})
export class DataListaProductosService {

  // Constructor
  constructor(private httpClient: HttpClient) { }

  // Entrada: nada
  // Función: Obtiene las ventas.
  // Salida: Lista de Ventas
  getVentasData() {
    return this.httpClient.get<Ventas[]>('https://localhost:44395/api/Sell');

  }
}
