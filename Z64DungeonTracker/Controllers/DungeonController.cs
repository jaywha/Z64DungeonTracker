using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Z64DungeonTracker.Models;
using Z64DungeonTracker.Utilities;

namespace Z64DungeonTracker.Controllers
{
    public class DungeonController : BaseController<DungeonModel>
    {
        public DungeonController(string conn_string, string db_name, string collection_name)
            : base(conn_string, db_name, collection_name) { }

        public List<DungeonModel> GetRoom(string seed) =>
            Client
                .GetDatabase(DBName)
                .GetCollection<DungeonModel>(DBCollection)
                .Find(dungeon => dungeon.Seed!.Equals(seed))
                .ToList();
    }
}
