using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing.Interop;
using System.Text;
using System.Threading.Tasks;
using Z64DungeonTracker.Models;

namespace Z64DungeonTracker.Controllers
{
    public class BaseController<T> where T : BaseModel
    {
        protected MongoClient Client { get; set; }
        protected string DBName { get; set; }
        protected string DBCollection { get; set; }

        public BaseController(string conn_string, string db_name, string collection_name)
        {
            Client = new MongoClient(conn_string);
            DBName = db_name;
            DBCollection = collection_name;
        }

        public void Write(T record)
        {
            Client
                .GetDatabase(DBName)
                .GetCollection<T>(DBCollection)
                .ReplaceOne(
                    filter: x => x.Id.Equals(record!.Id),
                    replacement: record!,
                    options: new ReplaceOptions()
                    {
                        IsUpsert = true
                    }
                );
        }

        public void WriteAll(List<T> records)
        {
            foreach (var record in records)
            {
                Write(record);
            }
        }

        public List<T> ReadAll() =>
            Client
                .GetDatabase(DBName)
                .GetCollection<T>(DBCollection)
                .Find(_ => true)
                .ToList();

        public List<T> ReadOne(ObjectId id) =>
            Client
                .GetDatabase(DBName)
                .GetCollection<T>(DBCollection)
                .Find(x => x.Id == id)
                .ToList();

        public void Delete(T record)
        {
            Client
                .GetDatabase(DBName)
                .GetCollection<T>(DBCollection)
                .DeleteOne(
                    filter: x => x.Id.Equals(record!.Id)
                );
        }}
}
