// -----------------------------------------------------------------------
// <copyright company="N/A." file="Film.cs">
// </copyright>
// <author>
// Thomas Fletcher, Average Developer
// tom@tomfletcher.tech
// </author>
// -----------------------------------------------------------------------

using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Docker.Template.Mongo.Models
{
    public class Film 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public double Rating { get; set; }

        public int ReleaseYear { get; set; }

        public string Director { get; set; }
        
        public DateTime CreatedAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}