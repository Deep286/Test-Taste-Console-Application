using System.Linq;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Test_Taste_Console_Application.Domain.DataTransferObjects.JsonObjects;

namespace Test_Taste_Console_Application.Domain.DataTransferObjects
{
    //The converter is needed for this DTO. Because of the converter, all the properties need to get the JsonProperty annotation. 
    [Newtonsoft.Json.JsonConverter(typeof(JsonPathConverter))]
    public class MoonDto
    {
        [JsonProperty("id")] public string Id { get; set; }

        //The property moon is used to set the Id property. 
        [JsonProperty("moon")]
        public string Moon
        {
            get => Id;
            set => Id = value;
        }

        //The path of the specific moon
        [JsonProperty("rel")] public string Rel { get; set; }
        public string URLId { get => Rel.Split('/').Last(); }

        //The path to the nested property is created by using a dot. 
        [JsonProperty("mass.massValue")] public float MassValue { get; set; }
        [JsonProperty("mass.massExponent")] public float MassExponent { get; set; }
    }
}
