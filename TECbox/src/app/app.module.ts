import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Route } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainComponent } from './main/main.component';
import { ClientComponent } from './client/client.component';
import { MyCarComponent } from './my-car/my-car.component';
import { RastreoComponent } from './rastreo/rastreo.component';
import { ProfileComponent } from './profile/profile.component';
import { CreateUserComponent } from './create-user/create-user.component';

import { HomeAdministracionComponent } from './Components/home-administracion/home-administracion.component';
import { GestionRolesComponent } from './Components/gestion-roles/gestion-roles.component';
import { ListaEntregaComponent } from './Components/lista-entrega/lista-entrega.component';
import { ListaProductosComponent } from './Components/lista-productos/lista-productos.component';
import { ListaRepartoComponent } from './Components/lista-reparto/lista-reparto.component';

import { DataService } from './data.service';
import { from } from 'rxjs';

const routes: Route[] = [
  {path: '', component: MainComponent},
  {path: 'client', component: ClientComponent},
  {path: 'profile', component: ProfileComponent},
  {path: 'rastreo', component: RastreoComponent},
  {path: 'my_car', component: MyCarComponent},
  {path: 'newUser', component: CreateUserComponent}
];

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    ClientComponent,
    MyCarComponent,
    RastreoComponent,
    ProfileComponent,
    CreateUserComponent,
    HomeAdministracionComponent,
    GestionRolesComponent,
    ListaEntregaComponent,
    ListaProductosComponent,
    ListaRepartoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(routes)
  ],
  providers: [DataService],
  bootstrap: [AppComponent]
})
export class AppModule { }
