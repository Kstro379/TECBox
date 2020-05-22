import { Component, OnInit } from '@angular/core';
import { DataListaEntregaService } from './data-lista-entrega.service';
import { Employe } from './employee';
import { Roles } from './Role';
import { flatten } from '@angular/compiler';
import { Package } from '../lista-reparto/paquetes';
import { element } from 'protractor';

@Component({
  selector: 'app-lista-entrega',
  templateUrl: './lista-entrega.component.html',
  styleUrls: ['./lista-entrega.component.scss'],
})
export class ListaEntregaComponent implements OnInit {
  pageName = 'Paquetes entregados';
  warning = true;
  roles: Roles[];
  employeesTemp = [];
  repartidores: number[];
  dni: number[];
  package;
  paquetesEntregados;
  tabla = true;
  status = 'Entregado al cliente';
  elemento: number;
  empleados = [];
  check = true;
  nameTemp = [];

  // Entrada: niguna
  // Función: esconde el mensaje de alerta
  // Salida: ninguna
  rigth() {
    this.warning = false;
  }

  // Entrada: niguna
  // Función: Muestra los Paquetes Ordenados.
  // Salida: ninguna
  mostrar() {
    this.tabla = false;
    console.log(this.package);

    // tslint:disable-next-line: no-shadowed-variable
    for (const element of this.package) {
      if (element.status === 'Entregado al cliente') {
        this.elemento = element.dni_Employee;

        for (const iterator of this.empleados) {
          if (iterator === this.elemento) {
            this.check = false;
          }
        }
        if (this.check) {
          this.empleados.push(this.elemento);
        } else {
          this.check = true;
        }
      }
    }
    this.nombres(this.empleados);
  }

  // Entrada: niguna
  // Función: Actualiza la lista de empleados.
  // Salida: ninguna
  nombres(listEmpleados: number[]) {
    for (const iterator of listEmpleados) {
      this._http.getEmployeeData(iterator).subscribe((data) => {
        this.employeesTemp.push(data);
      });
    }
    console.log(this.empleados);
    console.log(this.employeesTemp);

  }

  // Entrada: fecha de algún calendario
  // Función: convierte la fecha del calendario en un enetro
  // Salida: returna el número correspondiente a la fecha
  convertDate(datesAsInt: string) {
    return new Date(datesAsInt).getTime();
  }

  print() {
    window.print();
  }

  // Costructor de la clase para las conexiones
  // tslint:disable-next-line: variable-name
  constructor(private _http: DataListaEntregaService) {}

  // Entrada: ninguna
  // Función: guarda mediante el servidor la lista de gastos
  // Salida: ninguna
  ngOnInit() {
    this._http.getRolesData().subscribe((data) => {
      this.roles = data;
      console.log(this.roles);
    });
    this._http.getPaquetesData().subscribe((data) => {
      this.package = data;
      console.log(this.package);
    });
  }
}
