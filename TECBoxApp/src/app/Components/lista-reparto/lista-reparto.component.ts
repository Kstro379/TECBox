import { Component, OnInit } from '@angular/core';
import { DataListaRepartoService } from './data-lista-reparto.service';
import { Rutas } from './rutas';
import { Package } from './paquetes';

@Component({
  selector: 'app-lista-reparto',
  templateUrl: './lista-reparto.component.html',
  styleUrls: ['./lista-reparto.component.scss']
})
export class ListaRepartoComponent implements OnInit {

  pageName = 'Lista de Reparto';
  sucursal: string;
  tableTitle = 'Paquetes';
  warning = true;
  table = false;
  rutas: Rutas[];
  ruta: number;
  paquetes: Package[];
  status = 'Listo para Entrega';

  employeeData: any;
  selectedBranch: string;
  selectedBranchId: string;

  // Entrada: nombre de los empleados y id
  // Función: nombra el encabezado de a pagina, la sucursal, cambia le boolenao de la vista
  // Salida: ninguna
  selectBranch(name: string, id: string) {
    this.pageName = 'Planilla de  ' + name;
    this.sucursal = name;
    this.selectedBranch = name;
    this.selectedBranchId = id;
  }

  // Entrada: ninguna
  // Función: cambia el booleano del warning
  // Salida: ningina
  rigth() {
    this.warning = false;
  }

  search(rutaId: number) {
    this.table = true;
    this.ruta = rutaId;
    this._http.getPaquetesData().subscribe(data => {
      this.paquetes = data;
      console.log(this.paquetes);
    });
  }


  // tslint:disable-next-line: variable-name
  constructor(private _http: DataListaRepartoService) {
    console.log('Reading local json files');
  }


  // Entrada: ninguna
  // Función: realiza la conexión con el servidor para obtener los productos
  // Salida: ninguna
  ngOnInit() {
    this._http.getRutasData().subscribe(data => {
      this.rutas = data;
      console.log(this.rutas);
    });
  }

}
