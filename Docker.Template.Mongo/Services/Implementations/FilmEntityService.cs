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

        public async Task<IEnumerable<Film>> GetAllFilms() =>
            await _applicationDataContext.Films.Find(x => true).ToListAsync();

        public async Task<Film> GetFilmById(string id) =>
            await _applicationDataContext.Films.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateFilm(Film film) =>
            await _applicationDataContext.Films.InsertOneAsync(film);

        public async Task<bool> UpdateFilm(Film film)
        {
            
            ReplaceOneResult updatedItem = await _applicationDataContext.Films.ReplaceOneAsync(filter: x => x.Id == film.Id, replacement: film);
            return updatedItem.IsAcknowledged && updatedItem.ModifiedCount > 0;
        }

        public async Task<bool> DeleteFilm(string id)
        {
            DeleteResult deleteItem = await _applicationDataContext.Films.DeleteOneAsync(x => x.Id == id);
            return deleteItem.IsAcknowledged && deleteItem.DeletedCount > 0;
        }
    }
}