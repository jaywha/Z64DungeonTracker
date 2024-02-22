using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Z64DungeonTracker.Models;

namespace Z64DungeonTracker.Controllers
{
    public class MongoDBController
    {
        private MongoClient Client { get; set; }
        private string DBName { get; set; }
        private string DBCollection { get; set; }

        public MongoDBController(string conn_string, string db_name, string collection_name)
        {
            Client = new MongoClient(conn_string);
            DBName = db_name;
            DBCollection = collection_name;
        }

        public List<DungeonModel> Read() =>
            Client
                .GetDatabase(DBName)
                .GetCollection<DungeonModel>(DBCollection)
                .Find(x => !string.IsNullOrEmpty(x.Actual))
                .ToList();

        public void Write(DungeonModel record)
        {
            Client
                .GetDatabase(DBName)
                .GetCollection<DungeonModel>(DBCollection)
                .ReplaceOne(
                    filter: x => x.Id.Equals(record!.Id),
                    replacement: record!,
                    options: new ReplaceOptions()
                    {
                        IsUpsert = true
                    }
                );
        }

        public void Delete(DungeonModel record)
        {
            Client
                .GetDatabase(DBName)
                .GetCollection<DungeonModel>(DBCollection)
                .DeleteOne(
                    filter: x => x.Id.Equals(record!.Id)
                );
        }

        public void WriteAll(List<DungeonModel> records)
        {
            foreach (var record in records)
            {
                Write(record);
            }
        }
    }
}
