using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace BooksApi.Models
{
    public class Book
    {
        [BsonId] //primary key in MongoDB
        [BsonRepresentation(BsonType.ObjectId)] //allows passing as string instead of an ObjectId structure- Mongo handles conversion from string to ObjectId
        public string Id { get; set; }

        [BsonElement("Name")] // this property represents the property called name in the db
        [JsonProperty("Name")]
        public string BookName { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }
    }
}
