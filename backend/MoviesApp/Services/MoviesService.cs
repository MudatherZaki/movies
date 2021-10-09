using Movies.Core.Presistence;
using Movies.Core.Wrappers;
using Movies.Domain;
using MoviesApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Services
{
    public class MoviesService
    {
        public IRepository<Movie> _moviesRepo { get; set; }
        public MoviesService(IRepository<Movie> repository)
        {
            _moviesRepo = repository;
        }

        public async Task<Response<List<MovieDto>>> GetAll()
        {
            return (await _moviesRepo.GetAllAsync()).ToList().Select(m => new MovieDto() 
            {
                Id = m.Id,
                Description = m.Description,
                Title = m.Title,
                PosterUrl = m.PosterUrl,
                TrailerUrl = m.TrailerUrl
            }).ToList();
        }

        public async Task<Response<MovieDto>> GetDetails(int id)
        {
            var movie = await _moviesRepo.GetByIdAsync(id);
            return new MovieDto(movie);
        }

        public async Task<Response> Add(MovieDto movieDto)
        {
            var movieToAdd = new Movie()
            {
                Id = movieDto.Id,
                Description = movieDto.Description,
                Title = movieDto.Title,
                PosterUrl = movieDto.PosterUrl,
                TrailerUrl = movieDto.TrailerUrl
            };
            _moviesRepo.Insert(movieToAdd);
            await _moviesRepo.DbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Response<MovieDto>> Update(MovieDto movieDto)
        {
            var movieToUpdate = await _moviesRepo.GetByIdAsync(movieDto.Id);

            if (movieToUpdate is null)
                return new Response<MovieDto>("Movie was not found");

            movieToUpdate.Title = movieDto.Title;
            movieToUpdate.Description = movieDto.Description;
            movieToUpdate.PosterUrl = movieDto.PosterUrl;
            movieToUpdate.TrailerUrl = movieDto.TrailerUrl;
            movieToUpdate.Rating = movieDto.Rating;
            
            _moviesRepo.Update(movieToUpdate);
            await _moviesRepo.DbContext.SaveChangesAsync();
            return movieDto;

        }

        public async Task<Response> Delete(int id)
        {
            _moviesRepo.Delete(id);
            await _moviesRepo.DbContext.SaveChangesAsync();
            return true;
        }
    }
}
