// -----------------------------------------------------------------------
// <copyright company="N/A." file="DirectorsContextSeedData.cs">
// </copyright>
// <author>
// Thomas Fletcher, Average Developer
// tom@tomfletcher.tech
// </author>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Docker.Template.Mongo.Models;
using MongoDB.Driver;

namespace Docker.Template.Mongo.Persistence.Seed
{
    public static class DirectorsContextSeedData
    {
        public static void SeedData(IMongoCollection<Director> directorCollection)
        {
            bool filmsExist = directorCollection.Find(x => true).Any();
            if (!filmsExist)
            {
                directorCollection.InsertManyAsync(SeededDirectorCollection());
            }
        }

        private static IEnumerable<Director> SeededDirectorCollection()
        {
            return new List<Director>()
            {
                new()
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Test",
                    LastName = "Testerson",
                    DateOfBirth = DateTime.Today.AddYears(-27),
                    CreatedAt = DateTime.Now,
                },
                new()
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Testy",
                    LastName = "Testerson",
                    DateOfBirth = DateTime.Today.AddYears(-27),
                    CreatedAt = DateTime.Now,
                },
                new()
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Luke",
                    LastName = "Skywalker",
                    DateOfBirth = DateTime.Today.AddYears(-27),
                    CreatedAt = DateTime.Now,
                }
            };
        }
    }
}