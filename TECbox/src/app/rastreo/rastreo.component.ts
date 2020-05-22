import { Component, OnInit } from '@angular/core';

import { DataService } from '../data.service'

@Component({
  selector: 'app-rastreo',
  templateUrl: './rastreo.component.html',
  styleUrls: ['./rastreo.component.css']
})
export class RastreoComponent implements OnInit {

  // Lista de todos los paquetes.
  paquetes;
  // El estado del paquete que se pregunta.
  estado = '.';

  /**
   * Constructor
   * @param data: Api
   */
  constructor(private data: DataService) { }

  /**
   * ngOnInit: Trae la data.
   */
  ngOnInit(): void {
    this.data.package().subscribe(data => this.paquetes=data);
  }

  /**
   * rastrear: Obtiene el estado del paquete que se esta preguntando.
   * @param paqueteId: ID del paquete.
   */
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
