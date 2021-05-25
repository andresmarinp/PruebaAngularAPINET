import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CorralComponent } from './corral/corral.component';
import { HttpClientModule} from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
import { AnimalComponent } from './animal/animal.component';
import { RestriccionComponent } from './restriccion/restriccion.component';
import { HeaderComponent } from './header/header.component';
import { TipoanimalComponent } from './tipoanimal/tipoanimal.component';
import { AnimalescorralComponent } from './animalescorral/animalescorral.component';

const rutas: Routes = [
  {
    path: 'corral',
    component: CorralComponent
  },
  {
    path: 'animal',
    component: AnimalComponent
  },
  {
    path: 'tipoanimal',
    component: TipoanimalComponent
  },
  {
    path: 'restriccion',
    component: RestriccionComponent
  },
  {
    path: 'animalescorral',
    component: AnimalescorralComponent
  }];

@NgModule({
  declarations: [
    AppComponent,
    CorralComponent,
    AnimalComponent,
    RestriccionComponent,
    HeaderComponent,
    TipoanimalComponent,
    AnimalescorralComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
    RouterModule.forRoot(rutas,{})
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
