using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Core.Wrappers;
using MoviesApp.DTOs;
using MoviesApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    [Authorize]
    public class MovieController : ControllerBase
    {
        public MoviesService _moviesService { get; set; }
        public MovieController(MoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet]
        public async Task<Response<List<MovieDto>>> Get()
        {
            return await _moviesService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Response<MovieDto>> GetDetails(int id)
        {
            return await _moviesService.GetDetails(id);
        }

        [HttpPost]
        public async Task<Response> Add(MovieDto movieDto)
        {
            return await _moviesService.Add(movieDto);
        }

        [HttpPut]
        public async Task<Response<MovieDto>> Update(MovieDto movieDto)
        {
            return await _moviesService.Update(movieDto);
        }

        [HttpDelete("{id}")]
        public async Task<Response> Delete(int id)
        {
            return await _moviesService.Delete(id);

        }
    }
}

