using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebChatChart.Models
{
    public class Metrics
    {
        public ObjectId Id { get; set; }
        [BsonElement("agentAverageResponseTime")]
        public int AgentAverageResponseTime { get; set; }
        [BsonElement("conversation_start_time")]
        public DateTime ConversationStartTime { get; set; }
        [BsonElement("first_response_time")]
        public string FirstResponseTime { get; set; }
        [BsonElement("conversation_finish_time")]
        public string ConversationFinishTime { get; set; }
        [BsonElement("customerAverageResponseTime")]
        public int CustomerAverageResponseTime { get; set; }
    }
}
