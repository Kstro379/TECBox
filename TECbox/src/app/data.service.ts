import { Injectable } from '@angular/core';
import { HttpClient,HttpParams } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { 

  }

  package(){
    return this.http.get('https://localhost:44395/api/Package');
  }

  login(){
    return this.http.get('https://localhost:44395/api/Client');
  }

  getUser(dni:string){
    return this.http.get('https://localhost:44395/api/Client/'+dni);
  }

  loginRole(){
    return this.http.get('https://localhost:44395/api/Role');
  }

  loginEmployee(){
    return this.http.get('https://localhost:44395/api/Employee');
  }

  productos(){
    return this.http.get('https://localhost:44395/api/Product');
  }
}
