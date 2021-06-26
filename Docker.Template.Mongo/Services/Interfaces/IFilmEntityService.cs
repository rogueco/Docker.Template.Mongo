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
        Task<Film> GetFilmById(Guid id);
    }
}