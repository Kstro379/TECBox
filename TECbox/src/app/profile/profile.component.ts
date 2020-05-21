import { Component, OnInit } from '@angular/core';

import { DataService } from '../data.service';
import { AppComponent } from '../app.component';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  

  constructor(private http:DataService) {
   }

  ngOnInit(): void {
    this.http.getUser(AppComponent.get().toString()).subscribe(http => this.user=http);
  }

  user;

  actualizar(){
    return false;
  }

}
