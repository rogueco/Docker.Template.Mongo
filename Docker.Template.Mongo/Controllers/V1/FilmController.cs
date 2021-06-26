// -----------------------------------------------------------------------
// <copyright company="N/A." file="FilmController.cs">
// </copyright>
// <author>
// Thomas Fletcher, Average Developer
// tom@tomfletcher.tech
// </author>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Docker.Template.Mongo.Models;
using Docker.Template.Mongo.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// ReSharper disable RouteTemplates.RouteParameterConstraintNotResolved
// ReSharper disable RouteTemplates.ControllerRouteParameterIsNotPassedToMethods

namespace Docker.Template.Mongo.Controllers.V1
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/{version:apiVersion}/[controller]")]
    public class FilmController : ControllerBase
    {
        private readonly IFilmEntityService _filmEntityService;

        public FilmController(IFilmEntityService filmEntityService)
        {
            _filmEntityService = filmEntityService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Film>), (int) HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Film>>> GetAllFilms()
        {
            IEnumerable<Film> films = await _filmEntityService.GetAllFilms();
            return Ok(films);
        }

        [HttpGet("{id}", Name = "GetFilm")]
        [ProducesResponseType(typeof(Film), (int) HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Film>>> GetFilmById(string id)
        {
            Film film = await _filmEntityService.GetFilmById(id);
            return Ok(film);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Film), (int) HttpStatusCode.OK)]
        public async Task<ActionResult<Film>> CreateFilm([FromBody] Film film)
        {
            await _filmEntityService.CreateFilm(film: film);
            return CreatedAtRoute("GetFilm", new {id = film.Id}, film);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Film), (int) HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateFilm([FromBody] Film film)
        {
            return Ok(await _filmEntityService.UpdateFilm(film));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Film), (int) HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteFilmById(string id)
        {
            return Ok(await _filmEntityService.DeleteFilm(id));
        }
    }
}