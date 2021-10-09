import { Movie } from "./movie";

export class MovieResponse {
    succeeded: boolean = false;
    message: string = "";
    data: Movie = new Movie();
}
