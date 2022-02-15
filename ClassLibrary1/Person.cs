using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ClassLibrary1
{
    public class Person
    {
        protected string name;
        protected string password;
        protected bool manager;

        public string GetName()
        {
            return this.name;
        }
        public string GetPassword()
        {
            return this.password;
        }
        public Person(string name, string password, bool manager)
        {
            this.name = name;
            this.password = password;
            this.manager = manager;
        }
        public BsonDocument getPersonDetailsDocByName()
        {
            MongoConnection mongo = new MongoConnection("dovGallery");
            IMongoCollection<BsonDocument> persons = mongo.getCollectionByName("persons");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("userName", this.GetName());
            return persons.Find(filter).FirstOrDefault();
        }

    }
}












