using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace ApiClient
{
    public class StarWarsPeopleResponse
    {
        [JsonPropertyName("results")]
        public List<Person> Results { get; set; }
    }
}
