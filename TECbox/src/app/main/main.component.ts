import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { DataService } from '../data.service';
import { AppComponent } from '../app.component';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  constructor(private router: Router, private data: DataService) { }

  ngOnInit(): void {
    this.data.login().subscribe(data => this.clients=data);
    this.data.loginEmployee().subscribe(data => this.employees=data);
    this.data.loginRole().subscribe(data => this.roles=data);
  }
  clients;
  employees;
  roles;

  confirm(userName, userPass){
    for (let i = 0; i < this.clients.length; i++) {
      if (this.clients[i].user == userName.value && this.clients[i].password ==userPass.value) {
        AppComponent.set(this.clients[i].dni);
        this.router.navigate(['/client']);
        return false;
      }
      else if (this.employees[i].userName == userName.value && this.employees[i].password ==userPass.value) {
        for (let x = 0; x < this.roles.length; x++) {
          for (let index = 0; index < this.roles[x].dni_Employee.length; index++) {
            if(this.roles[x].dni_Employee[index]==this.employees[i].dni){
              alert(this.roles[x].name);
              return false;
            }
            
          }
          
        }
      }
    }
    alert('El nombre de usuario o contraseña es incorrecto');
    return false;
  }

}
