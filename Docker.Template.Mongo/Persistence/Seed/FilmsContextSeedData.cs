// -----------------------------------------------------------------------
// <copyright company="N/A." file="FilmsContextSeedData.cs">
// </copyright>
// <author>
// Thomas Fletcher, Average Developer
// tom@tomfletcher.tech
// </author>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Docker.Template.Mongo.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Docker.Template.Mongo.Persistence.Seed
{
    public class FilmsContextSeedData
    {
        public static void SeedData(IMongoCollection<Film> filmCollection)
        {
            bool filmsExist = filmCollection.Find(x => true).Any();
            if (!filmsExist)
            {
                filmCollection.InsertMany(SeededFilmCollection());
                filmCollection.InsertOne(new Film
                    {
                        Id = "8fbf1830516c846ea774360e",
                        Title = "Police Academy 4: Citizens on Patrol",
                        Description = "A new batch of recruits arrives at Police Academy, this time a group of civilian volunteers who have joined Commandant Lassard's new Citizens on Patrol program",
                        Director = "",
                        Rating = 5.5,
                        CreatedAt = DateTime.Now,
                        ReleaseYear = 1987,
                        UpdateAt = DateTime.Now
                    }
                );
            }
        }

        private static IEnumerable<Film> SeededFilmCollection()
        {
            return new List<Film>()
            {
                new Film()
                {
                    // This should work... It does not - just generates hexadecimal of 0^24. In the end I used https://www.browserling.com/tools/random-hex to generate random hexadecimals
                    // Id = new ObjectId().ToString(),
                    Id = "78d2fe28edde0f94ec8de0f7",
                    Title = "Police Academy 4: Citizens on Patrol",
                    Description = "A new batch of recruits arrives at Police Academy, this time a group of civilian volunteers who have joined Commandant Lassard's new Citizens on Patrol program",
                    Director = "",
                    Rating = 5.5,
                    CreatedAt = DateTime.Now,
                    ReleaseYear = 1987,
                    UpdateAt = DateTime.Now
                },
                new Film()
                {
                    Id = "a887813083688cfbf51c5a9a",
                    Title = "Marvel One-Shot: All Hail the King",
                    Description = "A documentary filmmaker interviews the now-famous Trevor Slattery from behind bar",
                    Director = "",
                    Rating = 6.9,
                    CreatedAt = DateTime.Now,
                    ReleaseYear = 2014,
                    UpdateAt = DateTime.Now
                },
                new Film()
                {
                    Id = "6fb369fdee065cb6a07dd330",
                    Title = "Chicken Run",
                    Description = "Having been hopelessly repressed and facing eventual certain death at the British chicken farm where they are held, Ginger the chicken along with the help of Ro",
                    Director = "",
                    Rating = 6.9,
                    CreatedAt = DateTime.Now,
                    ReleaseYear = 2000,
                    UpdateAt = DateTime.Now
                },
                new Film()
                {
                    Id = "d738e187ecbf33e8b9e62205",
                    Title = "Night at the Museum: Secret of the Tomb",
                    Description = "When the magic powers of The Tablet of Ahkmenrah begin to die out, Larry Daley spans the globe, uniting favorite and new characters while embarking on an epic",
                    Director = "",
                    Rating = 6.2,
                    CreatedAt = DateTime.Now,
                    ReleaseYear = 2014,
                    UpdateAt = DateTime.Now
                },
                new Film()
                {
                    Id = "78455636ad6188f5d83c26df",
                    Title = "Pirates of the Caribbean: The Curse of the Black Pearl",
                    Description = "Jack Sparrow, a freewheeling 18th-century pirate, quarrels with a rival pirate bent on pillaging Port Royal. When the governor's daughter is kidnapped, Sparrow ...",
                    Director = "",
                    Rating = 7.7,
                    CreatedAt = DateTime.Now,
                    ReleaseYear = 2003,
                    UpdateAt = DateTime.Now
                },
            };
        }
    }
}