using Movies.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.DTOs
{
    public class MovieDto
    {
        public MovieDto()
        {

        }

        public MovieDto(Movie movie)
        {
            Id = movie.Id;
            Description = movie.Description;
            Title = movie.Title;
            PosterUrl = movie.PosterUrl;
            TrailerUrl = movie.TrailerUrl;
            Rating = movie.Rating;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PosterUrl { get; set; }
        public string TrailerUrl { get; set; }
        public decimal Rating { get; set; }

    }
}
