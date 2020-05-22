import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }

  loginRole() {
    return this.http.get('https://localhost:44395/api/Role');
  }

  loginEmployee() {
    return this.http.get('https://localhost:44395/api/Employee');
  }
}
