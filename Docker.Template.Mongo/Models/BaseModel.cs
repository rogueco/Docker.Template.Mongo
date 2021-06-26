// -----------------------------------------------------------------------
// <copyright company="N/A." file="BaseModel.cs">
// </copyright>
// <author>
// Thomas Fletcher, Average Developer
// tom@tomfletcher.tech
// </author>
// -----------------------------------------------------------------------

using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Docker.Template.Mongo.Models
{
    public class BaseModel
    {
        [BsonElement("Created At")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("Updated At")]
        public DateTime UpdateAt { get; set; }
    }
}