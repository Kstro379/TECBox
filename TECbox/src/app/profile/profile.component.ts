import { Component, OnInit } from '@angular/core';

import { DataService } from '../data.service';
import { AppComponent } from '../app.component';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  // Guarda los datos del usuario en sesion.
  user;

  /**
   * Constructor
   * @param http: Api
   */
  constructor(private http:DataService) {
   }

   /**
    * ngOnInit: Trae la data.
    */
  ngOnInit(): void {
    this.http.getUser(AppComponent.get().toString()).subscribe(http => this.user=http);
  }

  /**
   * Actualiza la informacion del usuario.
   */
  actualizar(){
    return false;
  }

}
