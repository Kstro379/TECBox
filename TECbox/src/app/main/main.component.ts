import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }
  users = ['pedro','ronal','eli']
  pass = ['pass1','pass2','pass3']
  rol = ['admin','client','report']

  confirm(userName, userPass){
    for (let i = 0; i < this.users.length; i++) {
      if (this.users[i] == userName.value && this.pass[i] ==userPass.value) {
        if(this.rol[i] == 'client'){
          this.router.navigate(['/client']);
        }else{
          alert(this.rol[i]);
        }
        return false;
      }
    }
    alert('El nombre de usuario o contraseña es incorrecto');
    return false;
  }

}
