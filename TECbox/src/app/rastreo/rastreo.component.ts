import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-rastreo',
  templateUrl: './rastreo.component.html',
  styleUrls: ['./rastreo.component.css']
})
export class RastreoComponent implements OnInit {

  estado = '.';

  constructor() { }

  ngOnInit(): void {
  }

  rastrear(paqueteId){
    this.estado = paqueteId.value;
    return false;
  }
}
