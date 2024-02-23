using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z64DungeonTracker.Models
{
    public record DungeonModel : BaseModel
    {
        [BsonElement("Entrance")]
        public string? Entrance { get; private set; }

        [BsonElement("Actual")]
        public string? Actual { get; private set; }

        [BsonElement("Boss")]
        public string? Boss { get; private set; }

        [BsonElement("IsCleared")]
        public bool IsCleared { get; private set; }

        public DungeonModel(string e, string a, string b, bool cleared)
        {
            Entrance = e;
            Actual = a;
            Boss = b;
            IsCleared = cleared;
        }

        public override string ToString()
            => $"[{(IsCleared ? "CLEAR" : "TODO")}] {Entrance} leads to {Actual} with {Boss}";
        
    }
}
