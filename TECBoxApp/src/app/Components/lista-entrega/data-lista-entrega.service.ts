import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Employe } from './employee';
import { Roles } from './Role';
import { Package } from './packege';

@Injectable({
  providedIn: 'root'
})
export class DataListaEntregaService {

  constructor(private httpClient: HttpClient) { }

  getGastos(){

  }

  getRolesData() {
    return this.httpClient.get<Roles[]>('https://localhost:44395/api/Role');

  }

  getEmployeeData(dni: number) {
    return this.httpClient.get<[Employe]>('https://localhost:44395/api/Employee/' + dni);
  }

  getPaquetesData() {
    return this.httpClient.get<Package[]>('https://localhost:44395/api/Package');
  }



}
