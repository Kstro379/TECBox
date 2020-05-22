import { Component , OnInit  } from '@angular/core';
import { Router } from  "@angular/router";

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage implements OnInit{

  /**
   * Constructor
   * @param router: Paginas
   */
  constructor(private  router:  Router) {}

  /**
   * Init
   */
  ngOnInit() {}

  /**
   * Realiza la verificacion del usuario. 
   * @param form: Username y password
   */
  login(form){
    console.log(form.value);
    this.router.navigateByUrl('package');
  }

}
