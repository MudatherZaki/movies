import { Component, Input, OnInit } from '@angular/core';
import { Movie } from 'src/app/models/movie';

@Component({
  selector: 'app-movie-card-component',
  templateUrl: './movie-card-component.component.html',
  styleUrls: ['./movie-card-component.component.css']
})
export class MovieCardComponentComponent implements OnInit {

  @Input() movie?: Movie
  constructor() { }

  ngOnInit(): void {
  }

}
