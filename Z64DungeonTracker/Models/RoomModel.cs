using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z64DungeonTracker.Models
{
    public record RoomModel : BaseModel
    {
        [BsonElement("Seed")]
        public string? Seed { get; private set; }

        public override string ToString()
            => $"Room {Seed}";
    }
}
