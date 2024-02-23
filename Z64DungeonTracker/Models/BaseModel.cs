using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z64DungeonTracker.Models
{
    public record BaseModel
    {
        [BsonElement("_id")]
        public ObjectId Id { get; set; }
    }
}
