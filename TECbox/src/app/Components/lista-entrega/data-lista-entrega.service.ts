import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Employe } from './employee';
import { Roles } from './Role';
import { Package } from './packege';

@Injectable({
  providedIn: 'root'
})
export class DataListaEntregaService {

  // Constructor
  constructor(private httpClient: HttpClient) { }

  getGastos(){

  }

  // Entrada: niguna
  // Función: Obtiene los roles.
  // Salida: Lista de Roles.
  getRolesData() {
    return this.httpClient.get<Roles[]>('https://localhost:44395/api/Role');

  }

  // Entrada: DNI del Empleado
  // Función: Obtiene la informacion de un empleado.
  // Salida: Datos del Empleado
  getEmployeeData(dni: number) {
    return this.httpClient.get<[Employe]>('https://localhost:44395/api/Employee/' + dni);
  }

  // Entrada: niguna
  // Función: Obtiene los paquetes
  // Salida: Lista de Paquetes.
  getPaquetesData() {
    return this.httpClient.get<Package[]>('https://localhost:44395/api/Package');
  }



}
