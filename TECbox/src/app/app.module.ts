import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Route } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainComponent } from './main/main.component';
import { ClientComponent } from './client/client.component';
import { MyCarComponent } from './my-car/my-car.component';
import { RastreoComponent } from './rastreo/rastreo.component';
import { ProfileComponent } from './profile/profile.component';

const routes: Route[] = [
  {path: '', component: MainComponent},
  {path: 'client', component: ClientComponent},
  {path: 'profile', component: ProfileComponent},
  {path: 'rastreo', component: RastreoComponent},
  {path: 'my_car', component: MyCarComponent}
];

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    ClientComponent,
    MyCarComponent,
    RastreoComponent,
    ProfileComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
