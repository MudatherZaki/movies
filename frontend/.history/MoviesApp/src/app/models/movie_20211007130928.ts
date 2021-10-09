export class Movie {
    id: Number;
    title: string;
    description: string;
    posterUrl: string;
    trailerUrl:	string;
    rating:	Number;

    constructor(id: Number, title: string, description: string, posterUrl: string, 
        trailerUrl: string, rating: Number){
        this.id = id;
        this.description = description;
        this.posterUrl = posterUrl;
        this.rating = rating;
        this.trailerUrl = trailerUrl;
        this.title = title;
    }
    
}
