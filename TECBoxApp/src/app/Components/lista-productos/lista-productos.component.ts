import { Component, OnInit } from '@angular/core';
import { Ventas } from './ventas';
import { DataListaProductosService } from './data-lista-productos.service';

@Component({
  selector: 'app-lista-productos',
  templateUrl: './lista-productos.component.html',
  styleUrls: ['./lista-productos.component.scss']
})
export class ListaProductosComponent implements OnInit {

  pageName = 'Productos más vendidos';
  warning = true;
  tabla = true;
  ventas: Ventas[];

  rigth(){
    this.warning = false;
  }

  print() {
    window.print();
  }

  mostrar(){
    this.tabla = false;
  }

   // Entrada: fecha de algún calendario
  // Función: convierte la fecha del calendario en un enetro
  // Salida: returna el número correspondiente a la fecha
  convertDate(datesAsInt: string) {
    return new Date(datesAsInt).getTime();
  }

  // tslint:disable-next-line: variable-name
  constructor(private _http: DataListaProductosService) { }

  ngOnInit(): void {
    this._http.getVentasData().subscribe((data) => {
      this.ventas = data;
      console.log(this.ventas);
    });
  }

}
