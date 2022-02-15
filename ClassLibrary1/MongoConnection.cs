using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ClassLibrary1
{
    public class MongoConnection
    {
        private MongoClient dbClient = new MongoClient("mongodb+srv://student6:student1234@cluster0.mzxtq.mongodb.net/dovGallery?retryWrites=true&w=majority");
        private IMongoDatabase db;
        private string dbName;

        public MongoConnection(string dbName)
        {
            this.dbName = dbName;
            db = dbClient.GetDatabase(dbName);
        }

        public IMongoCollection<BsonDocument> getCollectionByName(string nameColl)
        {
            return db.GetCollection<BsonDocument>(nameColl);
        }
    }
}
