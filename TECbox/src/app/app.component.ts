import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = "TECbox";
  static id: number[] =[];
  static var = -1;
  static get(){
    return this.var;
  }
  static set(dni){
    this.var=dni;
  }

  static getId(){
    return this.id;
  }
  static setID(id){
    this.id.push(id);
  }
  static delID(id){
    for (let index = 0; index < this.id.length; index++) {
      if(this.id[index] == id){
        this.id.splice(index,1);
        break;
      }
      
    }
  }


}
