import { Component, OnInit } from '@angular/core';

import { DataService } from '../data.service';

@Component({
  selector: 'app-create-user',
  templateUrl: './create-user.component.html',
  styleUrls: ['./create-user.component.css']
})
export class CreateUserComponent implements OnInit {

  constructor(private http:DataService) { }

  ngOnInit(): void {
  }

  user = {"dni":0,"user":"","name":"","last_Name":"","phoneNumber":0,"email":"","password":"","house_PhoneNumber":0,"locker":0,"district":"","canton":"","province":"","address":""};

  actualizar(){
    return false;
  }

}
