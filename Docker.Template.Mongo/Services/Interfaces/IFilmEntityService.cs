// -----------------------------------------------------------------------
// <copyright company="N/A." file="IFilmEntityService.cs">
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

namespace Docker.Template.Mongo.Services.Interfaces
{
    public interface IFilmEntityService
    {
        
        /// <summary>
        /// Get all films that are available in the MongoDB Collection
        /// </summary>
        /// <returns>List of Films</returns>
        Task<IEnumerable<Film>> GetAllFilms();

        /// <summary>
        /// Gets a Film by it's id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Single Film</returns>
        Task<Film> GetFilmById(string id);

        /// <summary>
        /// Create a film
        /// </summary>
        /// <param name="film"></param>
        /// <returns>Created Film</returns>
        Task CreateFilm(Film film);

        /// <summary>
        /// Updates a specified Film
        /// </summary>
        /// <param name="film"></param>
        /// <returns>Updated Film</returns>
        Task<bool> UpdateFilm(Film film);

        /// <summary>
        /// Deletes films
        /// </summary>
        /// <param name="id"></param>
        /// <returns>bool based on success</returns>
        Task<bool> DeleteFilm(string id);
    }
}