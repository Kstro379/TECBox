import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeAdministracionComponent } from './Components/home-administracion/home-administracion.component';
import { GestionRolesComponent } from './Components/gestion-roles/gestion-roles.component';
import { ListaEntregaComponent } from './Components/lista-entrega/lista-entrega.component';
import { ListaProductosComponent } from './Components/lista-productos/lista-productos.component';
import { ListaRepartoComponent } from './Components/lista-reparto/lista-reparto.component';


const routes: Routes = [
  { path: 'administracion', component: HomeAdministracionComponent },
  { path: 'gestion-roles', component: GestionRolesComponent },
  { path: 'lista-reparto', component: ListaRepartoComponent},
  { path: 'lista-entregados', component: ListaEntregaComponent},
  { path: 'lista-producto', component: ListaProductosComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
