using System.Collections.Generic;
using Newtonsoft.Json;

namespace AspNetCore.Backend.Api.ViewModels
{
    public class ProductModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("img")]
        public string Img { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }
        [JsonProperty("price")]
        public decimal Price { get; set; }
        [JsonProperty("rating")]
        public decimal Rating { get; set; }
        [JsonProperty("description_1")]
        public string Description1 { get; set; }
        [JsonProperty("description_2")]
        public string Description2 { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("hashtag")]
        public string HashTag { get; set; }
        [JsonProperty("technology")]
        public List<string> Technologies { get; set; }
        [JsonProperty("discount")]
        public decimal Discount { get; set; }
    }
}
