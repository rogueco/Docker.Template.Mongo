// -----------------------------------------------------------------------
// <copyright company="N/A." file="ApplicationDataContext.cs">
// </copyright>
// <author>
// Thomas Fletcher, Average Developer
// tom@tomfletcher.tech
// </author>
// -----------------------------------------------------------------------

using Docker.Template.Mongo.Models;
using Docker.Template.Mongo.Persistence.Interfaces;
using Docker.Template.Mongo.Persistence.Seed;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Docker.Template.Mongo.Persistence.Implementations
{
    public class ApplicationDataContext : IApplicationDataContext
    {
        public ApplicationDataContext(IConfiguration configuration)
        {
            // Films Database Connection
            var filmDbClient = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var filmDatabase = filmDbClient.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
            
            Films = filmDatabase.GetCollection<Film>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            FilmsContextSeedData.SeedData(Films);

            // Director Database Connection
            // MongoClient directorDbClient = new MongoClient(configuration.GetValue<string>("DirectorDatabaseSettings:ConnectionString"));
            // IMongoDatabase directorDatabase = directorDbClient.GetDatabase(configuration.GetValue<string>("DirectorDatabaseSettings:DatabaseName"));
            // Directors = directorDatabase.GetCollection<Director>(configuration.GetValue<string>("DirectorDatabaseSettings:CollectionName"));
            // DirectorsContextSeedData.SeedData(Directors);
        }

        public IMongoCollection<Film> Films { get; }
        // public IMongoCollection<Director> Directors { get; }
    }
}