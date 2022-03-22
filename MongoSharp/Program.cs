using System;

using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("startup");
            var collec = database.GetCollection<BsonDocument>("employee");

            var document = new BsonDocument
            {
                {"name","alex" },
                {"Age","28" },
                {"Salary","12000" },
                {"position","designer" }
            };
            collec.InsertOneAsync(document);
            Console.Read();
        }
    }
}
