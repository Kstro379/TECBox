import { Component, OnInit } from '@angular/core';

import { DataService } from '../data.service'

@Component({
  selector: 'app-rastreo',
  templateUrl: './rastreo.component.html',
  styleUrls: ['./rastreo.component.css']
})
export class RastreoComponent implements OnInit {

  paquetes;
  estado = '.';

  constructor(private data: DataService) { }

  ngOnInit(): void {
    this.data.package().subscribe(data => this.paquetes=data);
  }

  rastrear(paqueteId){
    for (let index = 0; index < this.paquetes.length; index++) {
      if(this.paquetes[index].tracking_Id == paqueteId.value){
        this.estado = this.paquetes[index].status;
        return false;
      };
    }
    alert('No existe un paquete con ese Tracking ID');
    return false;
  }
}
