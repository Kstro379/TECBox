import { Component, OnInit } from '@angular/core';

import { DataService } from '../data.service';


@Component({
  selector: 'app-create-user',
  templateUrl: './create-user.component.html',
  styleUrls: ['./create-user.component.css']
})
export class CreateUserComponent implements OnInit {

  provincias = [];
  numProvincia;
  cantones;
  numCanton;
  distritos;

  constructor(private _http:DataService) { }

  ngOnInit(): void {
    this._http.provincias().subscribe(data => {
      this.provincias.push
      (data);
      console.log(this.provincias);
    });
  }

  actualizar() {
    return false;
  }

  search(i: number) {}

}
