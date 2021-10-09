import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { resources } from './resources';
import { Observable } from 'rxjs';
import { DataResponse } from '../models/response';
import { Movie } from '../models/movie';


@Injectable({
  providedIn: 'root'
})
export class MovieService {

  constructor(private httpClient: HttpClient) { }

  getAll(): Observable<DataResponse<Movie>>{
    debugger;
    return this.httpClient.get<DataResponse<Movie>>(environment.apiUrl + resources.movie)
  }
}
