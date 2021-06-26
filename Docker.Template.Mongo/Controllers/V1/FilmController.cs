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
        [ProducesResponseType(typeof(IEnumerable<Film>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Film>>> GetAllFilms()
        {
            IEnumerable<Film> films = await _filmEntityService.GetAllFilms();
            return Ok(films);
        }
    }
}