import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = "TECbox";
  // Un array que va a guardar los productos que el usuario quiere comprar.
  static id: number[] =[];
  // Una variable que va a mantener el DNI del cliente en sesion.
  static var = -1;

  /**
   * get: Obtiene el DNI del cliente en sesion.
   * return: El DNI del cliente
   */
  static get(){
    return this.var;
  }

  /**
   * set: Define el DNI del cliente en sesion.
   * @param dni: DNI del cliente.
   */
  static set(dni){
    this.var=dni;
  }

  /**
   * getID: Obtiene los productos que el usuario quiere comprar.
   * return: Lista de todos los productos.
   */
  static getId(){
    return this.id;
  }

  /**
   * setID: Agrega un producto a los productos que el usuario quiere comprar.
   * @param id: ID del producto a agregar. 
   */
  static setID(id){
    this.id.push(id);
  }

  /**
   * delID: elimina un producto de los productos que el usuario quiere comprar.
   * @param id: el ID del producto a eliminar.
   */
  static delID(id){
    for (let index = 0; index < this.id.length; index++) {
      if(this.id[index] == id){
        this.id.splice(index,1);
        break;
      }
      
    }
  }


}
