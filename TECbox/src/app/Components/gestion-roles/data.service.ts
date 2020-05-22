import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Roles } from './roles';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private httpClient: HttpClient) { }

  // Entrada: ninguna
  // Función: conecta con la direción del servidor roles
  // Salida: la informacion del servidor roles
  getRolesData() {
    return this.httpClient.get<Roles[]>('https://localhost:44395/api/Role');
  }

  // Entrada: información de roles
  // Función: guarda en el servidor la información de roles
  // Salida: la información de roles
  postRolData(name: string, description: string) {
    console.log('El valor de header es:');
    this.httpClient.post('https://localhost:44395/api/Role', {name, description});
  }

  
  putRolData(name: string, description: string) {
    this.httpClient.put('https://localhost:44395/api/Role', {name, description});
  }

  // Entrada: información del role
  // Función: elimina en el servidor la información del role
  // Salida: la información de roles
  deleteRolData(name: string) {
    const headers = new HttpHeaders({'Content-Type': 'application/json'});
    this.httpClient.delete<Roles[]>('https://localhost:44395/api/Role/' + name );
    return this.httpClient.get<Roles[]>('https://localhost:44395/api/Role');
  }
}
