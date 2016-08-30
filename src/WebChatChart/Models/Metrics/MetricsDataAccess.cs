using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace WebChatChart.Models
{
    public class MetricsDataAccess
    {
        MongoClient _client;
        MongoServer _server;
        MongoDatabase _dbMongoDatabase;

        public MetricsDataAccess()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _server = _client.GetServer();
            _dbMongoDatabase = _server.GetDatabase("chatDetail");
        }

        public IEnumerable<Metrics> GetMetrics()
        {
            return _dbMongoDatabase.GetCollection<Metrics>("chatTimings").FindAll();
        }

        public Metrics GetMetric(ObjectId id)
        {
            var res = Query<Metrics>.EQ(m => m.Id ,id);
            return _dbMongoDatabase.GetCollection<Metrics>("chatTimings").FindOne(res);
        }
    }
}
