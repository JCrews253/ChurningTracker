using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurningTracker
{
  public class MongoDb
  {
    private IMongoDatabase _db;

    public MongoDb(string database)
    {
      var client = new MongoClient();
      _db = client.GetDatabase(database);
    }

    public void Insert<T>(string table, T item)
    {
      var collection = _db.GetCollection<T>(table);
      collection.InsertOne(item);
    }

    public List<T> GetRecords<T>(string table)
    {
      return _db.GetCollection<T>(table).Find(new BsonDocument()).ToList();
    }

    public T GetRecord<T>(string table, Guid id)
    {
      var collection = _db.GetCollection<T>(table);
      var filter = Builders<T>.Filter.Eq("_id", id);

      return collection.Find(filter).FirstOrDefault();
    }

    public void UpsertRecord<T>(string table, Guid id, T record)
    {
      var collection = _db.GetCollection<T>(table);
      var result = collection.ReplaceOne(
        new BsonDocument("_id", id),
        record,
        new ReplaceOptions { IsUpsert = true });
    }

    public void Delete<T>(string table, Guid id)
    {
      var collection = _db.GetCollection<T>(table);
      var filter = Builders<T>.Filter.Eq("_id", id);
      collection.DeleteOne(filter);
    }
  }
}
