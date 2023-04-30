using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Friable_mongo.InfoModels
{
    public class Framing
    {
        [Key]
        public Guid Id { get; set; }

        public int? Height { get; set; }
        public int? Width { get; set; }
        public int? Depth { get; set; }
        public string? Shape { get; set; }
        public int? AppertureFrameHeight { get; set; }
        public int? ApertureFrameWidth { get; set; }
        public int? ApretureMountHeight { get; set; }
        public int? ApertureMountWidth { get; set; }
        public int? MaxPaintingDimensionsHeight { get; set; }
        public int? MaxPaintingDimensionsWidth { get; set; }
        public string? RabbetAccessible { get; set; }
        public int? RabbetHeight { get; set; }
        public int? RabbetWidth { get; set; }
        public int? RabbetDepth { get; set; }
        public int? InnerSpacersHeight { get; set; }
        public int? InnerSpacersWidth { get; set; }
        public int? InnerSpacersDepth { get; set; }
        public int? ExternalRisingSticksHeight { get; set; }
        public int? ExternalRisingSticksWidth { get; set; }
        public int? ExternalRisingSticksDepth { get; set; }
        public string? DimensionRemarks { get; set; }
        public string? MouldingMaterial { get; set; }
        public string? MouldingAssemblage { get; set; }
        public string? RaisingSticksMaterial { get; set; }
        public string? RaisingSticksAssemblage { get; set; }

        [NotMapped]
        public List<string>? InnerSpacers1 { get; set; }

        public string? InnerSpacers1Serialized
        {
            get => JsonConvert.SerializeObject(InnerSpacers1);
            set => InnerSpacers1 = JsonConvert.DeserializeObject<List<string>>(value);
        }
        [NotMapped]
        public List<string>? InnerSpacers2 { get; set; }

        public string? InnerSpacers2Serialized
        {
            get => JsonConvert.SerializeObject(InnerSpacers2);
            set => InnerSpacers2 = JsonConvert.DeserializeObject<List<string>>(value);
        }

        [NotMapped]
        public List<string>? BackingBoard1 { get; set; }

        public string? BackingBoard1Serialized
        {
            get => JsonConvert.SerializeObject(BackingBoard1);
            set => BackingBoard1 = JsonConvert.DeserializeObject<List<string>>(value);
        }
        [NotMapped]
        public List<string>? BackingBoard2 { get; set; }

        public string? BackingBoard2Serialized
        {
            get => JsonConvert.SerializeObject(BackingBoard2);
            set => BackingBoard2 = JsonConvert.DeserializeObject<List<string>>(value);
        }
        [NotMapped]
        public List<string>? Sealing { get; set; }

        public string? SealingSerialized
        {
            get => JsonConvert.SerializeObject(Sealing);
            set => Sealing = JsonConvert.DeserializeObject<List<string>>(value);
        }

        public string? HangingSystem { get; set; }
        public string? Indicators { get; set; }
        public string? DescriptionRemarks { get; set; }
        public string? Material { get; set; }
        public string? Assemblage { get; set; }
        public int? GlazingHeight { get; set; }
        public int? GlazingWidth { get; set; }
        public string? GlazingEstimation { get; set; }
        public string? GlazingRemarks { get; set; }
        public string? OriginalFraming { get; set; }
        public string? HistoryIndicators { get; set; }
        public int? LabelsAmount { get; set; }
        public string? HistoryDescription { get; set; }

        [NotMapped]
        public List<string>? Surface { get; set; }

        public string? SurfaceSerialized
        {
            get => JsonConvert.SerializeObject(Surface);
            set => Surface = JsonConvert.DeserializeObject<List<string>>(value);
        }

        [NotMapped]
        public List<string>? MechanicalProblems { get; set; }

        public string? MechanicalProblemsSerialized
        {
            get => JsonConvert.SerializeObject(MechanicalProblems);
            set => MechanicalProblems = JsonConvert.DeserializeObject<List<string>>(value);
        }

        [NotMapped]
        public List<string>? ChemicalProblems { get; set; }

        public string? ChemicalProblemsSerialized
        {
            get => JsonConvert.SerializeObject(ChemicalProblems);
            set => ChemicalProblems = JsonConvert.DeserializeObject<List<string>>(value);
        }

        [NotMapped]
        public List<string>? BiologicalProblems { get; set; }

        public string? BiologicalProblemsSerialized
        {
            get => JsonConvert.SerializeObject(BiologicalProblems);
            set => BiologicalProblems = JsonConvert.DeserializeObject<List<string>>(value);
        }

        [NotMapped]
        public List<string>? AestheticProblems { get; set; }

        public string? AestheticProblemsSerialized
        {
            get => JsonConvert.SerializeObject(AestheticProblems);
            set => AestheticProblems = JsonConvert.DeserializeObject<List<string>>(value);
        }

        public string? DamageRelevant { get; set; }

        //for links
        public string RegistrationID { get; set; }
        public virtual Registration? Registration { get; set; }


    }
}
