import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  actualizar(userNameComplete, userDni,userCorreo,userCasillero,userCelular,userCasa,userName,userPass,userProvincia,userCanton,userDistrito,userSenas){
    return false;
  }

}
