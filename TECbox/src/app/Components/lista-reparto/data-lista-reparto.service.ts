import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Rutas } from './rutas';
import { Package } from './paquetes';

@Injectable({
  providedIn: 'root'
})
export class DataListaRepartoService {

  constructor(private httpClient: HttpClient) { }

  // Entrada: ninguna
  // Función: conecta con la direción del servidor roles
  // Salida: la informacion del servidor roles
  getRutasData() {
    return this.httpClient.get<Rutas[]>('https://localhost:44395/api/Route');
  }

  getPaquetesData() {
    return this.httpClient.get<Package[]>('https://localhost:44395/api/Package');
  }
}
