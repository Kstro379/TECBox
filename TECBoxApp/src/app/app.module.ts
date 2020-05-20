import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeAdministracionComponent } from './Components/home-administracion/home-administracion.component';
import { GestionRolesComponent } from './Components/gestion-roles/gestion-roles.component';

import { DataService } from './Components/gestion-roles/data.service';
import { ListaRepartoComponent } from './Components/lista-reparto/lista-reparto.component';
import { ListaEntregaComponent} from './Components/lista-entrega/lista-entrega.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeAdministracionComponent,
    GestionRolesComponent,
    ListaRepartoComponent,
    ListaEntregaComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [DataService],
  bootstrap: [AppComponent]
})
export class AppModule { }
