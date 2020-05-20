import { Component, OnInit } from '@angular/core';
import { DataListaEntregaService } from './data-lista-entrega.service';

@Component({
  selector: 'app-lista-entrega',
  templateUrl: './lista-entrega.component.html',
  styleUrls: ['./lista-entrega.component.scss']
})
export class ListaEntregaComponent implements OnInit {

  pageName = 'Paquetes entregados';
  sucursal: string;
  allSpeding = 'sin especificar';
  selected = false;
  warning = true;
  selectedBranch: string;
  selectedBranchId: string;
  spendingData: any;

  // Entrada: nombre de la sucursal y id
  // Función: nombra la pagina, la sucursal y almacena los datos; además cambia la vista
  // Salida: ninguna
  selectBranch(name: string, id: string) {
    this.pageName = 'Gastos  ' + name;
    this.sucursal = name;
    this.selectedBranch = name;
    this.selectedBranchId = id;
    this.selected = true;
  }

  // Entrada: ninguna
  // Función: regresa la pagina y cambia su nombre
  // Salida: ninguna
  back() {
    this.pageName = 'Seleccione una sucursal';
    this.selected = false;
  }

  // Entrada: niguna
  // Función: esconde el mensaje de alerta
  // Salida: ninguna
  rigth() {
    this.warning = false;
  }

  // Entrada: fecha de algún calendario
  // Función: convierte la fecha del calendario en un enetro
  // Salida: returna el número correspondiente a la fecha
  convertDate(datesAsInt: string) {
    console.log(datesAsInt);
    console.log(new Date(datesAsInt).getTime());
    return  new Date(datesAsInt).getTime();
  }

  // Costructor de la clase para las conexiones
  // tslint:disable-next-line: variable-name
  constructor(private _http:  DataListaEntregaService) {
    console.log('Reading local json files');
  }

  // Entrada: ninguna
  // Función: guarda mediante el servidor la lista de gastos
  // Salida: ninguna
  ngOnInit() {
    
  }

}
