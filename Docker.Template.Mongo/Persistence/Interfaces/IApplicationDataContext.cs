// -----------------------------------------------------------------------
// <copyright company="N/A." file="IApplicationDataContext.cs">
// </copyright>
// <author>
// Thomas Fletcher, Average Developer
// tom@tomfletcher.tech
// </author>
// -----------------------------------------------------------------------

using Docker.Template.Mongo.Models;
using MongoDB.Driver;

namespace Docker.Template.Mongo.Persistence.Interfaces
{
    public interface IApplicationDataContext
    {
        IMongoCollection<Film> Films { get; }
        
        // IMongoCollection<Director> Directors { get; }
    }
}