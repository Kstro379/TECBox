import { Component, OnInit } from '@angular/core';
import { Roles } from './roles';
import { DataService } from './data.service';

@Component({
  selector: 'app-gestion-roles',
  templateUrl: './gestion-roles.component.html',
  styleUrls: ['./gestion-roles.component.scss']
})
export class GestionRolesComponent implements OnInit {
  rol: Roles = {
    name: null,
    description: null,
    dni_Employee: null

  };

  roles: any;


  // tslint:disable-next-line: variable-name
  constructor(private _http: DataService) { }

  // Entrada: ninguna
  // Función: realiza la conexión con el servidor para obtener los datos de los roles
  // Salida: ninguna
  ngOnInit() {
    this._http.getRolesData().subscribe(data => {
      this.roles = data;
      console.log(this.roles);
    });
  }

  // Entrada: ninguna
  // Función: guarda mediante el servidor los datos de los roles
  // Salida: ninguna
  Agregar(name: string, description: string) {
    console.log(name, description);
    this._http.postRolData(name, description);
    alert('Rol guardado');
    window.location.reload();
  }

  // Entrada: ninguna
  // Función: muestra pop que indica la edición del elemento
  // Salida: mensaje informativo
  Editar(name: string, description: string, dniEmployee: number){
    this._http.putRolData(name, description);
    alert('Rol editada');
  }

  // Entrada: ninguna
  // Función: muestra pop que indica la eliminacion del elemento
  // Salida: mensaje informativo
  Eliminar(name: string){
    console.log('Se va a eliminar:');
    console.log(name);
    this._http.deleteRolData(name).subscribe(data => {
      this.roles = data;
      console.log(this.roles);
      alert('Se elimino correctamente');
      window.location.reload();
    }, (error) => {
      console.log(error);
      alert('Ocurrio un error:' + error);
    });
    }
}
