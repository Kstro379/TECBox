import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeAdministracionComponent } from './Components/home-administracion/home-administracion.component';
import { GestionRolesComponent } from './Components/gestion-roles/gestion-roles.component';
import { ListaRepartoComponent } from './Components/lista-reparto/lista-reparto.component';
import { ListaEntregaComponent} from './Components/lista-entrega/lista-entrega.component';
import { ListaProductosComponent } from './Components/lista-productos/lista-productos.component';



const routes: Routes = [
  { path: '', component: HomeAdministracionComponent },
  { path: 'gestion-roles', component: GestionRolesComponent },
  { path: 'lista-reparto', component: ListaRepartoComponent},
  { path: 'lista-entrega', component: ListaEntregaComponent},
  { path: 'lista-producto', component: ListaProductosComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
