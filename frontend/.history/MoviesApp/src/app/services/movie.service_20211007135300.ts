import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { resources } from './resources';
import { Observable } from 'rxjs';
import { MovieResponse } from '../models/response';


@Injectable({
  providedIn: 'root'
})
export class MovieService {

  constructor(private httpClient: HttpClient) { }

  getAll(): Observable<MovieResponse>{
    debugger;
    return this.httpClient.get<MovieResponse>(environment.apiUrl + resources.movie)
  }
}
