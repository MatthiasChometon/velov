using System;
using System.Text.Json.Serialization;

namespace velov.Models
{
    public class Value
    {
        [JsonPropertyName("pole")]
        public string pole { get; set; }
        [JsonPropertyName("available_bikes")]
        public string available_bikes { get; set; }
        [JsonPropertyName("lng")]
        public string lng { get; set; }
        [JsonPropertyName("bike_stands")]
        public string bike_stands { get; set; }
        [JsonPropertyName("last_update")]
        public string last_update { get; set; }
        [JsonPropertyName("available_bike_stands")]
        public string available_bike_stands { get; set; }
        [JsonPropertyName("commune")]
        public string commune { get; set; }
        [JsonPropertyName("adress2")]
        public string address2 { get; set; }
        [JsonPropertyName("address")]
        public string address { get; set; }
        [JsonPropertyName("lat")]
        public string lat { get; set; }
        [JsonPropertyName("last_update_fme")]
        public string last_update_fme { get; set; }
        [JsonPropertyName("name")]
        public string name { get; set; }
        [JsonPropertyName("marrond")]
        public string nmarrond { get; set; }
    }
}
