import { Injectable } from '@angular/core';
import { HttpClient,HttpParams } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class DataService {

  /**
   * Constructor
   * @param http: Api
   */
  constructor(private http: HttpClient) {

  }

  /**
   * Obtiene la lista de paquetes de la base de datos.
   * return: Lista de paquetes.
   */
  package() {
    return this.http.get('https://localhost:44395/api/Package');
  }

  /**
   * Obtiene los clientes de la base de datos.
   * return: Lista de clientes.
   */
  login() {
    return this.http.get('https://localhost:44395/api/Client');
  }

  /**
   * Obtiene toda la data de la base de datos.
   * @param dni: DNI del cliente.
   * return: Data del usuario
   */
  getUser(dni: string ) {
    return this.http.get('https://localhost:44395/api/Client/'+dni);
  }

  /**
   * Obtiene todos los roles de la base de datos.
   * return: Lista de Roles.
   */
  loginRole() {
    return this.http.get('https://localhost:44395/api/Role');
  }

  /**
   * Obtiene todos los empleados de la base de datos.
   * return: Lista de Empleados.
   */
  loginEmployee() {
    return this.http.get('https://localhost:44395/api/Employee');
  }

  /**
   * Obtiene todos los productos de la base de datos.
   * return: Lista de Productos.
   */
  productos() {
    return this.http.get('https://localhost:44395/api/Product');
  }

  /**
   * Obtiene las Provincias.
   * return: Lista de Provincias.
   */
  provincias() {
    return this.http.get('https://ubicaciones.paginasweb.cr/provincias.json');
  }

  /**
   * Obtiene los cantones segun la provincia elegida.
   * @param provincia: Numero de la provincia.
   * return: Lista de Cantones.
   */
  cantones(provincia: number) {
    return this.http.get('https://ubicaciones.paginasweb.cr/provincia/' + provincia + '/cantones.json');
  }

  /**
   * Obtiene los distritos segun la provincia elegida y el canton.
   * @param provincia: Numero de la Provincia.
   * @param distrito: Numero del distrito.
   * return: Lista de Distritos.
   */
  distritos(provincia: number, distrito: number) {
    return this.http.get('https://ubicaciones.paginasweb.cr/provincia/' + provincia + '/canton/' + distrito + '/distritos.json');
  }
}
