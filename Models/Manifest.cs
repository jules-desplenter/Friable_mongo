using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Friable_mongo.Models
{
    public class Manifest
    {

        public Manifest()
        {
            
        }

        [BsonId]
        public string Id { get; set; }

        [BsonElement("@context")]
        [JsonPropertyName("@context")]
        public string? Context { get; set; }

        public Value? Label { get; set; }



        public List<Canvas>? Items { get; set; }

        public List<Structures>? Structures { get; set; }

        public List<Metadata>? Metadata { get; set; }

        public Value? Summary { get; set; }

        public Metadata? RequiredStatement { get; set; }

        public string? Rights { get; set; }

        public Agent? Provider { get; set; }

        public Thumbnail? Thumbnail { get; set; }

        //must be xsd datetime literal
        public string? NavDate { get; set; }

        public PlaceholderCanvas? PlaceholderCanvas { get; set; }

        public string Type { get; set; }

        public string? ViewingDirection { get; set; }

        public List<Homepage>? Rendering { get; set; }

        public List<Service>? Service { get; set; }

        public List<SeeAlso>? SeeAlso { get; set; }

        public Start? Start { get; set; }

        public List<Annotations>? Annotations { get; set; }

        public List<string>? Behavior { get; set; }

        public NavPlace? NavPlace { get; set; }



    }


}
