// -----------------------------------------------------------------------
// <copyright company="N/A." file="FilmEntityService.cs">
// </copyright>
// <author>
// Thomas Fletcher, Average Developer
// tom@tomfletcher.tech
// </author>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Docker.Template.Mongo.Models;
using Docker.Template.Mongo.Persistence.Implementations;
using Docker.Template.Mongo.Persistence.Interfaces;
using Docker.Template.Mongo.Services.Interfaces;
using MongoDB.Driver;

namespace Docker.Template.Mongo.Services.Implementations
{
    public class FilmEntityService : IFilmEntityService
    {
        private readonly IApplicationDataContext _applicationDataContext;

        public FilmEntityService(IApplicationDataContext applicationDataContext)
        {
            _applicationDataContext = applicationDataContext;
        }

        public async Task<IEnumerable<Film>> GetAllFilms() => await _applicationDataContext.Films.Find(x => true).ToListAsync();

        public Task<Film> GetFilmById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}