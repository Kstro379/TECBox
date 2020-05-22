import { Component , OnInit  } from '@angular/core';
import { Router } from  "@angular/router";

import { DataService } from '../data.service';
import { from } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage implements OnInit{

  employees;
  roles;

  /**
   * Constructor
   * @param router: Paginas
   */
  constructor(private  router:  Router,private data: DataService) {}

  /**
   * Init
   */
  ngOnInit() {
    this.data.loginEmployee().subscribe(data => this.employees=data);
    this.data.loginRole().subscribe(data => this.roles=data);
  }

  /**
   * Realiza la verificacion del usuario. 
   * @param form: Username y password
   */
  login(form){
    for (let i = 0; i < this.employees.length; i++) {
    if (this.employees[i].userName == form.value.userName && this.employees[i].password ==form.value.password) {
      for (let x = 0; x < this.roles.length; x++) {
        for (let index = 0; index < this.roles[x].dni_Employee.length; index++) {
          if(this.roles[x].dni_Employee[index]==this.employees[i].dni){
            this.router.navigateByUrl('package');
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
