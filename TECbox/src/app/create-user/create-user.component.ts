import { Component, OnInit } from '@angular/core';

import { DataService } from '../data.service';


@Component({
  selector: 'app-create-user',
  templateUrl: './create-user.component.html',
  styleUrls: ['./create-user.component.css']
})
export class CreateUserComponent implements OnInit {

  // Lista de las provincias.
  provincias = [];
  // Numero de provincias.
  numProvincia;
  // Lista de cantones.
  cantones;
  // Numero de cantones.
  numCanton;
  // Lista de distritos.
  distritos;

  /**
   * Constructor
   * @param _http: Api
   */
  constructor(private _http:DataService) { }

  /**
   * Trae la data.
   */
  ngOnInit(): void {
    this._http.provincias().subscribe(data => {
      this.provincias.push
      (data);
      console.log(this.provincias);
    });
  }

  /**
   * Crea el usuario.
   */
  actualizar() {
    return false;
  }

  /**
   * Buscar.
   * @param i: ID a buscar.
   */
  search(i: number) {}

}
