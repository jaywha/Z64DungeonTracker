using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z64DungeonTracker.Models
{
    public record EquipmentModel : BaseModel
    {
        [BsonElement("playerid")]
        public Guid PlayerID { get; set; }
        
        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("notes")]
        public string? Notes { get; set; }

        [BsonElement("hint")]
        public string? Hint { get; set; }

        [BsonElement("found")]
        public bool Found { get; set; } = false;

        [BsonElement("ammo")]
        public int? Ammo { get; set; } = null;
    }
}
