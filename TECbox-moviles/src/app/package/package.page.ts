import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-package',
  templateUrl: './package.page.html',
  styleUrls: ['./package.page.scss'],
})
export class PackagePage implements OnInit {

  packages: any[] = [
    {
      "Tracking_Id":0, 
      "Status": "Entregado al cliente", 
      "Description":"Es un paquete de sumo cuidado", 
      "Initial_Date":"2020-10-02", 
      "Deliver_Date":"2020-03-12", 
      "Id_Route":1, "District":"San Ramón Central",
      "Dni_Client":207840516, 
      "Dni_Employee":27840876,
    },
    {
      "Tracking_Id":1, 
      "Status": "Entregado al cliente", 
      "Description":"Es un paquete de sumo cuidado", 
      "Initial_Date":"2020-10-02", 
      "Deliver_Date":"2020-03-12", 
      "Id_Route":1, "District":"San Ramón Central",
      "Dni_Client":207840516, 
      "Dni_Employee":27840876,
    },
    {
      "Tracking_Id":2, 
      "Status": "Entregado al cliente", 
      "Description":"Es un paquete de sumo cuidado", 
      "Initial_Date":"2020-10-02", 
      "Deliver_Date":"2020-03-12", 
      "Id_Route":1, "District":"San Ramón Central",
      "Dni_Client":207840516, 
      "Dni_Employee":27840876,
    }
  ];

  /**
   * Constructor
   */
  constructor() { }

  /**
   * Init
   */
  ngOnInit() {
  }

  /**
   * Marca el paquete.
   * @param value: Nuevo estado.
   * @param id: ID del paquete
   */
  actualizar(value, id){
    console.log(value);
    console.log(id);
  }

}
