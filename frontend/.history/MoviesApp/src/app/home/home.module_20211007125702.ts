import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { HomeComponentComponent } from './home-component.component';
import { MovieCardComponentComponent } from './movie-card-component/movie-card-component.component';
import { MovieFormComponentComponent } from './movie-form-component/movie-form-component.component';
import { HomeComponent } from './home.component';


@NgModule({
  declarations: [HomeComponentComponent, MovieCardComponentComponent, MovieFormComponentComponent, HomeComponent],
  imports: [
    CommonModule,
    HomeRoutingModule
  ]
})
export class HomeModule { }
