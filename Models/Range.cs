using System;
using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.Models
{
    public class Range
    {
       
        [Url]
        public string Id { get; set; }
        public Value? Label { get; set; }

        public List<Range>? Items { get; set; }


        public List<Metadata>? Metadata { get; set; }

        public Value? Summary { get; set; }

        public Metadata? RequiredStatement { get; set; }

        public string? Rights { get; set; }

        //must be xsd datetime literal
        public string? NavDate { get; set; }

        public PlaceholderCanvas? PlaceholderCanvas { get; set; }

        public string Type { get; set; }

        public string? ViewingDirection { get; set; }

        public List<string>? Behavior { get; set; }

        public List<Homepage>? Rendering { get; set; }

        public List<Service>? Service { get; set; }

        public List<SeeAlso>? SeeAlso { get; set; }

        public List<PartOf>? PartOf { get; set; }

        public Start? Start { get; set; }

        public List<Annotations>? Annotations { get; set; }




    }
}
