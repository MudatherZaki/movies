using Movies.Core.Domain;
using System;

namespace Movies.Domain
{
    public class Movie: Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }
        public string PosterUrl { get; set; }
        public string TrailerUrl { get; set; }
    }
}
