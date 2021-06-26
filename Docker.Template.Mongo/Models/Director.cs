// -----------------------------------------------------------------------
// <copyright company="N/A." file="Director.cs">
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
    public class Director : BaseModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        
    }
}